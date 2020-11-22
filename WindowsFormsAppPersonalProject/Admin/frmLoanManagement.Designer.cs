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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoanManagement));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDelayRate = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.btnLoanPerPeriod = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(14, 182);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(887, 365);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnDelayRate
            // 
            this.btnDelayRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelayRate.Location = new System.Drawing.Point(14, 15);
            this.btnDelayRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelayRate.Name = "btnDelayRate";
            this.btnDelayRate.Size = new System.Drawing.Size(189, 52);
            this.btnDelayRate.TabIndex = 1;
            this.btnDelayRate.Text = "연체율";
            this.btnDelayRate.UseVisualStyleBackColor = true;
            this.btnDelayRate.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAvg.Location = new System.Drawing.Point(218, 15);
            this.btnAvg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(169, 52);
            this.btnAvg.TabIndex = 2;
            this.btnAvg.Text = "평균 대출액";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // btnLoanPerPeriod
            // 
            this.btnLoanPerPeriod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoanPerPeriod.Location = new System.Drawing.Point(13, 2);
            this.btnLoanPerPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoanPerPeriod.Name = "btnLoanPerPeriod";
            this.btnLoanPerPeriod.Size = new System.Drawing.Size(189, 52);
            this.btnLoanPerPeriod.TabIndex = 3;
            this.btnLoanPerPeriod.Text = "기간별 대출 건수";
            this.btnLoanPerPeriod.UseVisualStyleBackColor = true;
            this.btnLoanPerPeriod.Click += new System.EventHandler(this.btnMonthlyLoan_Click);
            // 
            // dtp
            // 
            this.dtp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp.CustomFormat = "";
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(13, 98);
            this.dtp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(188, 25);
            this.dtp.TabIndex = 4;
            this.dtp.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtp2
            // 
            this.dtp2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp2.CustomFormat = "";
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(265, 98);
            this.dtp2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(228, 25);
            this.dtp2.TabIndex = 5;
            this.dtp2.ValueChanged += new System.EventHandler(this.dtp2_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "~";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLoanPerPeriod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtp);
            this.panel1.Controls.Add(this.dtp2);
            this.panel1.Location = new System.Drawing.Point(394, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 160);
            this.panel1.TabIndex = 7;
            // 
            // frmLoanManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.btnDelayRate);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLoanManagement";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "대출관리";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLoanManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnDelayRate;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.Button btnLoanPerPeriod;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}