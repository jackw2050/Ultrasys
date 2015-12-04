namespace SerialPortTerminal
{
    partial class GravityChartForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Gravitychart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Gravitychart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gravitychart1
            // 
            this.Gravitychart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gravitychart1.BackColor = System.Drawing.Color.SlateGray;
            this.Gravitychart1.BackImageTransparentColor = System.Drawing.Color.Black;
            this.Gravitychart1.BackSecondaryColor = System.Drawing.Color.Black;
            this.Gravitychart1.BorderSkin.PageColor = System.Drawing.Color.Black;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.Gravitychart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Gravitychart1.Legends.Add(legend1);
            this.Gravitychart1.Location = new System.Drawing.Point(1, 12);
            this.Gravitychart1.Name = "Gravitychart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            this.Gravitychart1.Series.Add(series1);
            this.Gravitychart1.Series.Add(series2);
            this.Gravitychart1.Series.Add(series3);
            this.Gravitychart1.Size = new System.Drawing.Size(677, 203);
            this.Gravitychart1.TabIndex = 17;
            this.Gravitychart1.Text = "chart1";
            this.Gravitychart1.Click += new System.EventHandler(this.Gravitychart1_Click);
            // 
            // GravityChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 227);
            this.Controls.Add(this.Gravitychart1);
            this.Name = "GravityChartForm";
            this.Text = "GravityChart";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GravityChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gravitychart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart Gravitychart1;

    }
}