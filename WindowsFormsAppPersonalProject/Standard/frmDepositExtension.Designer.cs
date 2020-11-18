namespace WindowsFormsAppPersonalProject
{
    partial class frmDepositExtension
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepositExtension));
            this.dgvMemver = new System.Windows.Forms.DataGridView();
            this.lblCurrentMoney = new System.Windows.Forms.Label();
            this.txtCurrentMoney = new System.Windows.Forms.TextBox();
            this.gbxNewAccount = new System.Windows.Forms.GroupBox();
            this.lblCheckNewPwd = new System.Windows.Forms.Label();
            this.txtCheckNewPwd = new System.Windows.Forms.TextBox();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.cbxduration = new System.Windows.Forms.ComboBox();
            this.btndepositExtension = new System.Windows.Forms.Button();
            this.lblduration = new System.Windows.Forms.Label();
            this.lblOutAccount = new System.Windows.Forms.Label();
            this.txtOutAccount = new System.Windows.Forms.TextBox();
            this.lblOutPwd = new System.Windows.Forms.Label();
            this.txtOutPwd = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkControl11 = new WindowsFormsAppPersonalProject.CheckControl1();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemver)).BeginInit();
            this.gbxNewAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMemver
            // 
            this.dgvMemver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMemver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemver.Location = new System.Drawing.Point(10, 10);
            this.dgvMemver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMemver.Name = "dgvMemver";
            this.dgvMemver.RowHeadersWidth = 51;
            this.dgvMemver.RowTemplate.Height = 27;
            this.dgvMemver.Size = new System.Drawing.Size(922, 221);
            this.dgvMemver.TabIndex = 0;
            this.dgvMemver.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemver_CellDoubleClick);
            // 
            // lblCurrentMoney
            // 
            this.lblCurrentMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentMoney.Location = new System.Drawing.Point(20, 303);
            this.lblCurrentMoney.Name = "lblCurrentMoney";
            this.lblCurrentMoney.Size = new System.Drawing.Size(100, 23);
            this.lblCurrentMoney.TabIndex = 30;
            this.lblCurrentMoney.Text = "현재 예치 금액";
            this.lblCurrentMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCurrentMoney
            // 
            this.txtCurrentMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurrentMoney.Location = new System.Drawing.Point(164, 301);
            this.txtCurrentMoney.Name = "txtCurrentMoney";
            this.txtCurrentMoney.ReadOnly = true;
            this.txtCurrentMoney.Size = new System.Drawing.Size(223, 21);
            this.txtCurrentMoney.TabIndex = 27;
            // 
            // gbxNewAccount
            // 
            this.gbxNewAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxNewAccount.Controls.Add(this.lblCheckNewPwd);
            this.gbxNewAccount.Controls.Add(this.txtCheckNewPwd);
            this.gbxNewAccount.Controls.Add(this.lblNewPwd);
            this.gbxNewAccount.Controls.Add(this.txtNewPwd);
            this.gbxNewAccount.Location = new System.Drawing.Point(440, 254);
            this.gbxNewAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxNewAccount.Name = "gbxNewAccount";
            this.gbxNewAccount.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxNewAccount.Size = new System.Drawing.Size(471, 98);
            this.gbxNewAccount.TabIndex = 25;
            this.gbxNewAccount.TabStop = false;
            this.gbxNewAccount.Text = "예금 계좌 비밀번호 변경";
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
            this.txtCheckNewPwd.TextChanged += new System.EventHandler(this.txtCheckNewPwd_TextChanged);
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
            this.cbxduration.Location = new System.Drawing.Point(164, 254);
            this.cbxduration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxduration.Name = "cbxduration";
            this.cbxduration.Size = new System.Drawing.Size(223, 20);
            this.cbxduration.TabIndex = 19;
            // 
            // btndepositExtension
            // 
            this.btndepositExtension.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndepositExtension.Location = new System.Drawing.Point(786, 361);
            this.btndepositExtension.Name = "btndepositExtension";
            this.btndepositExtension.Size = new System.Drawing.Size(125, 64);
            this.btndepositExtension.TabIndex = 28;
            this.btndepositExtension.Text = "계좌 연장";
            this.btndepositExtension.UseVisualStyleBackColor = true;
            this.btndepositExtension.Click += new System.EventHandler(this.btndepositExtension_Click);
            // 
            // lblduration
            // 
            this.lblduration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblduration.Location = new System.Drawing.Point(20, 254);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(100, 23);
            this.lblduration.TabIndex = 18;
            this.lblduration.Text = "*가입기간 연장";
            this.lblduration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutAccount
            // 
            this.lblOutAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutAccount.Location = new System.Drawing.Point(20, 352);
            this.lblOutAccount.Name = "lblOutAccount";
            this.lblOutAccount.Size = new System.Drawing.Size(100, 23);
            this.lblOutAccount.TabIndex = 26;
            this.lblOutAccount.Text = "출금계좌 변경";
            this.lblOutAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOutAccount
            // 
            this.txtOutAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutAccount.Location = new System.Drawing.Point(164, 349);
            this.txtOutAccount.Name = "txtOutAccount";
            this.txtOutAccount.Size = new System.Drawing.Size(223, 21);
            this.txtOutAccount.TabIndex = 22;
            this.txtOutAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutAccount_KeyPress);
            // 
            // lblOutPwd
            // 
            this.lblOutPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutPwd.Location = new System.Drawing.Point(20, 401);
            this.lblOutPwd.Name = "lblOutPwd";
            this.lblOutPwd.Size = new System.Drawing.Size(139, 23);
            this.lblOutPwd.TabIndex = 23;
            this.lblOutPwd.Text = "출금 계좌 비밀번호";
            this.lblOutPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOutPwd
            // 
            this.txtOutPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutPwd.Location = new System.Drawing.Point(164, 397);
            this.txtOutPwd.Name = "txtOutPwd";
            this.txtOutPwd.Size = new System.Drawing.Size(223, 21);
            this.txtOutPwd.TabIndex = 24;
            this.txtOutPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutPwd_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // checkControl11
            // 
            this.checkControl11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkControl11.Location = new System.Drawing.Point(442, 402);
            this.checkControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkControl11.Name = "checkControl11";
            this.checkControl11.Size = new System.Drawing.Size(189, 16);
            this.checkControl11.TabIndex = 31;
            this.checkControl11.TabStop = false;
            // 
            // frmDepositExtension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(943, 442);
            this.Controls.Add(this.checkControl11);
            this.Controls.Add(this.lblCurrentMoney);
            this.Controls.Add(this.txtCurrentMoney);
            this.Controls.Add(this.gbxNewAccount);
            this.Controls.Add(this.cbxduration);
            this.Controls.Add(this.btndepositExtension);
            this.Controls.Add(this.lblduration);
            this.Controls.Add(this.lblOutAccount);
            this.Controls.Add(this.txtOutAccount);
            this.Controls.Add(this.lblOutPwd);
            this.Controls.Add(this.txtOutPwd);
            this.Controls.Add(this.dgvMemver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDepositExtension";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "예금 연장";
            this.Load += new System.EventHandler(this.frmDepositExtension_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemver)).EndInit();
            this.gbxNewAccount.ResumeLayout(false);
            this.gbxNewAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMemver;
        private CheckControl1 checkControl11;
        private System.Windows.Forms.Label lblCurrentMoney;
        private System.Windows.Forms.TextBox txtCurrentMoney;
        private System.Windows.Forms.GroupBox gbxNewAccount;
        private System.Windows.Forms.Label lblCheckNewPwd;
        private System.Windows.Forms.TextBox txtCheckNewPwd;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.ComboBox cbxduration;
        private System.Windows.Forms.Button btndepositExtension;
        private System.Windows.Forms.Label lblduration;
        private System.Windows.Forms.Label lblOutAccount;
        private System.Windows.Forms.TextBox txtOutAccount;
        private System.Windows.Forms.Label lblOutPwd;
        private System.Windows.Forms.TextBox txtOutPwd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}