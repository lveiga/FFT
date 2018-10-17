using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste2Fourier
{
    public class OHLCEntity
    {
        public DateTime Data { get; set; }// minutos
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double MediaPeriodo { get; set; }
    }
}
