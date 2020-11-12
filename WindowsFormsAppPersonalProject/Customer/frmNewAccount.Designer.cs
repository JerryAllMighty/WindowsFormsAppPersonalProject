namespace WindowsFormsAppPersonalProject
{
    partial class frmNewAccount
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAmountOfDeposit = new System.Windows.Forms.Label();
            this.txtAmountOfDeposit = new System.Windows.Forms.TextBox();
            this.gbxNewAccount = new System.Windows.Forms.GroupBox();
            this.lblCheckNewPwd = new System.Windows.Forms.Label();
            this.txtCheckNewPwd = new System.Windows.Forms.TextBox();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.cbxduration = new System.Windows.Forms.ComboBox();
            this.cbxKindOfAccount = new System.Windows.Forms.ComboBox();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.lblpayPerMonth = new System.Windows.Forms.Label();
            this.txtpayPerMonth = new System.Windows.Forms.TextBox();
            this.lblduration = new System.Windows.Forms.Label();
            this.lblOutAccount = new System.Windows.Forms.Label();
            this.txtOutAccount = new System.Windows.Forms.TextBox();
            this.lblOutPwd = new System.Windows.Forms.Label();
            this.txtOutPwd = new System.Windows.Forms.TextBox();
            this.lbltxtKindOfAccount = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.gbxNewAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAmountOfDeposit);
            this.panel1.Controls.Add(this.txtAmountOfDeposit);
            this.panel1.Controls.Add(this.gbxNewAccount);
            this.panel1.Controls.Add(this.cbxduration);
            this.panel1.Controls.Add(this.cbxKindOfAccount);
            this.panel1.Controls.Add(this.btnNewAccount);
            this.panel1.Controls.Add(this.lblpayPerMonth);
            this.panel1.Controls.Add(this.txtpayPerMonth);
            this.panel1.Controls.Add(this.lblduration);
            this.panel1.Controls.Add(this.lblOutAccount);
            this.panel1.Controls.Add(this.txtOutAccount);
            this.panel1.Controls.Add(this.lblOutPwd);
            this.panel1.Controls.Add(this.txtOutPwd);
            this.panel1.Controls.Add(this.lbltxtKindOfAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 427);
            this.panel1.TabIndex = 1;
            // 
            // lblAmountOfDeposit
            // 
            this.lblAmountOfDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmountOfDeposit.Location = new System.Drawing.Point(452, 234);
            this.lblAmountOfDeposit.Name = "lblAmountOfDeposit";
            this.lblAmountOfDeposit.Size = new System.Drawing.Size(100, 23);
            this.lblAmountOfDeposit.TabIndex = 15;
            this.lblAmountOfDeposit.Text = "예치금";
            this.lblAmountOfDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAmountOfDeposit
            // 
            this.txtAmountOfDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmountOfDeposit.Location = new System.Drawing.Point(597, 231);
            this.txtAmountOfDeposit.Name = "txtAmountOfDeposit";
            this.txtAmountOfDeposit.Size = new System.Drawing.Size(223, 21);
            this.txtAmountOfDeposit.TabIndex = 7;
            // 
            // gbxNewAccount
            // 
            this.gbxNewAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxNewAccount.Controls.Add(this.lblCheckNewPwd);
            this.gbxNewAccount.Controls.Add(this.txtCheckNewPwd);
            this.gbxNewAccount.Controls.Add(this.lblNewPwd);
            this.gbxNewAccount.Controls.Add(this.txtNewPwd);
            this.gbxNewAccount.Location = new System.Drawing.Point(450, 41);
            this.gbxNewAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxNewAccount.Name = "gbxNewAccount";
            this.gbxNewAccount.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxNewAccount.Size = new System.Drawing.Size(471, 160);
            this.gbxNewAccount.TabIndex = 5;
            this.gbxNewAccount.TabStop = false;
            this.gbxNewAccount.Text = "신규 계좌 비밀번호 생성";
            // 
            // lblCheckNewPwd
            // 
            this.lblCheckNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckNewPwd.Location = new System.Drawing.Point(3, 139);
            this.lblCheckNewPwd.Name = "lblCheckNewPwd";
            this.lblCheckNewPwd.Size = new System.Drawing.Size(100, 23);
            this.lblCheckNewPwd.TabIndex = 7;
            this.lblCheckNewPwd.Text = "비밀번호 확인";
            // 
            // txtCheckNewPwd
            // 
            this.txtCheckNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCheckNewPwd.Location = new System.Drawing.Point(147, 137);
            this.txtCheckNewPwd.Name = "txtCheckNewPwd";
            this.txtCheckNewPwd.Size = new System.Drawing.Size(223, 21);
            this.txtCheckNewPwd.TabIndex = 6;
            this.txtCheckNewPwd.TextChanged += new System.EventHandler(this.txtCheckNewPwd_TextChanged);
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewPwd.Location = new System.Drawing.Point(3, 62);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(100, 23);
            this.lblNewPwd.TabIndex = 5;
            this.lblNewPwd.Text = "비밀번호";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPwd.Location = new System.Drawing.Point(147, 60);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(223, 21);
            this.txtNewPwd.TabIndex = 5;
            this.txtNewPwd.TextChanged += new System.EventHandler(this.txtNewPwd_TextChanged);
            // 
            // cbxduration
            // 
            this.cbxduration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxduration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxduration.FormattingEnabled = true;
            this.cbxduration.Items.AddRange(new object[] {
            "1개월",
            "3개월",
            "6개월",
            "12개월",
            "24개월"});
            this.cbxduration.Location = new System.Drawing.Point(172, 108);
            this.cbxduration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxduration.Name = "cbxduration";
            this.cbxduration.Size = new System.Drawing.Size(223, 20);
            this.cbxduration.TabIndex = 1;
            // 
            // cbxKindOfAccount
            // 
            this.cbxKindOfAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxKindOfAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKindOfAccount.FormattingEnabled = true;
            this.cbxKindOfAccount.Items.AddRange(new object[] {
            "적금 계좌",
            "예금 계좌",
            "일반 계좌"});
            this.cbxKindOfAccount.Location = new System.Drawing.Point(172, 41);
            this.cbxKindOfAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxKindOfAccount.Name = "cbxKindOfAccount";
            this.cbxKindOfAccount.Size = new System.Drawing.Size(223, 20);
            this.cbxKindOfAccount.TabIndex = 0;
            this.cbxKindOfAccount.SelectedValueChanged += new System.EventHandler(this.cbxKindOfAccount_SelectedValueChanged);
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewAccount.Location = new System.Drawing.Point(795, 262);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(125, 64);
            this.btnNewAccount.TabIndex = 8;
            this.btnNewAccount.Text = "계좌 생성";
            this.btnNewAccount.UseVisualStyleBackColor = true;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // lblpayPerMonth
            // 
            this.lblpayPerMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblpayPerMonth.Location = new System.Drawing.Point(28, 175);
            this.lblpayPerMonth.Name = "lblpayPerMonth";
            this.lblpayPerMonth.Size = new System.Drawing.Size(100, 23);
            this.lblpayPerMonth.TabIndex = 9;
            this.lblpayPerMonth.Text = "매회 납입 금액 ";
            this.lblpayPerMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpayPerMonth
            // 
            this.txtpayPerMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpayPerMonth.Location = new System.Drawing.Point(172, 172);
            this.txtpayPerMonth.Name = "txtpayPerMonth";
            this.txtpayPerMonth.Size = new System.Drawing.Size(223, 21);
            this.txtpayPerMonth.TabIndex = 2;
            this.txtpayPerMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblduration
            // 
            this.lblduration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblduration.Location = new System.Drawing.Point(28, 108);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(100, 23);
            this.lblduration.TabIndex = 0;
            this.lblduration.Text = "가입기간";
            this.lblduration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutAccount
            // 
            this.lblOutAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutAccount.Location = new System.Drawing.Point(28, 234);
            this.lblOutAccount.Name = "lblOutAccount";
            this.lblOutAccount.Size = new System.Drawing.Size(100, 23);
            this.lblOutAccount.TabIndex = 5;
            this.lblOutAccount.Text = "출금계좌";
            this.lblOutAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOutAccount
            // 
            this.txtOutAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutAccount.Location = new System.Drawing.Point(172, 231);
            this.txtOutAccount.Name = "txtOutAccount";
            this.txtOutAccount.Size = new System.Drawing.Size(223, 21);
            this.txtOutAccount.TabIndex = 3;
            this.txtOutAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOutPwd
            // 
            this.lblOutPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutPwd.Location = new System.Drawing.Point(28, 309);
            this.lblOutPwd.Name = "lblOutPwd";
            this.lblOutPwd.Size = new System.Drawing.Size(139, 23);
            this.lblOutPwd.TabIndex = 3;
            this.lblOutPwd.Text = "출금 계좌 비밀번호";
            this.lblOutPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOutPwd
            // 
            this.txtOutPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutPwd.Location = new System.Drawing.Point(172, 306);
            this.txtOutPwd.Name = "txtOutPwd";
            this.txtOutPwd.Size = new System.Drawing.Size(223, 21);
            this.txtOutPwd.TabIndex = 4;
            this.txtOutPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbltxtKindOfAccount
            // 
            this.lbltxtKindOfAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltxtKindOfAccount.Location = new System.Drawing.Point(28, 41);
            this.lbltxtKindOfAccount.Name = "lbltxtKindOfAccount";
            this.lbltxtKindOfAccount.Size = new System.Drawing.Size(100, 23);
            this.lbltxtKindOfAccount.TabIndex = 1;
            this.lbltxtKindOfAccount.Text = "계좌종류";
            this.lbltxtKindOfAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 427);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNewAccount";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "새 계좌 생성";
            this.Load += new System.EventHandler(this.NewAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxNewAccount.ResumeLayout(false);
            this.gbxNewAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.Label lblpayPerMonth;
        private System.Windows.Forms.TextBox txtpayPerMonth;
        private System.Windows.Forms.Label lblduration;
        private System.Windows.Forms.Label lblOutAccount;
        private System.Windows.Forms.TextBox txtOutAccount;
        private System.Windows.Forms.Label lblOutPwd;
        private System.Windows.Forms.TextBox txtOutPwd;
        private System.Windows.Forms.Label lbltxtKindOfAccount;
        private System.Windows.Forms.ComboBox cbxduration;
        private System.Windows.Forms.ComboBox cbxKindOfAccount;
        private System.Windows.Forms.GroupBox gbxNewAccount;
        private System.Windows.Forms.Label lblCheckNewPwd;
        private System.Windows.Forms.TextBox txtCheckNewPwd;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblAmountOfDeposit;
        private System.Windows.Forms.TextBox txtAmountOfDeposit;
    }
}