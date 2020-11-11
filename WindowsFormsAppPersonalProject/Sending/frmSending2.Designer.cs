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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSending2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblOutAcc = new System.Windows.Forms.Label();
            this.lblAmountOfSending = new System.Windows.Forms.Label();
            this.lblInputAcc = new System.Windows.Forms.Label();
            this.lblReceiverName = new System.Windows.Forms.Label();
            this.lblAmountOfSending2 = new System.Windows.Forms.Label();
            this.lblInputAcc2 = new System.Windows.Forms.Label();
            this.lblOutAcc2 = new System.Windows.Forms.Label();
            this.lblReceiverName2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(679, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "이체 정보 최종 확인";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(530, 287);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(144, 49);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "최종 이체";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblReceiverName2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblOutAcc2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblInputAcc2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblOutAcc, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAmountOfSending, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblInputAcc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblReceiverName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAmountOfSending2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(44, 72);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 142);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblOutAcc
            // 
            this.lblOutAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutAcc.Location = new System.Drawing.Point(320, 20);
            this.lblOutAcc.Name = "lblOutAcc";
            this.lblOutAcc.Size = new System.Drawing.Size(65, 31);
            this.lblOutAcc.TabIndex = 25;
            this.lblOutAcc.Text = "출금 계좌";
            this.lblOutAcc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAmountOfSending
            // 
            this.lblAmountOfSending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmountOfSending.Location = new System.Drawing.Point(38, 20);
            this.lblAmountOfSending.Name = "lblAmountOfSending";
            this.lblAmountOfSending.Size = new System.Drawing.Size(65, 31);
            this.lblAmountOfSending.TabIndex = 20;
            this.lblAmountOfSending.Text = "이체 금액";
            this.lblAmountOfSending.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInputAcc
            // 
            this.lblInputAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInputAcc.Location = new System.Drawing.Point(38, 91);
            this.lblInputAcc.Name = "lblInputAcc";
            this.lblInputAcc.Size = new System.Drawing.Size(65, 31);
            this.lblInputAcc.TabIndex = 21;
            this.lblInputAcc.Text = "입금 계좌";
            this.lblInputAcc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblReceiverName
            // 
            this.lblReceiverName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReceiverName.Location = new System.Drawing.Point(320, 91);
            this.lblReceiverName.Name = "lblReceiverName";
            this.lblReceiverName.Size = new System.Drawing.Size(65, 31);
            this.lblReceiverName.TabIndex = 26;
            this.lblReceiverName.Text = "입금주";
            this.lblReceiverName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAmountOfSending2
            // 
            this.lblAmountOfSending2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmountOfSending2.Location = new System.Drawing.Point(179, 20);
            this.lblAmountOfSending2.Name = "lblAmountOfSending2";
            this.lblAmountOfSending2.Size = new System.Drawing.Size(65, 31);
            this.lblAmountOfSending2.TabIndex = 27;
            this.lblAmountOfSending2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInputAcc2
            // 
            this.lblInputAcc2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInputAcc2.Location = new System.Drawing.Point(179, 91);
            this.lblInputAcc2.Name = "lblInputAcc2";
            this.lblInputAcc2.Size = new System.Drawing.Size(65, 31);
            this.lblInputAcc2.TabIndex = 28;
            this.lblInputAcc2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOutAcc2
            // 
            this.lblOutAcc2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutAcc2.Location = new System.Drawing.Point(461, 20);
            this.lblOutAcc2.Name = "lblOutAcc2";
            this.lblOutAcc2.Size = new System.Drawing.Size(65, 31);
            this.lblOutAcc2.TabIndex = 28;
            this.lblOutAcc2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblReceiverName2
            // 
            this.lblReceiverName2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReceiverName2.Location = new System.Drawing.Point(461, 91);
            this.lblReceiverName2.Name = "lblReceiverName2";
            this.lblReceiverName2.Size = new System.Drawing.Size(65, 31);
            this.lblReceiverName2.TabIndex = 28;
            this.lblReceiverName2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmSending2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSending2";
            this.Text = "frmSending2";
            this.Load += new System.EventHandler(this.frmSending2_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblOutAcc;
        private System.Windows.Forms.Label lblAmountOfSending;
        private System.Windows.Forms.Label lblInputAcc;
        private System.Windows.Forms.Label lblReceiverName;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblReceiverName2;
        private System.Windows.Forms.Label lblOutAcc2;
        private System.Windows.Forms.Label lblInputAcc2;
        private System.Windows.Forms.Label lblAmountOfSending2;
    }
}