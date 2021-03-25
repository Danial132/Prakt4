
namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_count = new System.Windows.Forms.Button();
            this.Textbox_X1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Textbox_X2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Textbox_n = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Textbox_Xmax = new System.Windows.Forms.TextBox();
            this.textBox_Xmin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.ForeColor = System.Drawing.Color.Maroon;
            legend2.HeaderSeparatorColor = System.Drawing.Color.Maroon;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.BlanchedAlmond;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(402, 12);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Black;
            series2.LabelBorderWidth = 3;
            series2.Legend = "Legend1";
            series2.MarkerBorderWidth = 3;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(375, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // button_count
            // 
            this.button_count.Location = new System.Drawing.Point(75, 385);
            this.button_count.Name = "button_count";
            this.button_count.Size = new System.Drawing.Size(75, 23);
            this.button_count.TabIndex = 2;
            this.button_count.Text = "Count";
            this.button_count.UseVisualStyleBackColor = true;
            this.button_count.Click += new System.EventHandler(this.button_count_Click);
            // 
            // Textbox_X1
            // 
            this.Textbox_X1.Location = new System.Drawing.Point(27, 98);
            this.Textbox_X1.Name = "Textbox_X1";
            this.Textbox_X1.Size = new System.Drawing.Size(100, 20);
            this.Textbox_X1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "x2";
            // 
            // Textbox_X2
            // 
            this.Textbox_X2.Location = new System.Drawing.Point(27, 170);
            this.Textbox_X2.Name = "Textbox_X2";
            this.Textbox_X2.Size = new System.Drawing.Size(100, 20);
            this.Textbox_X2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "n";
            // 
            // Textbox_n
            // 
            this.Textbox_n.Location = new System.Drawing.Point(27, 245);
            this.Textbox_n.Name = "Textbox_n";
            this.Textbox_n.Size = new System.Drawing.Size(100, 20);
            this.Textbox_n.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "x.max";
            // 
            // Textbox_Xmax
            // 
            this.Textbox_Xmax.Location = new System.Drawing.Point(216, 97);
            this.Textbox_Xmax.Name = "Textbox_Xmax";
            this.Textbox_Xmax.Size = new System.Drawing.Size(100, 20);
            this.Textbox_Xmax.TabIndex = 10;
            // 
            // textBox_Xmin
            // 
            this.textBox_Xmin.Location = new System.Drawing.Point(216, 170);
            this.textBox_Xmin.Name = "textBox_Xmin";
            this.textBox_Xmin.Size = new System.Drawing.Size(100, 20);
            this.textBox_Xmin.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "x.min";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Xmin);
            this.Controls.Add(this.Textbox_Xmax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Textbox_n);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Textbox_X2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Textbox_X1);
            this.Controls.Add(this.button_count);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_count;
        private System.Windows.Forms.TextBox Textbox_X1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Textbox_X2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Textbox_n;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Textbox_Xmax;
        private System.Windows.Forms.TextBox textBox_Xmin;
        private System.Windows.Forms.Label label5;
    }
}

