using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ToolsLib;

namespace PlotGraph
{
    public partial class OneSLineGraph : UserControl
    {
        private CircuralBuffer<PointF> _buffer = new CircuralBuffer<PointF>();
        public OneSLineGraph()
        {
            InitializeComponent();
            SetupGraph();
        }

        public void AddPoint(PointF point)
        {
            _buffer.Add(point);
        }

        public double LastXValue
        {
            get
            {
                var points = this.slineChart.Series.First().Points;
                return points.Count > 0 ? points.Last().XValue : 0;
            }
        }

        private void SetupGraph()
        {
            this.slineChart.Series.Clear();

            var series1 = new Series
            {
                Name = "Temp",
                Color = Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline
            };

            _buffer.AddedNewItem += NewBufferItemAddedHandler;
            this.slineChart.Series.Add(series1);
            this.slineChart.Invalidate();
        }

        private void NewBufferItemAddedHandler(object sender, EventArgs args)
        {
            var graphSeries = this.slineChart.Series.First();

            if (this.slineChart.InvokeRequired)
            {
                this.Invoke(new Action(() => { NewBufferItemAddedHandler(sender, args); }), null);
            }
            else
            {
                graphSeries.Points.Clear();
                foreach (var bufferItem in _buffer)
                {
                    graphSeries.Points.AddXY(bufferItem.X, bufferItem.Y);
                }
                this.slineChart.Invalidate();
            }
        }
    }
}
