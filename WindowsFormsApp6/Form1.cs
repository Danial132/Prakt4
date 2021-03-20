using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        static double Function(double x)
        {
            return x * x;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
            double x, y;
            double Textboxn1 = Convert.ToDouble(Textboxn.Text);
            double Textbox11 = Convert.ToDouble(Textbox1.Text);
            double Textbox22 = Convert.ToDouble(Textbox2.Text);
            double Textboxmaxx = Convert.ToDouble(Textboxmax.Text);
            double textboxminn = Convert.ToDouble(textBoxmin.Text);
            x = textboxminn;
            while (textboxminn <= Textboxmaxx)
            {
                y = -((Math.Pow(Math.Cos(Textbox11), 3) + 45 + Textbox22) / (Math.Pow(Textbox11, 13) + Math.Cos(Textbox22)));
                this.chart1.Series[0].Points.AddXY(0, y);
                this.chart1.Series[1].Points.AddXY(x,0);
                x += Textboxn1;
            }
        }

        private void xmax_TextChanged(object sender, EventArgs e)
        {

        }

        private void x1_TextChanged(object sender, EventArgs e)
        {

        }

        private void x2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Textboxn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
