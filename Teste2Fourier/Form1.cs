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
