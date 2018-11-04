﻿using System;
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
using System.Windows.Threading;


namespace Teste2Fourier
{
    public partial class Form1 : Form
    {
        public List<OHLCEntity> lcoOHLCEntity = new List<OHLCEntity>();
        OndaNegocio s = new OndaNegocio(30);
        int skip = 0;
        int take = 30;

        public Form1()
        {
            InitializeComponent();

            button2.Click += button2_Click;
            button1.Click += button1_Click;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lcoOHLCEntity = s.processar();

            List<OHLCEntity> OHLCPeriodo = lcoOHLCEntity.Skip(skip).Take(take).OrderBy(x => x.Data).ToList();

            s.IniciarAnalise(OHLCPeriodo, take, skip);

            double maxValue = s.Mercado.Max();
            double minValue = s.Mercado.Min();
            
            var chart = chart1.ChartAreas[0];
            chart.AxisY.Maximum = maxValue;
            chart.AxisY.Minimum = minValue;
            

            chart1.Series["Mercado"].Points.DataBindY(s.Mercado);
            chart2.Series["SomaOndas"].Points.DataBindY(s.SomaOndas);

            for (int coluna = 0; coluna < 1; coluna++)
            {
                for (int linha = 0; linha < 30; linha++)
                {
                    double mag = (1.0 / 30) * (Math.Sqrt(Math.Pow(s.complex[coluna, linha].Real, 2) + Math.Pow(s.complex[coluna, linha].Imaginary, 2)));
                    chart3.Series["Frequency"].Points.AddXY(1 * linha, mag);
                }
            }

            skip++;
            button1.Enabled = true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ExecutarProximoMinuto();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 1000 };
            timer.Tick += HandleTimerTick;
            timer.Start();
            button1.Enabled = false;
        }

        private void HandleTimerTick(object sender, EventArgs e)
        {
            ExecutarProximoMinuto();
        }


        private void ExecutarProximoMinuto()
        {
            List<OHLCEntity> OHLCPeriodo = lcoOHLCEntity.Skip(skip).Take(30).OrderBy(x => x.Data).ToList();

            s.IniciarAnalise(OHLCPeriodo, 30, skip);

            double maxValue = s.Mercado.Max();
            double minValue = s.Mercado.Min();

            var chart = chart1.ChartAreas[0];
            chart.AxisY.Maximum = maxValue;
            chart.AxisY.Minimum = minValue;

            chart1.Series["Mercado"].Points.DataBindY(s.Mercado);
            chart2.Series["SomaOndas"].Points.DataBindY(s.SomaOndas);

            for (int coluna = 0; coluna < 1; coluna++)
            {
                for (int linha = 0; linha < 30; linha++)
                {
                    double mag = (1.0 / 30) * (Math.Sqrt(Math.Pow(s.complex[s.maior, linha].Real, 2) + Math.Pow(s.complex[s.maior, linha].Imaginary, 2)));
                    chart3.Series["Frequency"].Points.AddXY(1 * linha, mag);
                }
            }

            skip++;
        }
    }
}
