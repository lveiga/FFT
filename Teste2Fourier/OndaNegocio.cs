using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;

namespace Teste2Fourier
{
    public class OndaNegocio
    {
        private static int qtdProcesso = 0;

        public double[,] matrixOndas = null;
        public double[]  MercadoTotal = null;
        public double[]  Mercado = null;
        public double[]  SomaOndas = null;
        public double[,] matrixSomaOndas = null;
        public Complex[,] complex = null;
        public int maior = 0;

        public OndaNegocio(int qtd)
        {
            qtdProcesso = qtd;
            matrixOndas = new double[10, qtdProcesso];
            MercadoTotal = new double[1000];
            Mercado = new double[qtdProcesso];
            SomaOndas = new double[qtdProcesso];
            matrixSomaOndas = new double[9, qtdProcesso + 1];
            complex = new Complex[9, qtdProcesso];
        }


        public List<OHLCEntity> processar()
        {
            CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.CurrencyDecimalSeparator = ".";
            //string filename = @"C:\workspace\FFT_BOT\Teste2Fourier\savio_test.txt";
            string filename = @"C:\Users\lucas\source\repos\Teste2Fourier\Teste2Fourier\savio_test2.txt";
            
            int startLine = 0;
            int linhaMercado = 0;
            

            List<OHLCEntity> lcoOHLCEntity = new List<OHLCEntity>();

            List<string> values = File.ReadAllLines(filename).Skip((startLine)).ToList();
            foreach (string line in values)
            {
                string[] temp = line.Split(',');
                if (temp.Length >= 4)
                {
                    OHLCEntity oHLCEntity = new OHLCEntity
                    {
                        Data = DateTime.ParseExact(temp[0], "d/MM/yyyy HH:mm", CultureInfo.CreateSpecificCulture("pt-BR")),
                        Open = double.Parse(temp[1], NumberStyles.Any, ci),
                        High = double.Parse(temp[2], NumberStyles.Any, ci),
                        Low = double.Parse(temp[3], NumberStyles.Any, ci),
                        Close = double.Parse(temp[4], NumberStyles.Any, ci)
                    };
                    lcoOHLCEntity.Add(oHLCEntity);

                    
                    MercadoTotal[linhaMercado] = double.Parse(temp[4], NumberStyles.Any, ci);
                    linhaMercado++;
                    
                }
            }
            return lcoOHLCEntity;
        }

        public void IniciarAnalise(List<OHLCEntity> OHLCPeriodo, int ItemsPerpage, int CurrentPage)
        {
            if (OHLCPeriodo.Count == 0)
            {
                return;
            }

            double mediaPeriodo = 0;
            double periodo = qtdProcesso;
            double[] Base = new double[qtdProcesso];
            double[,] matrixSenos = new double[10, qtdProcesso + 1];
            double[,] matrixConsenos = new double[10, qtdProcesso + 1];
            double[] senosIndice1 = new double[qtdProcesso];
            double ponto = 0.05;
            double ponto2 = 1.5;
            int countSeno = 0;

            Mercado = MercadoTotal.Cast<double>().Skip(CurrentPage).Take(ItemsPerpage).ToArray();

            OHLCPeriodo.ForEach(x => mediaPeriodo += x.Close);
            mediaPeriodo = mediaPeriodo / periodo;

            foreach (OHLCEntity item in OHLCPeriodo)
            {
                Base[countSeno] = item.Close - mediaPeriodo;
                countSeno++;
            }

            ObterSenos(Base, matrixSenos, ponto, ponto2);

            ObterCosenos(Base, matrixSenos, matrixConsenos, ponto, ponto2);

            ObterOndas(matrixSenos, matrixConsenos, matrixOndas);

            SelecionandoMelhorOnda();

            PreenchendoMelhorOnda();

            FrequenciaDolar freq = new FrequenciaDolar();
            complex = freq.ObterFrequencia(matrixSomaOndas, qtdProcesso);
        }

