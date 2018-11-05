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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series32 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series33 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea13.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chart1.Legends.Add(legend13);
            this.chart1.Location = new System.Drawing.Point(1146, 97);
            this.chart1.Name = "chart1";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series23.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series23.Legend = "Legend1";
            series23.Name = "Mercado";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series24.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series24.Label = "Soma";
            series24.Legend = "Legend1";
            series24.Name = "SomaOndas";
            series24.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series24.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart1.Series.Add(series23);
            this.chart1.Series.Add(series24);
            this.chart1.Size = new System.Drawing.Size(926, 300);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // chart3
            // 
            chartArea14.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chart3.Legends.Add(legend14);
            this.chart3.Location = new System.Drawing.Point(1146, 450);
            this.chart3.Name = "chart3";
            series25.ChartArea = "ChartArea1";
            series25.Legend = "Legend1";
            series25.Name = "Frequency";
            this.chart3.Series.Add(series25);
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
            this.chk32.CheckedChanged += new System.EventHandler(this.chk32_CheckedChanged);
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
            this.chk64.CheckedChanged += new System.EventHandler(this.chk64_CheckedChanged_1);
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
            this.chk128.CheckedChanged += new System.EventHandler(this.chk128_CheckedChanged_1);
            // 
            // chart64
            // 
            chartArea15.Name = "ChartArea1";
            this.chart64.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.chart64.Legends.Add(legend15);
            this.chart64.Location = new System.Drawing.Point(25, 441);
            this.chart64.Name = "chart64";
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series26.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series26.Legend = "Legend1";
            series26.Name = "Mercado";
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series27.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series27.Label = "Soma";
            series27.Legend = "Legend1";
            series27.Name = "SomaOndas";
            series27.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series27.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart64.Series.Add(series26);
            this.chart64.Series.Add(series27);
            this.chart64.Size = new System.Drawing.Size(482, 300);
            this.chart64.TabIndex = 11;
            this.chart64.Text = "chart2";
            // 
            // chart128
            // 
            chartArea16.Name = "ChartArea1";
            this.chart128.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.chart128.Legends.Add(legend16);
            this.chart128.Location = new System.Drawing.Point(522, 441);
            this.chart128.Name = "chart128";
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series28.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series28.Legend = "Legend1";
            series28.Name = "Mercado";
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series29.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series29.Label = "Soma";
            series29.Legend = "Legend1";
            series29.Name = "SomaOndas";
            series29.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series29.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart128.Series.Add(series28);
            this.chart128.Series.Add(series29);
            this.chart128.Size = new System.Drawing.Size(508, 300);
            this.chart128.TabIndex = 12;
            this.chart128.Text = "chart4";
            // 
            // chart16
            // 
            chartArea17.Name = "ChartArea1";
            this.chart16.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.chart16.Legends.Add(legend17);
            this.chart16.Location = new System.Drawing.Point(522, 97);
            this.chart16.Name = "chart16";
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series30.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series30.Legend = "Legend1";
            series30.Name = "Mercado";
            series31.ChartArea = "ChartArea1";
            series31.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series31.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series31.Label = "Soma";
            series31.Legend = "Legend1";
            series31.Name = "SomaOndas";
            series31.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series31.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart16.Series.Add(series30);
            this.chart16.Series.Add(series31);
            this.chart16.Size = new System.Drawing.Size(508, 300);
            this.chart16.TabIndex = 13;
            this.chart16.Text = "chart5";
            // 
            // chart8
            // 
            chartArea18.Name = "ChartArea1";
            this.chart8.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.chart8.Legends.Add(legend18);
            this.chart8.Location = new System.Drawing.Point(12, 97);
            this.chart8.Name = "chart8";
            series32.ChartArea = "ChartArea1";
            series32.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series32.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series32.Legend = "Legend1";
            series32.Name = "Mercado";
            series33.ChartArea = "ChartArea1";
            series33.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series33.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series33.Label = "Soma";
            series33.Legend = "Legend1";
            series33.Name = "SomaOndas";
            series33.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series33.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart8.Series.Add(series32);
            this.chart8.Series.Add(series33);
            this.chart8.Size = new System.Drawing.Size(495, 300);
            this.chart8.TabIndex = 14;
            this.chart8.Text = "chart6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
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

