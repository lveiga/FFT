using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste2Fourier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //Graphics g = this.CreateGraphics();

        //    //Pen pen = new Pen(Brushes.Black, 7.0F);
        //    //float pdValue;
        //    //float x1 = 0;
        //    //float y1 = 0;

        //    //float y2 = 0;

        //    //float yEx = 200;
        //    //float eF = 40;

        //    //string filename = @"C:\Users\lucas\source\repos\Teste2Fourier\Teste2Fourier\savio_test.txt";

        //    //var values2 = File.ReadAllLines(filename)
        //    //          .SelectMany(a => a.Split(',')
        //    //          .Select(str => float.TryParse(str, out pdValue) ? pdValue : 0));

        //    //float[] pdValues2 = values2.ToArray();


        //    //foreach (var x in pdValues2)
        //    //{
        //    //    y2 = (float)Math.Sin(x);

        //    //    g.DrawLine(pen, x1 * eF, y1 * eF + yEx, x * eF, y2 * eF + yEx);

        //    //    x1 = x;
        //    //    y1 = y2;
        //    //}
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            savio s = new savio();
            s.processar();

            var chart = chart1.ChartAreas[0];

            chart.AxisY.Maximum = 4099.0;
            chart.AxisY.Minimum = 4090.0;


            chart1.Series["Mercado"].Points.DataBindY(s.Mercado);
            chart2.Series["SomaOndas"].Points.DataBindY(s.SomaOndas);
            

        }
    }
}
