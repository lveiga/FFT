using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Teste2Fourier
{
    public class savio
    {

        public double[,] matrixOndas = new double[10, 30];
        public double[] Mercado = new double[30];
        public double[] SomaOndas = new double[30];
        public double[,] matrixSomaOndas = new double[9, 30];

        public void processar()
        {
            CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.CurrencyDecimalSeparator = ".";
            //string filename = @"C:\workspace\FFT_BOT\Teste2Fourier\savio_test.txt";
            string filename = @"C:\Users\lucas\source\repos\Teste2Fourier\Teste2Fourier\savio_test.txt";
            double mediaPeriodo = 0;
            double periodo = 30;
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
                        Data = Convert.ToDateTime(temp[0]),
                        Open = double.Parse(temp[1], NumberStyles.Any, ci),
                        High = double.Parse(temp[2], NumberStyles.Any, ci),
                        Low = double.Parse(temp[3], NumberStyles.Any, ci),
                        Close = double.Parse(temp[4], NumberStyles.Any, ci)
                    };
                    lcoOHLCEntity.Add(oHLCEntity);

                    
                    Mercado[linhaMercado] = double.Parse(temp[4], NumberStyles.Any, ci);
                    linhaMercado++;
                    
                }
            }

            lcoOHLCEntity.ForEach(x => mediaPeriodo += x.Close);
            mediaPeriodo = mediaPeriodo / periodo;

            double[] Base = new double[30];
            double[,] matrixSenos = new double[10, 31];
            double[,] matrixConsenos = new double[10, 31];

            double[] senosIndice1 = new double[30];

            bool aindaExistePeriodo = true;

            int skipResult = 0;
            int takeResult = 30;

            while (aindaExistePeriodo)
            {
                
                int countSeno = 0;
                double ponto = 0.05;
                double ponto2 = 1.5;
                List<OHLCEntity> OHLCPeriodo = lcoOHLCEntity.Skip(skipResult).Take(takeResult).OrderBy(x => x.Data).ToList();

                if (OHLCPeriodo.Count == 0)
                {
                    aindaExistePeriodo = false;
                }

                if (aindaExistePeriodo)
                {
                    foreach (OHLCEntity item in OHLCPeriodo)
                    {
                        Base[countSeno] = item.Close - mediaPeriodo;
                        countSeno++;
                    }

                    ObterSenos(Base, matrixSenos, ponto, ponto2);

                    ObterCosenos(Base, matrixSenos, matrixConsenos, ponto, ponto2);

                    ObterOndas(matrixSenos, matrixConsenos, matrixOndas);

                    for (int coluna = 0; coluna < 9; coluna++)
                    {
                        for (int linha = 0; linha < 30; linha++)
                        {
                            matrixSomaOndas[coluna, linha] = matrixOndas[0,linha] + matrixOndas[(coluna + 1), linha];
                        }
                    }

                                                           
                    for (int linhaSomaOndas = 0; linhaSomaOndas < 30; linhaSomaOndas++)
                    {
                        SomaOndas[linhaSomaOndas] = matrixSomaOndas[7,linhaSomaOndas];
                    }

                }
                skipResult += 30;
            }
        }

        private static void ObterOndas(double[,] matrixSenos, double[,] matrixConsenos, double[,] matrixOndas)
        {
            for (int coluna = 0; coluna < 10; coluna++)
            {
                for (int linha = 0; linha < 30; linha++)
                {
                    matrixOndas[coluna, linha] = matrixSenos[coluna, 30] * Math.Sin(0.05 * (linha + 1) * 1.5 * (coluna + 1)) + matrixConsenos[coluna, 30] * Math.Cos(0.05 * (linha + 1) * 1.5 * (coluna + 1));
                }
            }
        }

        private static void ObterCosenos(double[] senosBase, double[,] matrixSenos, double[,] matrixConsenos, double ponto, double ponto2)
        {
            for (int coluna = 0; coluna < 10; coluna++)
            {
                double media = 0;
                for (int linha = 0; linha < 30; linha++)
                {
                    matrixConsenos[coluna, linha] = senosBase[linha] * Math.Cos(ponto * (linha + 1) * ponto2 * (coluna + 1));
                    media += matrixConsenos[coluna, linha];
                }

                matrixConsenos[coluna, 30] = media / 30;
            }
        }

        private static void ObterSenos(double[] cosenoBase, double[,] matrixSenos, double ponto, double ponto2)
        {
            for (int coluna = 0; coluna < 10; coluna++)
            {
                double media = 0;

                for (int linha = 0; linha < 30; linha++)
                {
                    matrixSenos[coluna, linha] = cosenoBase[linha] * Math.Sin(ponto * (linha + 1) * ponto2 * (coluna + 1));
                    media += matrixSenos[coluna, linha];
                }

                matrixSenos[coluna, 30] = media / 30;
            }
        }
    }
}
