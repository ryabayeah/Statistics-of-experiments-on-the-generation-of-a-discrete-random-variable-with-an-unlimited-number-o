
namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RelA = new System.Windows.Forms.Label();
            this.RelC = new System.Windows.Forms.Label();
            this.RelV = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Trials = new System.Windows.Forms.NumericUpDown();
            this.StartB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Num1 = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Trials);
            this.panel1.Controls.Add(this.StartB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Num1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 329);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.RelA);
            this.panel2.Controls.Add(this.RelC);
            this.panel2.Controls.Add(this.RelV);
            this.panel2.Location = new System.Drawing.Point(13, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 100);
            this.panel2.TabIndex = 15;
            // 
            // RelA
            // 
            this.RelA.AutoSize = true;
            this.RelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RelA.Location = new System.Drawing.Point(10, 13);
            this.RelA.Name = "RelA";
            this.RelA.Size = new System.Drawing.Size(0, 13);
            this.RelA.TabIndex = 12;
            // 
            // RelC
            // 
            this.RelC.AutoSize = true;
            this.RelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RelC.Location = new System.Drawing.Point(10, 75);
            this.RelC.Name = "RelC";
            this.RelC.Size = new System.Drawing.Size(0, 13);
            this.RelC.TabIndex = 14;
            // 
            // RelV
            // 
            this.RelV.AutoSize = true;
            this.RelV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RelV.Location = new System.Drawing.Point(10, 44);
            this.RelV.Name = "RelV";
            this.RelV.Size = new System.Drawing.Size(0, 13);
            this.RelV.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(21, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number of\r\nexperiments";
            // 
            // Trials
            // 
            this.Trials.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Trials.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Trials.Location = new System.Drawing.Point(160, 83);
            this.Trials.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Trials.Name = "Trials";
            this.Trials.ReadOnly = true;
            this.Trials.Size = new System.Drawing.Size(102, 23);
            this.Trials.TabIndex = 10;
            this.Trials.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // StartB
            // 
            this.StartB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.StartB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.StartB.Location = new System.Drawing.Point(93, 150);
            this.StartB.Name = "StartB";
            this.StartB.Size = new System.Drawing.Size(99, 31);
            this.StartB.TabIndex = 1;
            this.StartB.Text = "Start";
            this.StartB.UseVisualStyleBackColor = false;
            this.StartB.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prob 0";
            // 
            // Num1
            // 
            this.Num1.DecimalPlaces = 2;
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Num1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Num1.Location = new System.Drawing.Point(160, 23);
            this.Num1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(102, 23);
            this.Num1.TabIndex = 0;
            this.Num1.Value = new decimal(new int[] {
            60,
            0,
            0,
            131072});
            // 
            // chart1
            // 
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.LightBlue;
            chartArea1.Name = "Freq.";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(317, 23);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "Freq.";
            series1.IsValueShownAsLabel = true;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(457, 306);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Freq.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 356);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.Text = "Hello";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Trials;
        private System.Windows.Forms.Button StartB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Num1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label RelA;
        private System.Windows.Forms.Label RelV;
        private System.Windows.Forms.Label RelC;
        private System.Windows.Forms.Panel panel2;
    }
}

