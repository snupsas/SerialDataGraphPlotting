﻿namespace PlotGraph
{
    partial class OneSLineGraph
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.slineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.slineChart)).BeginInit();
            this.SuspendLayout();
            // 
            // slineChart
            // 
            chartArea1.Name = "ChartArea1";
            this.slineChart.ChartAreas.Add(chartArea1);
            this.slineChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.slineChart.Legends.Add(legend1);
            this.slineChart.Location = new System.Drawing.Point(0, 0);
            this.slineChart.Name = "slineChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.slineChart.Series.Add(series1);
            this.slineChart.Size = new System.Drawing.Size(739, 406);
            this.slineChart.TabIndex = 0;
            this.slineChart.Text = "chart1";
            // 
            // OneSLineGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.slineChart);
            this.Name = "OneSLineGraph";
            this.Size = new System.Drawing.Size(739, 406);
            ((System.ComponentModel.ISupportInitialize)(this.slineChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart slineChart;
    }
}
