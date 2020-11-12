namespace WindowsFormsAppPersonalProject
{
    partial class frmLoanManagement
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 71);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(776, 367);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnDay
            // 
            this.btnDay.Location = new System.Drawing.Point(12, 12);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(148, 42);
            this.btnDay.TabIndex = 1;
            this.btnDay.Text = "이번 달 많이 빌린 일자";
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(183, 12);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(148, 42);
            this.btnAvg.TabIndex = 2;
            this.btnAvg.Text = "평균 대출액";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // frmLoanManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.btnDay);
            this.Controls.Add(this.chart1);
            this.Name = "frmLoanManagement";
            this.Text = "frmLoanManagement";
            this.Load += new System.EventHandler(this.frmLoanManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnAvg;
    }
}