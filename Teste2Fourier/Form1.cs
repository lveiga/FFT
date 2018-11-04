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
        OndaNegocio ondaNegocio = new OndaNegocio(32);
        int skip = 0;
        int take = 32;

        public Form1()
        {
            InitializeComponent();

            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lcoOHLCEntity = ondaNegocio.processar();

            List<OHLCEntity> OHLCPeriodo = lcoOHLCEntity.Skip(skip).Take(take).OrderBy(x => x.Data).ToList();

            ondaNegocio.IniciarAnalise(OHLCPeriodo, take, skip);

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

            ondaNegocio.IniciarAnalise(OHLCPeriodo, 32, skip);

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
                    double mag = (1.0 / 30) * (Math.Sqrt(Math.Pow(ondaNegocio.complex[ondaNegocio.maior, linha].Real, 2) + Math.Pow(ondaNegocio.complex[ondaNegocio.maior, linha].Imaginary, 2)));
                    chart3.Series["Frequency"].Points.AddXY(1 * linha, mag);
                }
            }

            skip++;
        }

        public void CreateYAxis(Chart chart, ChartArea area, Series series, float axisOffset, float labelsSize)
        {
            // Create new chart area for original series
            ChartArea areaSeries = chart.ChartAreas.Add("ChartArea_" + series.Name);
            areaSeries.BackColor = Color.Transparent;
            areaSeries.BorderColor = Color.Transparent;
            areaSeries.Position.FromRectangleF(area.Position.ToRectangleF());
            areaSeries.InnerPlotPosition.FromRectangleF(area.InnerPlotPosition.ToRectangleF());
            areaSeries.AxisX.MajorGrid.Enabled = false;
            areaSeries.AxisX.MajorTickMark.Enabled = false;
            areaSeries.AxisX.LabelStyle.Enabled = false;
            areaSeries.AxisY.MajorGrid.Enabled = false;
            areaSeries.AxisY.MajorTickMark.Enabled = false;
            areaSeries.AxisY.LabelStyle.Enabled = false;
            areaSeries.AxisY.IsStartedFromZero = area.AxisY.IsStartedFromZero;


            series.ChartArea = areaSeries.Name;

            // Create new chart area for axis
            ChartArea areaAxis = chart.ChartAreas.Add("AxisY_" + series.ChartArea);
            areaAxis.BackColor = Color.Transparent;
            areaAxis.BorderColor = Color.Transparent;
            areaAxis.Position.FromRectangleF(chart.ChartAreas[series.ChartArea].Position.ToRectangleF());
            areaAxis.InnerPlotPosition.FromRectangleF(chart.ChartAreas[series.ChartArea].InnerPlotPosition.ToRectangleF());

            // Create a copy of specified series
            Series seriesCopy = chart.Series.Add(series.Name + "_Copy");
            seriesCopy.ChartType = series.ChartType;
            foreach (DataPoint point in series.Points)
            {
                seriesCopy.Points.AddXY(point.XValue, point.YValues[0]);
            }

            // Hide copied series
            seriesCopy.IsVisibleInLegend = false;
            seriesCopy.Color = Color.Transparent;
            seriesCopy.BorderColor = Color.Transparent;
            seriesCopy.ChartArea = areaAxis.Name;

            // Disable drid lines & tickmarks
            areaAxis.AxisX.LineWidth = 0;
            areaAxis.AxisX.MajorGrid.Enabled = false;
            areaAxis.AxisX.MajorTickMark.Enabled = false;
            areaAxis.AxisX.LabelStyle.Enabled = false;
            areaAxis.AxisY.MajorGrid.Enabled = false;
            areaAxis.AxisY.IsStartedFromZero = area.AxisY.IsStartedFromZero;
            areaAxis.AxisY.LabelStyle.Font = area.AxisY.LabelStyle.Font;

            // Adjust area position
            areaAxis.Position.X -= axisOffset;
            areaAxis.InnerPlotPosition.X += labelsSize;

        }
    }
}
