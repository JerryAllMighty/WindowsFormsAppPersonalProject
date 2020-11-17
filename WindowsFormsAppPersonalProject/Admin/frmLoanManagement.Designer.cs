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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDelayRate = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.btnLoanPerPeriod = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 146);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(776, 292);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnDelayRate
            // 
            this.btnDelayRate.Location = new System.Drawing.Point(12, 12);
            this.btnDelayRate.Name = "btnDelayRate";
            this.btnDelayRate.Size = new System.Drawing.Size(165, 42);
            this.btnDelayRate.TabIndex = 1;
            this.btnDelayRate.Text = "연체율";
            this.btnDelayRate.UseVisualStyleBackColor = true;
            this.btnDelayRate.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(191, 12);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(148, 42);
            this.btnAvg.TabIndex = 2;
            this.btnAvg.Text = "평균 대출액";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // btnLoanPerPeriod
            // 
            this.btnLoanPerPeriod.Location = new System.Drawing.Point(12, 60);
            this.btnLoanPerPeriod.Name = "btnLoanPerPeriod";
            this.btnLoanPerPeriod.Size = new System.Drawing.Size(165, 42);
            this.btnLoanPerPeriod.TabIndex = 3;
            this.btnLoanPerPeriod.Text = "기간별 대출 건수";
            this.btnLoanPerPeriod.UseVisualStyleBackColor = true;
            this.btnLoanPerPeriod.Click += new System.EventHandler(this.btnMonthlyLoan_Click);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(353, 81);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(165, 21);
            this.dtp.TabIndex = 4;
            this.dtp.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(574, 81);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 21);
            this.dtp2.TabIndex = 5;
            this.dtp2.ValueChanged += new System.EventHandler(this.dtp2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "~";
            // 
            // frmLoanManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btnLoanPerPeriod);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.btnDelayRate);
            this.Controls.Add(this.chart1);
            this.Name = "frmLoanManagement";
            this.Text = "frmLoanManagement";
            this.Load += new System.EventHandler(this.frmLoanManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnDelayRate;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.Button btnLoanPerPeriod;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label label1;
    }
}