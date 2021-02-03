using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;


namespace CodeWars.tests
{
    public static class TimeExecution
    {
        /*
         * Calculate Big O notation
         * 
         * int: number of elements
         * long: time spent
         */
        public static void ExecutionTimes(Dictionary<int, long> times)
        {

            int[] yVals = times.Keys.ToArray();
            long[] xVals = times.Values.ToArray();

            // http://timbar.blogspot.com/2012/04/creating-chart-programmatically-in-c.html

            Chart chart = new Chart();
            chart.Size = new Size(800, 600);

            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chartArea.AxisY.LabelStyle.Font = new Font("Consolas", 8);
            chartArea.AxisX.Title = "Time in ms";
            chartArea.AxisY.Title = "Size of array";

            chart.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.Name = "Time to perform";
            series.ChartType = SeriesChartType.FastLine;
            series.XValueType = ChartValueType.Auto;
            chart.Series.Add(series);

            chart.Series["Time to perform"].Points.DataBindXY(xVals, yVals);

            chart.DataManipulator.CopySeriesValues("Time to perform", "Series2");
            chart.DataManipulator.FinancialFormula(
                FinancialFormula.WeightedMovingAverage,
                "Series2"
            );
            chart.Series["Series2"].ChartType = SeriesChartType.FastLine;

            chart.Invalidate();

            chart.SaveImage("chart.png", ChartImageFormat.Png);
        }
    }
}