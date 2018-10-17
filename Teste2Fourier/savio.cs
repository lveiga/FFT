using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Teste2Fourier
{
    public class savio
    {

        public void processar()
        {
            CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.CurrencyDecimalSeparator = ".";
            string filename = @"C:\workspace\FFT_BOT\Teste2Fourier\savio_test.txt";
            double mediaPeriodo = 0;
            double periodo = 30;
            int startLine = 0;

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
                }
            }

            lcoOHLCEntity.ForEach(x => mediaPeriodo += x.Close);
            mediaPeriodo = mediaPeriodo / periodo;

            double[] senosBase = new double[30];
            double[,] matrixSenos = new double[10, 31];

            double[] senosIndice1 = new double[30];

            bool aindaExistePeriodo = true;

            while (aindaExistePeriodo)
            {
                int skipResult = 0;
                int takeResult = 30;
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
                        senosBase[countSeno] = item.Close - mediaPeriodo;
                        countSeno++;
                    }

                    for (int coluna = 0; coluna < 10; coluna++)
                    {
                        double media = 0;

                        for (int linha = 0; linha < 30; linha++)
                        {
                            matrixSenos[coluna, linha] = senosBase[linha] * Math.Sin(ponto * (linha + 1) * ponto2 * (coluna + 1));
                            media += matrixSenos[coluna, linha];
                        }

                        matrixSenos[coluna, 30] = media / 30;
                    }



                }
            }
        }
    }
}
