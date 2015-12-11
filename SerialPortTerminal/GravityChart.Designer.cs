namespace UltraSys
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
            this.GravityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GravityChart)).BeginInit();
            this.SuspendLayout();
            // 
            // GravityChart
            // 
            this.GravityChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GravityChart.BackColor = System.Drawing.Color.SlateGray;
            this.GravityChart.BackImageTransparentColor = System.Drawing.Color.Black;
            this.GravityChart.BackSecondaryColor = System.Drawing.Color.Black;
            this.GravityChart.BorderSkin.PageColor = System.Drawing.Color.Black;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.GravityChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GravityChart.Legends.Add(legend1);
            this.GravityChart.Location = new System.Drawing.Point(1, 12);
            this.GravityChart.Name = "GravityChart";
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
            this.GravityChart.Series.Add(series1);
            this.GravityChart.Series.Add(series2);
            this.GravityChart.Series.Add(series3);
            this.GravityChart.Size = new System.Drawing.Size(937, 305);
            this.GravityChart.TabIndex = 17;
            this.GravityChart.Text = "Gravity";
            this.GravityChart.Click += new System.EventHandler(this.GravityChart_Click);
            // 
            // chartCloseButton
            // 
            this.chartCloseButton.Location = new System.Drawing.Point(821, 251);
            this.chartCloseButton.Name = "chartCloseButton";
            this.chartCloseButton.Size = new System.Drawing.Size(75, 23);
            this.chartCloseButton.TabIndex = 18;
            this.chartCloseButton.Text = "Close Chart";
            this.chartCloseButton.UseVisualStyleBackColor = true;
            this.chartCloseButton.Click += new System.EventHandler(this.chartCloseButton_Click);
            // 
            // GravityChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 329);
            this.ControlBox = false;
            this.Controls.Add(this.chartCloseButton);
            this.Controls.Add(this.GravityChart);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GravityChartForm";
            this.Text = "GravityChart";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GravityChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GravityChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart GravityChart;
        private System.Windows.Forms.Button chartCloseButton;

    }
}