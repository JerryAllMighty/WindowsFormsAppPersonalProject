namespace WindowsFormsAppPersonalProject
{
    partial class frmLoanPayBack2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoanPayBack2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtLoanWillBeLeftOver = new System.Windows.Forms.TextBox();
            this.txtOutAcc = new System.Windows.Forms.TextBox();
            this.txtAmountOfPayBack = new System.Windows.Forms.TextBox();
            this.txtLoanNum = new System.Windows.Forms.TextBox();
            this.lblLoanLeftOver = new System.Windows.Forms.Label();
            this.lblOutAcc = new System.Windows.Forms.Label();
            this.lblAmountOfPayBack = new System.Windows.Forms.Label();
            this.lblLoanNum = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 547);
            this.panel1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.txtLoanWillBeLeftOver);
            this.groupBox1.Controls.Add(this.txtOutAcc);
            this.groupBox1.Controls.Add(this.txtAmountOfPayBack);
            this.groupBox1.Controls.Add(this.txtLoanNum);
            this.groupBox1.Controls.Add(this.lblLoanLeftOver);
            this.groupBox1.Controls.Add(this.lblOutAcc);
            this.groupBox1.Controls.Add(this.lblAmountOfPayBack);
            this.groupBox1.Controls.Add(this.lblLoanNum);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 547);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상환 정보 최종 확인";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(616, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 57);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.Location = new System.Drawing.Point(397, 430);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(162, 57);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "최종 대출 상환";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtLoanWillBeLeftOver
            // 
            this.txtLoanWillBeLeftOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoanWillBeLeftOver.Location = new System.Drawing.Point(601, 275);
            this.txtLoanWillBeLeftOver.Name = "txtLoanWillBeLeftOver";
            this.txtLoanWillBeLeftOver.Size = new System.Drawing.Size(154, 30);
            this.txtLoanWillBeLeftOver.TabIndex = 3;
            this.txtLoanWillBeLeftOver.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOutAcc
            // 
            this.txtOutAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutAcc.Location = new System.Drawing.Point(157, 275);
            this.txtOutAcc.Name = "txtOutAcc";
            this.txtOutAcc.Size = new System.Drawing.Size(152, 30);
            this.txtOutAcc.TabIndex = 2;
            this.txtOutAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAmountOfPayBack
            // 
            this.txtAmountOfPayBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmountOfPayBack.Location = new System.Drawing.Point(601, 122);
            this.txtAmountOfPayBack.Name = "txtAmountOfPayBack";
            this.txtAmountOfPayBack.Size = new System.Drawing.Size(154, 30);
            this.txtAmountOfPayBack.TabIndex = 1;
            this.txtAmountOfPayBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLoanNum
            // 
            this.txtLoanNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoanNum.Location = new System.Drawing.Point(157, 122);
            this.txtLoanNum.Name = "txtLoanNum";
            this.txtLoanNum.Size = new System.Drawing.Size(152, 30);
            this.txtLoanNum.TabIndex = 0;
            this.txtLoanNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLoanLeftOver
            // 
            this.lblLoanLeftOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoanLeftOver.AutoSize = true;
            this.lblLoanLeftOver.Location = new System.Drawing.Point(393, 275);
            this.lblLoanLeftOver.Name = "lblLoanLeftOver";
            this.lblLoanLeftOver.Size = new System.Drawing.Size(180, 20);
            this.lblLoanLeftOver.TabIndex = 31;
            this.lblLoanLeftOver.Text = "상환 후 남을 금액";
            this.lblLoanLeftOver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutAcc
            // 
            this.lblOutAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutAcc.AutoSize = true;
            this.lblOutAcc.Location = new System.Drawing.Point(12, 275);
            this.lblOutAcc.Name = "lblOutAcc";
            this.lblOutAcc.Size = new System.Drawing.Size(135, 20);
            this.lblOutAcc.TabIndex = 30;
            this.lblOutAcc.Text = "출금계좌번호";
            this.lblOutAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAmountOfPayBack
            // 
            this.lblAmountOfPayBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmountOfPayBack.AutoSize = true;
            this.lblAmountOfPayBack.Location = new System.Drawing.Point(393, 122);
            this.lblAmountOfPayBack.Name = "lblAmountOfPayBack";
            this.lblAmountOfPayBack.Size = new System.Drawing.Size(93, 20);
            this.lblAmountOfPayBack.TabIndex = 29;
            this.lblAmountOfPayBack.Text = "상환금액";
            this.lblAmountOfPayBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoanNum
            // 
            this.lblLoanNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoanNum.AutoSize = true;
            this.lblLoanNum.Location = new System.Drawing.Point(12, 122);
            this.lblLoanNum.Name = "lblLoanNum";
            this.lblLoanNum.Size = new System.Drawing.Size(93, 20);
            this.lblLoanNum.TabIndex = 28;
            this.lblLoanNum.Text = "대출번호";
            this.lblLoanNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 24);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(197, 56);
            this.trackBar1.TabIndex = 27;
            this.trackBar1.TabStop = false;
            this.trackBar1.TickFrequency = 3;
            // 
            // frmLoanPayBack2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 547);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoanPayBack2";
            this.Text = "대출상환";
            this.Load += new System.EventHandler(this.frmLoanPayBack2_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtLoanWillBeLeftOver;
        private System.Windows.Forms.TextBox txtOutAcc;
        private System.Windows.Forms.TextBox txtAmountOfPayBack;
        private System.Windows.Forms.TextBox txtLoanNum;
        private System.Windows.Forms.Label lblLoanLeftOver;
        private System.Windows.Forms.Label lblOutAcc;
        private System.Windows.Forms.Label lblAmountOfPayBack;
        private System.Windows.Forms.Label lblLoanNum;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnCancel;
    }
}