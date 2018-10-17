using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste2Fourier
{
    public class savio
    {

        public void processar()
        {
            CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.CurrencyDecimalSeparator = ".";
            string filename = @"C:\Users\lucas\source\repos\Teste2Fourier\Teste2Fourier\savio_test.txt";
            double pdValue;
            double mediaPeriodo = 0;
            double periodo = 30;

            int indice = 1;
            int startLine = 0;
            int lineCount = 1;

            List<OHLCEntity> lcoOHLCEntity = new List<OHLCEntity>();

            var values = File.ReadAllLines(filename).Skip((startLine)).ToList();
            foreach (string line in values)
            {
                string[] temp = line.Split(',');
                if (temp.Length >= 4)
                {
                    OHLCEntity oHLCEntity = new OHLCEntity();
                    oHLCEntity.Data = Convert.ToDateTime(temp[0]);
                    oHLCEntity.Open = double.Parse(temp[1], NumberStyles.Any, ci);
                    oHLCEntity.High = double.Parse(temp[2], NumberStyles.Any, ci);
                    oHLCEntity.Low = double.Parse(temp[3], NumberStyles.Any, ci);
                    oHLCEntity.Close = double.Parse(temp[4], NumberStyles.Any, ci);
                    lcoOHLCEntity.Add(oHLCEntity);
                }
            }

            lcoOHLCEntity.ForEach(x => mediaPeriodo += x.Close);
            mediaPeriodo = mediaPeriodo / periodo;

            double[] senosBase = new double[30];
            double[] senosIndice1 = new double[30];

            bool aindaExistePeriodo = true;

            while (aindaExistePeriodo)
            {
                int skipResult = 0;
                int takeResult = 30;
                int countSeno = 0;
                double indiceSeno = 1;
                double ponto = 0.5;
                double ponto2 = 1.5;
                List<OHLCEntity> OHLCPeriodo = lcoOHLCEntity.Skip(skipResult).Take(takeResult).OrderBy(x => x.Data).ToList();

                if (OHLCPeriodo.Count == 0)
                    aindaExistePeriodo = false;


                if (aindaExistePeriodo)
                {
                    foreach (var item in OHLCPeriodo)
                    {
                        senosBase[countSeno] = item.Close - mediaPeriodo;
                        countSeno++;
                    }

                    for (int i = 0; i < senosBase.Count(); i++)
                    {
                        int x = i + 1;
                        senosIndice1[i] = senosBase[i] * Math.Sin(ponto * x * ponto2 * 1);
                    }

                }
            }
        }
    }
}
