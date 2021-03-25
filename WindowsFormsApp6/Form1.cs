using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms.DataVisualization.Charting; // https://www.i-programmer.info/programming/uiux/2756-getting-started-with-net-charts.html

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Функція");
            chart1.Series[0].ChartType = SeriesChartType.Line;

            int[] x = { 1, 2, 3 };
            int[] y = { 4, 5, 2 };

            for (int i = 0; i < x.Length; i++)
            {
                DataPoint dp = new DataPoint();
                dp.SetValueXY(x[i], y[i]);
                chart1.Series[0].Points.Add(dp);
            }            
        }

        private void button_count_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
            double x, y;
            double n = Convert.ToDouble(Textbox_n.Text);
            double x1 = Convert.ToDouble(Textbox_X1.Text);
            double x2 = Convert.ToDouble(Textbox_X2.Text);
            double xmax = Convert.ToDouble(Textbox_Xmax.Text);
            double xmin = Convert.ToDouble(textBox_Xmin.Text);
            x = xmin;
            while (xmin <= xmax)
            {
                y = -((Math.Pow(Math.Cos(x1), 3) + 45 + x2) / (Math.Pow(x1, 13) + Math.Cos(x2)));
                this.chart1.Series[0].Points.AddXY(0, y);
                this.chart1.Series[1].Points.AddXY(x,0);
                x += n;
            }
        }
    }
}
