namespace WindowsFormsAppPersonalProject
{
    partial class frmSavingExtension
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSavingExtension));
            this.lblCurrentMoney = new System.Windows.Forms.Label();
            this.txtCurrentMoney = new System.Windows.Forms.TextBox();
            this.gbxNewAccount = new System.Windows.Forms.GroupBox();
            this.lblCheckNewPwd = new System.Windows.Forms.Label();
            this.txtCheckNewPwd = new System.Windows.Forms.TextBox();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.cbxduration = new System.Windows.Forms.ComboBox();
            this.btnSavingsExtension = new System.Windows.Forms.Button();
            this.lblduration = new System.Windows.Forms.Label();
            this.lblOutAccount = new System.Windows.Forms.Label();
            this.txtOutAccount = new System.Windows.Forms.TextBox();
            this.lblOutPwd = new System.Windows.Forms.Label();
            this.txtOutPwd = new System.Windows.Forms.TextBox();
            this.dgvMemver = new System.Windows.Forms.DataGridView();
            this.lblpayPerMonth = new System.Windows.Forms.Label();
            this.txtpayPerMonth = new System.Windows.Forms.TextBox();
            this.checkControl11 = new WindowsFormsAppPersonalProject.CheckControl1();
            this.gbxNewAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemver)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentMoney
            // 
            this.lblCurrentMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentMoney.Location = new System.Drawing.Point(10, 286);
            this.lblCurrentMoney.Name = "lblCurrentMoney";
            this.lblCurrentMoney.Size = new System.Drawing.Size(100, 23);
            this.lblCurrentMoney.TabIndex = 42;
            this.lblCurrentMoney.Text = "현재 적금 금액";
            this.lblCurrentMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCurrentMoney
            // 
            this.txtCurrentMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurrentMoney.Location = new System.Drawing.Point(155, 283);
            this.txtCurrentMoney.Name = "txtCurrentMoney";
            this.txtCurrentMoney.ReadOnly = true;
            this.txtCurrentMoney.Size = new System.Drawing.Size(223, 21);
            this.txtCurrentMoney.TabIndex = 40;
            // 
            // gbxNewAccount
            // 
            this.gbxNewAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxNewAccount.Controls.Add(this.lblCheckNewPwd);
            this.gbxNewAccount.Controls.Add(this.txtCheckNewPwd);
            this.gbxNewAccount.Controls.Add(this.lblNewPwd);
            this.gbxNewAccount.Controls.Add(this.txtNewPwd);
            this.gbxNewAccount.Location = new System.Drawing.Point(436, 237);
            this.gbxNewAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxNewAccount.Name = "gbxNewAccount";
            this.gbxNewAccount.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxNewAccount.Size = new System.Drawing.Size(471, 98);
            this.gbxNewAccount.TabIndex = 38;
            this.gbxNewAccount.TabStop = false;
            this.gbxNewAccount.Text = "적금 계좌 비밀번호 변경";
            // 
            // lblCheckNewPwd
            // 
            this.lblCheckNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckNewPwd.Location = new System.Drawing.Point(3, 58);
            this.lblCheckNewPwd.Name = "lblCheckNewPwd";
            this.lblCheckNewPwd.Size = new System.Drawing.Size(100, 23);
            this.lblCheckNewPwd.TabIndex = 7;
            this.lblCheckNewPwd.Text = "비밀번호 확인";
            // 
            // txtCheckNewPwd
            // 
            this.txtCheckNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCheckNewPwd.Location = new System.Drawing.Point(147, 55);
            this.txtCheckNewPwd.Name = "txtCheckNewPwd";
            this.txtCheckNewPwd.Size = new System.Drawing.Size(223, 21);
            this.txtCheckNewPwd.TabIndex = 6;
            this.txtCheckNewPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheckNewPwd_KeyPress);
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewPwd.Location = new System.Drawing.Point(3, 31);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(100, 23);
            this.lblNewPwd.TabIndex = 5;
            this.lblNewPwd.Text = "비밀번호";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPwd.Location = new System.Drawing.Point(147, 29);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(223, 21);
            this.txtNewPwd.TabIndex = 5;
            this.txtNewPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPwd_KeyPress);
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
            this.cbxduration.Location = new System.Drawing.Point(155, 237);
            this.cbxduration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxduration.Name = "cbxduration";
            this.cbxduration.Size = new System.Drawing.Size(223, 20);
            this.cbxduration.TabIndex = 34;
            // 
            // btnSavingsExtension
            // 
            this.btnSavingsExtension.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSavingsExtension.Location = new System.Drawing.Point(781, 375);
            this.btnSavingsExtension.Name = "btnSavingsExtension";
            this.btnSavingsExtension.Size = new System.Drawing.Size(125, 64);
            this.btnSavingsExtension.TabIndex = 41;
            this.btnSavingsExtension.Text = "계좌 연장";
            this.btnSavingsExtension.UseVisualStyleBackColor = true;
            this.btnSavingsExtension.Click += new System.EventHandler(this.btnSavingsExtension_Click);
            // 
            // lblduration
            // 
            this.lblduration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblduration.Location = new System.Drawing.Point(10, 237);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(100, 23);
            this.lblduration.TabIndex = 33;
            this.lblduration.Text = "*가입기간 연장";
            this.lblduration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutAccount
            // 
            this.lblOutAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutAccount.Location = new System.Drawing.Point(10, 334);
            this.lblOutAccount.Name = "lblOutAccount";
            this.lblOutAccount.Size = new System.Drawing.Size(100, 23);
            this.lblOutAccount.TabIndex = 39;
            this.lblOutAccount.Text = "출금계좌 변경";
            this.lblOutAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOutAccount
            // 
            this.txtOutAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutAccount.Location = new System.Drawing.Point(155, 331);
            this.txtOutAccount.Name = "txtOutAccount";
            this.txtOutAccount.Size = new System.Drawing.Size(223, 21);
            this.txtOutAccount.TabIndex = 35;
            this.txtOutAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutAccount_KeyPress);
            // 
            // lblOutPwd
            // 
            this.lblOutPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutPwd.Location = new System.Drawing.Point(10, 383);
            this.lblOutPwd.Name = "lblOutPwd";
            this.lblOutPwd.Size = new System.Drawing.Size(139, 23);
            this.lblOutPwd.TabIndex = 36;
            this.lblOutPwd.Text = "출금 계좌 비밀번호";
            this.lblOutPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOutPwd
            // 
            this.txtOutPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutPwd.Location = new System.Drawing.Point(155, 379);
            this.txtOutPwd.Name = "txtOutPwd";
            this.txtOutPwd.Size = new System.Drawing.Size(223, 21);
            this.txtOutPwd.TabIndex = 37;
            this.txtOutPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutPwd_KeyPress);
            // 
            // dgvMemver
            // 
            this.dgvMemver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMemver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemver.Location = new System.Drawing.Point(6, 12);
            this.dgvMemver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMemver.Name = "dgvMemver";
            this.dgvMemver.RowHeadersWidth = 51;
            this.dgvMemver.RowTemplate.Height = 27;
            this.dgvMemver.Size = new System.Drawing.Size(922, 221);
            this.dgvMemver.TabIndex = 32;
            this.dgvMemver.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemver_CellDoubleClick);
            // 
            // lblpayPerMonth
            // 
            this.lblpayPerMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblpayPerMonth.Location = new System.Drawing.Point(438, 344);
            this.lblpayPerMonth.Name = "lblpayPerMonth";
            this.lblpayPerMonth.Size = new System.Drawing.Size(100, 23);
            this.lblpayPerMonth.TabIndex = 45;
            this.lblpayPerMonth.Text = "매회 납입 금액 ";
            this.lblpayPerMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpayPerMonth
            // 
            this.txtpayPerMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpayPerMonth.Location = new System.Drawing.Point(583, 341);
            this.txtpayPerMonth.Name = "txtpayPerMonth";
            this.txtpayPerMonth.Size = new System.Drawing.Size(223, 21);
            this.txtpayPerMonth.TabIndex = 44;
            this.txtpayPerMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtpayPerMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpayPerMonth_KeyPress);
            // 
            // checkControl11
            // 
            this.checkControl11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkControl11.Location = new System.Drawing.Point(436, 405);
            this.checkControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkControl11.Name = "checkControl11";
            this.checkControl11.Size = new System.Drawing.Size(189, 16);
            this.checkControl11.TabIndex = 43;
            this.checkControl11.TabStop = false;
            // 
            // frmSavingExtension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(934, 438);
            this.Controls.Add(this.lblpayPerMonth);
            this.Controls.Add(this.txtpayPerMonth);
            this.Controls.Add(this.checkControl11);
            this.Controls.Add(this.lblCurrentMoney);
            this.Controls.Add(this.txtCurrentMoney);
            this.Controls.Add(this.gbxNewAccount);
            this.Controls.Add(this.cbxduration);
            this.Controls.Add(this.btnSavingsExtension);
            this.Controls.Add(this.lblduration);
            this.Controls.Add(this.lblOutAccount);
            this.Controls.Add(this.txtOutAccount);
            this.Controls.Add(this.lblOutPwd);
            this.Controls.Add(this.txtOutPwd);
            this.Controls.Add(this.dgvMemver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSavingExtension";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SavingExtension";
            this.Load += new System.EventHandler(this.frmSavingExtension_Load);
            this.gbxNewAccount.ResumeLayout(false);
            this.gbxNewAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckControl1 checkControl11;
        private System.Windows.Forms.Label lblCurrentMoney;
        private System.Windows.Forms.TextBox txtCurrentMoney;
        private System.Windows.Forms.GroupBox gbxNewAccount;
        private System.Windows.Forms.Label lblCheckNewPwd;
        private System.Windows.Forms.TextBox txtCheckNewPwd;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.ComboBox cbxduration;
        private System.Windows.Forms.Button btnSavingsExtension;
        private System.Windows.Forms.Label lblduration;
        private System.Windows.Forms.Label lblOutAccount;
        private System.Windows.Forms.TextBox txtOutAccount;
        private System.Windows.Forms.Label lblOutPwd;
        private System.Windows.Forms.TextBox txtOutPwd;
        private System.Windows.Forms.DataGridView dgvMemver;
        private System.Windows.Forms.Label lblpayPerMonth;
        private System.Windows.Forms.TextBox txtpayPerMonth;
    }
}