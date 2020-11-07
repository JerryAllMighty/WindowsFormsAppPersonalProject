namespace WindowsFormsAppPersonalProject.Sending
{
    partial class frmSending2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblInputAcc = new System.Windows.Forms.Label();
            this.lblAmountOfSending = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "이체 정보 최종 확인";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAmountOfSending, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblInputAcc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(50, 90);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 177);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblInputAcc
            // 
            this.lblInputAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInputAcc.Location = new System.Drawing.Point(43, 113);
            this.lblInputAcc.Name = "lblInputAcc";
            this.lblInputAcc.Size = new System.Drawing.Size(74, 39);
            this.lblInputAcc.TabIndex = 21;
            this.lblInputAcc.Text = "입금 계좌";
            this.lblInputAcc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAmountOfSending
            // 
            this.lblAmountOfSending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmountOfSending.Location = new System.Drawing.Point(43, 24);
            this.lblAmountOfSending.Name = "lblAmountOfSending";
            this.lblAmountOfSending.Size = new System.Drawing.Size(74, 39);
            this.lblAmountOfSending.TabIndex = 20;
            this.lblAmountOfSending.Text = "이체 금액";
            this.lblAmountOfSending.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(365, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 39);
            this.label1.TabIndex = 25;
            this.label1.Text = "출금 계좌";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(365, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 39);
            this.label2.TabIndex = 26;
            this.label2.Text = "입금주";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "최종 이체";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmSending2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSending2";
            this.Text = "frmSending2";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAmountOfSending;
        private System.Windows.Forms.Label lblInputAcc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}