using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Threading;


namespace Teste2Fourier
{
    public partial class Form1 : Form
    {
        public List<OHLCEntity> lcoOHLCEntity = new List<OHLCEntity>();
        OndaNegocio ondaNegocio = new OndaNegocio();
        int skip = 0;
        int defaultValue = 32;
        int qtdProcesso8, qtdProcesso16, qtdProcesso64, qtdProcesso128 = 0;
        private ChartArea aChart8 = null;
        private ChartArea aChart16 = null;
        private ChartArea aChart32 = null;
        private ChartArea aChart64 = null;
        private ChartArea aChart128 = null;

        public Form1()
        {
            InitializeComponent();

            button1.Enabled = false;
            chk32.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IniciarProcessamento();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            aChart32 = chart1.ChartAreas[0];
            ExecutarProximoMinuto(defaultValue, aChart32, chart1);
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 1000 };
            timer.Tick += HandleTimerTick;
            timer.Start();
            button1.Enabled = false;
        }


        private void IniciarProcessamento()
        {
            lcoOHLCEntity = ondaNegocio.processar();

            List<OHLCEntity> OHLCPeriodo = lcoOHLCEntity.Skip(skip).Take(defaultValue).OrderBy(x => x.Data).ToList();

            ondaNegocio.IniciarAnalise(OHLCPeriodo, defaultValue, skip);

            double maxValue = ondaNegocio.Mercado.Max();
            double minValue = ondaNegocio.Mercado.Min();
            double maxValue2 = ondaNegocio.SomaOndas.Max();
            double minValue2 = ondaNegocio.SomaOndas.Min();

            var chart = chart1.ChartAreas[0];
            chart.AxisY.Maximum = maxValue;
            chart.AxisY.Minimum = minValue;
            chart.AxisY2.Maximum = maxValue2;
            chart.AxisY2.Minimum = minValue2;

            chart1.Series["Mercado"].Points.DataBindY(ondaNegocio.Mercado);
            chart1.Series["SomaOndas"].Points.DataBindY(ondaNegocio.SomaOndas);

            for (int coluna = 0; coluna < 1; coluna++)
            {
                for (int linha = 0; linha < 30; linha++)
                {
                    double mag = (1.0 / 30) * (Math.Sqrt(Math.Pow(ondaNegocio.complex[coluna, linha].Real, 2) + Math.Pow(ondaNegocio.complex[coluna, linha].Imaginary, 2)));
                    chart3.Series["Frequency"].Points.AddXY(1 * linha, mag);
                }
            }

            skip++;
            button1.Enabled = true;
        }

        private void ExecutarProximoMinuto(int qtdProcesso, ChartArea chart, Chart chart1)
        {
            List<OHLCEntity> OHLCPeriodo = lcoOHLCEntity.Skip(skip).Take(qtdProcesso).OrderBy(x => x.Data).ToList();

            ondaNegocio.IniciarAnalise(OHLCPeriodo, qtdProcesso, skip);

            double maxValue = ondaNegocio.Mercado.Max();
            double minValue = ondaNegocio.Mercado.Min();
            double maxValue2 = ondaNegocio.SomaOndas.Max();
            double minValue2 = ondaNegocio.SomaOndas.Min();

            
            chart.AxisY.Maximum = maxValue;
            chart.AxisY.Minimum = minValue;
            chart.AxisY2.Maximum = maxValue2;
            chart.AxisY2.Minimum = minValue2;



            chart1.Series["Mercado"].Points.DataBindY(ondaNegocio.Mercado);
            chart1.Series["SomaOndas"].Points.DataBindY(ondaNegocio.SomaOndas);

            for (int coluna = 0; coluna < 1; coluna++)
            {
                for (int linha = 0; linha < qtdProcesso; linha++)
                {
                    double mag = (1.0 / qtdProcesso) * (Math.Sqrt(Math.Pow(ondaNegocio.complex[ondaNegocio.maior, linha].Real, 2) + Math.Pow(ondaNegocio.complex[ondaNegocio.maior, linha].Imaginary, 2)));
                    chart3.Series["Frequency"].Points.AddXY(1 * linha, mag);
                }
            }

            skip++;
        }

        private void chk8_CheckedChanged(object sender, EventArgs e)
        {
            if (!chk8.Enabled)
                return;

            aChart8 = chart8.ChartAreas[0];
            qtdProcesso8 = 8;
            ExecutarProximoMinuto(qtdProcesso8, aChart8, chart8);
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 1000 };
            timer.Tick += HandleTimerTickCheck8;
            timer.Start();
            
        }

        private void chk32_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk128_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!chk128.Enabled)
                return;

            aChart128 = chart128.ChartAreas[0];
            qtdProcesso128 = 128;
            ExecutarProximoMinuto(qtdProcesso128, aChart128, chart128);
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 1000 };
            timer.Tick += HandleTimerTickCheck128;
            timer.Start();
        }

        private void chk64_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!chk64.Enabled)
                return;


            aChart64 = chart16.ChartAreas[0];
            qtdProcesso64 = 64;
            ExecutarProximoMinuto(qtdProcesso64, aChart64, chart64);
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 1000 };
            timer.Tick += HandleTimerTickCheck64;
            timer.Start();
        }

        private void chk16_CheckedChanged(object sender, EventArgs e)
        {

            if (!chk16.Enabled)
                return;

            aChart16 = chart16.ChartAreas[0];
            qtdProcesso16 = 16;
            ExecutarProximoMinuto(qtdProcesso16, aChart16, chart16);
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 1000 };
            timer.Tick += HandleTimerTickCheck16;
            timer.Start();
        }

        #region handlers
        private void HandleTimerTick(object sender, EventArgs e)
        {
            ExecutarProximoMinuto(defaultValue, aChart32, chart1);
        }

        private void HandleTimerTickCheck8(object sender, EventArgs e)
        {
            ExecutarProximoMinuto(qtdProcesso8, aChart8, chart8);
        }

        private void HandleTimerTickCheck16(object sender, EventArgs e)
        {
            ExecutarProximoMinuto(qtdProcesso16, aChart16, chart16);
        }

        private void HandleTimerTickCheck64(object sender, EventArgs e)
        {
            ExecutarProximoMinuto(qtdProcesso64, aChart64, chart64);
        }

        private void HandleTimerTickCheck128(object sender, EventArgs e)
        {
            ExecutarProximoMinuto(qtdProcesso128, aChart128, chart128);
        }

        #endregion

    }
}
