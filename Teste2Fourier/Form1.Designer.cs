namespace Teste2Fourier
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.chk8 = new System.Windows.Forms.CheckBox();
            this.chk16 = new System.Windows.Forms.CheckBox();
            this.chk32 = new System.Windows.Forms.CheckBox();
            this.chk64 = new System.Windows.Forms.CheckBox();
            this.chk128 = new System.Windows.Forms.CheckBox();
            this.chart64 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart128 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart16 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart8 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart128)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart8)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1146, 97);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Mercado";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series2.Label = "Soma";
            series2.Legend = "Legend1";
            series2.Name = "SomaOndas";
            series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(926, 300);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // chart3
            // 
            chartArea2.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart3.Legends.Add(legend2);
            this.chart3.Location = new System.Drawing.Point(1146, 450);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Frequency";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(945, 300);
            this.chart3.TabIndex = 4;
            this.chart3.Text = "chart3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Next Minute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chk8
            // 
            this.chk8.AutoSize = true;
            this.chk8.Location = new System.Drawing.Point(88, 62);
            this.chk8.Name = "chk8";
            this.chk8.Size = new System.Drawing.Size(32, 17);
            this.chk8.TabIndex = 6;
            this.chk8.Text = "8";
            this.chk8.UseVisualStyleBackColor = true;
            this.chk8.CheckedChanged += new System.EventHandler(this.chk8_CheckedChanged);
            // 
            // chk16
            // 
            this.chk16.AutoSize = true;
            this.chk16.Location = new System.Drawing.Point(192, 62);
            this.chk16.Name = "chk16";
            this.chk16.Size = new System.Drawing.Size(38, 17);
            this.chk16.TabIndex = 7;
            this.chk16.Text = "16";
            this.chk16.UseVisualStyleBackColor = true;
            this.chk16.CheckedChanged += new System.EventHandler(this.chk16_CheckedChanged);
            // 
            // chk32
            // 
            this.chk32.AutoSize = true;
            this.chk32.Location = new System.Drawing.Point(293, 62);
            this.chk32.Name = "chk32";
            this.chk32.Size = new System.Drawing.Size(38, 17);
            this.chk32.TabIndex = 8;
            this.chk32.Text = "32";
            this.chk32.UseVisualStyleBackColor = true;
            // 
            // chk64
            // 
            this.chk64.AutoSize = true;
            this.chk64.Location = new System.Drawing.Point(408, 62);
            this.chk64.Name = "chk64";
            this.chk64.Size = new System.Drawing.Size(38, 17);
            this.chk64.TabIndex = 9;
            this.chk64.Text = "64";
            this.chk64.UseVisualStyleBackColor = true;
            // 
            // chk128
            // 
            this.chk128.AutoSize = true;
            this.chk128.Location = new System.Drawing.Point(503, 62);
            this.chk128.Name = "chk128";
            this.chk128.Size = new System.Drawing.Size(44, 17);
            this.chk128.TabIndex = 10;
            this.chk128.Text = "128";
            this.chk128.UseVisualStyleBackColor = true;
            // 
            // chart64
            // 
            chartArea3.Name = "ChartArea1";
            this.chart64.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart64.Legends.Add(legend3);
            this.chart64.Location = new System.Drawing.Point(25, 441);
            this.chart64.Name = "chart64";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series4.Legend = "Legend1";
            series4.Name = "Mercado";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series5.Label = "Soma";
            series5.Legend = "Legend1";
            series5.Name = "SomaOndas";
            series5.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series5.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart64.Series.Add(series4);
            this.chart64.Series.Add(series5);
            this.chart64.Size = new System.Drawing.Size(482, 300);
            this.chart64.TabIndex = 11;
            this.chart64.Text = "chart2";
            // 
            // chart128
            // 
            chartArea4.Name = "ChartArea1";
            this.chart128.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart128.Legends.Add(legend4);
            this.chart128.Location = new System.Drawing.Point(522, 441);
            this.chart128.Name = "chart128";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series6.Legend = "Legend1";
            series6.Name = "Mercado";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series7.Label = "Soma";
            series7.Legend = "Legend1";
            series7.Name = "SomaOndas";
            series7.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series7.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart128.Series.Add(series6);
            this.chart128.Series.Add(series7);
            this.chart128.Size = new System.Drawing.Size(508, 300);
            this.chart128.TabIndex = 12;
            this.chart128.Text = "chart4";
            // 
            // chart16
            // 
            chartArea5.Name = "ChartArea1";
            this.chart16.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart16.Legends.Add(legend5);
            this.chart16.Location = new System.Drawing.Point(522, 97);
            this.chart16.Name = "chart16";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series8.Legend = "Legend1";
            series8.Name = "Mercado";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series9.Label = "Soma";
            series9.Legend = "Legend1";
            series9.Name = "SomaOndas";
            series9.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series9.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart16.Series.Add(series8);
            this.chart16.Series.Add(series9);
            this.chart16.Size = new System.Drawing.Size(508, 300);
            this.chart16.TabIndex = 13;
            this.chart16.Text = "chart5";
            // 
            // chart8
            // 
            chartArea6.Name = "ChartArea1";
            this.chart8.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart8.Legends.Add(legend6);
            this.chart8.Location = new System.Drawing.Point(12, 97);
            this.chart8.Name = "chart8";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series10.Legend = "Legend1";
            series10.Name = "Mercado";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series11.Label = "Soma";
            series11.Legend = "Legend1";
            series11.Name = "SomaOndas";
            series11.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series11.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart8.Series.Add(series10);
            this.chart8.Series.Add(series11);
            this.chart8.Size = new System.Drawing.Size(495, 300);
            this.chart8.TabIndex = 14;
            this.chart8.Text = "chart6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2094, 813);
            this.Controls.Add(this.chart8);
            this.Controls.Add(this.chart16);
            this.Controls.Add(this.chart128);
            this.Controls.Add(this.chart64);
            this.Controls.Add(this.chk128);
            this.Controls.Add(this.chk64);
            this.Controls.Add(this.chk32);
            this.Controls.Add(this.chk16);
            this.Controls.Add(this.chk8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart128)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chk8;
        private System.Windows.Forms.CheckBox chk16;
        private System.Windows.Forms.CheckBox chk32;
        private System.Windows.Forms.CheckBox chk64;
        private System.Windows.Forms.CheckBox chk128;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart64;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart128;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart16;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart8;
    }
}