        private void PreenchendoMelhorOnda()
        {
            maior = ObterMaiorPorcentagem();

            for (int linhaSomaOndas = 0; linhaSomaOndas < qtdProcesso; linhaSomaOndas++)
            {
                SomaOndas[linhaSomaOndas] = matrixSomaOndas[maior, linhaSomaOndas];
            }
        }

        private void SelecionandoMelhorOnda()
        {
            for (int coluna = 0; coluna < 9; coluna++)
            {
                double[] mediaArray = new double[qtdProcesso];
                for (int linha = 0; linha < qtdProcesso; linha++)
                {
                    matrixSomaOndas[coluna, linha] = matrixOndas[0, linha] + matrixOndas[(coluna + 1), linha];
                    mediaArray[linha] = matrixOndas[0, linha] + matrixOndas[(coluna + 1), linha];
                }

                matrixSomaOndas[coluna, qtdProcesso] = ComputarCoeficiente(Mercado, mediaArray);
            }
        }

        private int ObterMaiorPorcentagem()
        {
            int maior = 0;
            double[] maxValues = new double[9];
            for (int coluna = 0; coluna < 9; coluna++)
            {
                maxValues[coluna] = matrixSomaOndas[(coluna), qtdProcesso];
            }

            double maxValue = maxValues.Max();
            maior = maxValues.ToList().IndexOf(maxValue);

            return maior;
        }

        private static void ObterOndas(double[,] matrixSenos, double[,] matrixConsenos, double[,] matrixOndas)
        {
            for (int coluna = 0; coluna < 10; coluna++)
            {
                for (int linha = 0; linha < qtdProcesso; linha++)
                {
                    matrixOndas[coluna, linha] = matrixSenos[coluna, qtdProcesso] * Math.Sin(0.05 * (linha + 1) * 1.5 * (coluna + 1)) + matrixConsenos[coluna, qtdProcesso] * Math.Cos(0.05 * (linha + 1) * 1.5 * (coluna + 1));
                }
            }
        }

        private static void ObterCosenos(double[] senosBase, double[,] matrixSenos, double[,] matrixConsenos, double ponto, double ponto2)
        {
            for (int coluna = 0; coluna < 10; coluna++)
            {
                double media = 0;
                for (int linha = 0; linha < qtdProcesso; linha++)
                {
                    matrixConsenos[coluna, linha] = senosBase[linha] * Math.Cos(ponto * (linha + 1) * ponto2 * (coluna + 1));
                    media += matrixConsenos[coluna, linha];
                }

                matrixConsenos[coluna, qtdProcesso] = media / qtdProcesso;
            }
        }

        private static void ObterSenos(double[] cosenoBase, double[,] matrixSenos, double ponto, double ponto2)
        {
            for (int coluna = 0; coluna < 10; coluna++)
            {
                double media = 0;

                for (int linha = 0; linha < qtdProcesso; linha++)
                {
                    matrixSenos[coluna, linha] = cosenoBase[linha] * Math.Sin(ponto * (linha + 1) * ponto2 * (coluna + 1));
                    media += matrixSenos[coluna, linha];
                }

                matrixSenos[coluna, qtdProcesso] = media / qtdProcesso;
            }
        }

        private double ComputarCoeficiente(double[] values1, double[] values2)
        {
            if (values1.Length != values2.Length)
                throw new ArgumentException("values must be the same length");

            var avg1 = values1.Average();
            var avg2 = values2.Average();

            var sum1 = values1.Zip(values2, (x1, y1) => (x1 - avg1) * (y1 - avg2)).Sum();

            var sumSqr1 = values1.Sum(x => Math.Pow((x - avg1), 2.0));
            var sumSqr2 = values2.Sum(y => Math.Pow((y - avg2), 2.0));

            var result = sum1 / Math.Sqrt(sumSqr1 * sumSqr2);

            return result;
        }
    }
}
