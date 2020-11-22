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
            this.dgvMemver = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblpayPerMonth = new System.Windows.Forms.Label();
            this.txtpayPerMonth = new System.Windows.Forms.TextBox();
            this.checkControl11 = new WindowsFormsAppPersonalProject.CheckControl1();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbxNewAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMemver
            // 
            this.dgvMemver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMemver.Location = new System.Drawing.Point(0, 0);
            this.dgvMemver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMemver.Name = "dgvMemver";
            this.dgvMemver.RowHeadersWidth = 51;
            this.dgvMemver.RowTemplate.Height = 27;
            this.dgvMemver.Size = new System.Drawing.Size(1067, 274);
            this.dgvMemver.StandardTab = true;
            this.dgvMemver.TabIndex = 32;
            this.dgvMemver.TabStop = false;
            this.dgvMemver.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemver_CellDoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvMemver);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblpayPerMonth);
            this.splitContainer1.Panel2.Controls.Add(this.txtpayPerMonth);
            this.splitContainer1.Panel2.Controls.Add(this.checkControl11);
            this.splitContainer1.Panel2.Controls.Add(this.lblCurrentMoney);
            this.splitContainer1.Panel2.Controls.Add(this.txtCurrentMoney);
            this.splitContainer1.Panel2.Controls.Add(this.gbxNewAccount);
            this.splitContainer1.Panel2.Controls.Add(this.cbxduration);
            this.splitContainer1.Panel2.Controls.Add(this.btnSavingsExtension);
            this.splitContainer1.Panel2.Controls.Add(this.lblduration);
            this.splitContainer1.Panel2.Controls.Add(this.lblOutAccount);
            this.splitContainer1.Panel2.Controls.Add(this.txtOutAccount);
            this.splitContainer1.Panel2.Controls.Add(this.lblOutPwd);
            this.splitContainer1.Panel2.Controls.Add(this.txtOutPwd);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 548);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.TabIndex = 46;
            // 
            // lblpayPerMonth
            // 
            this.lblpayPerMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblpayPerMonth.Location = new System.Drawing.Point(511, 143);
            this.lblpayPerMonth.Name = "lblpayPerMonth";
            this.lblpayPerMonth.Size = new System.Drawing.Size(114, 29);
            this.lblpayPerMonth.TabIndex = 58;
            this.lblpayPerMonth.Text = "매회 납입 금액 ";
            this.lblpayPerMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpayPerMonth
            // 
            this.txtpayPerMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpayPerMonth.Location = new System.Drawing.Point(676, 139);
            this.txtpayPerMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpayPerMonth.Name = "txtpayPerMonth";
            this.txtpayPerMonth.Size = new System.Drawing.Size(254, 25);
            this.txtpayPerMonth.TabIndex = 7;
            this.txtpayPerMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkControl11
            // 
            this.checkControl11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkControl11.Location = new System.Drawing.Point(508, 219);
            this.checkControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkControl11.Name = "checkControl11";
            this.checkControl11.Size = new System.Drawing.Size(216, 20);
            this.checkControl11.TabIndex = 56;
            this.checkControl11.TabStop = false;
            // 
            // lblCurrentMoney
            // 
            this.lblCurrentMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentMoney.Location = new System.Drawing.Point(21, 71);
            this.lblCurrentMoney.Name = "lblCurrentMoney";
            this.lblCurrentMoney.Size = new System.Drawing.Size(114, 29);
            this.lblCurrentMoney.TabIndex = 55;
            this.lblCurrentMoney.Text = "현재 적금 금액";
            this.lblCurrentMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCurrentMoney
            // 
            this.txtCurrentMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurrentMoney.Location = new System.Drawing.Point(187, 67);
            this.txtCurrentMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurrentMoney.Name = "txtCurrentMoney";
            this.txtCurrentMoney.ReadOnly = true;
            this.txtCurrentMoney.Size = new System.Drawing.Size(254, 25);
            this.txtCurrentMoney.TabIndex = 1;
            // 
            // gbxNewAccount
            // 
            this.gbxNewAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxNewAccount.Controls.Add(this.lblCheckNewPwd);
            this.gbxNewAccount.Controls.Add(this.txtCheckNewPwd);
            this.gbxNewAccount.Controls.Add(this.lblNewPwd);
            this.gbxNewAccount.Controls.Add(this.txtNewPwd);
            this.gbxNewAccount.Location = new System.Drawing.Point(508, 9);
            this.gbxNewAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxNewAccount.Name = "gbxNewAccount";
            this.gbxNewAccount.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxNewAccount.Size = new System.Drawing.Size(538, 122);
            this.gbxNewAccount.TabIndex = 4;
            this.gbxNewAccount.TabStop = false;
            this.gbxNewAccount.Text = "적금 계좌 비밀번호 변경";
            // 
            // lblCheckNewPwd
            // 
            this.lblCheckNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckNewPwd.Location = new System.Drawing.Point(3, 72);
            this.lblCheckNewPwd.Name = "lblCheckNewPwd";
            this.lblCheckNewPwd.Size = new System.Drawing.Size(114, 29);
            this.lblCheckNewPwd.TabIndex = 7;
            this.lblCheckNewPwd.Text = "비밀번호 확인";
            // 
            // txtCheckNewPwd
            // 
            this.txtCheckNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCheckNewPwd.Location = new System.Drawing.Point(168, 69);
            this.txtCheckNewPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCheckNewPwd.Name = "txtCheckNewPwd";
            this.txtCheckNewPwd.Size = new System.Drawing.Size(254, 25);
            this.txtCheckNewPwd.TabIndex = 6;
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewPwd.Location = new System.Drawing.Point(3, 39);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(114, 29);
            this.lblNewPwd.TabIndex = 5;
            this.lblNewPwd.Text = "비밀번호";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPwd.Location = new System.Drawing.Point(168, 36);
            this.txtNewPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(254, 25);
            this.txtNewPwd.TabIndex = 5;
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
            this.cbxduration.Location = new System.Drawing.Point(187, 9);
            this.cbxduration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxduration.Name = "cbxduration";
            this.cbxduration.Size = new System.Drawing.Size(254, 23);
            this.cbxduration.TabIndex = 0;
            // 
            // btnSavingsExtension
            // 
            this.btnSavingsExtension.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSavingsExtension.Location = new System.Drawing.Point(903, 182);
            this.btnSavingsExtension.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSavingsExtension.Name = "btnSavingsExtension";
            this.btnSavingsExtension.Size = new System.Drawing.Size(143, 80);
            this.btnSavingsExtension.TabIndex = 8;
            this.btnSavingsExtension.Text = "계좌 연장";
            this.btnSavingsExtension.UseVisualStyleBackColor = true;
            // 
            // lblduration
            // 
            this.lblduration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblduration.Location = new System.Drawing.Point(21, 9);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(114, 29);
            this.lblduration.TabIndex = 46;
            this.lblduration.Text = "*가입기간 연장";
            this.lblduration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutAccount
            // 
            this.lblOutAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutAccount.Location = new System.Drawing.Point(21, 131);
            this.lblOutAccount.Name = "lblOutAccount";
            this.lblOutAccount.Size = new System.Drawing.Size(114, 29);
            this.lblOutAccount.TabIndex = 52;
            this.lblOutAccount.Text = "출금계좌 변경";
            this.lblOutAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOutAccount
            // 
            this.txtOutAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutAccount.Location = new System.Drawing.Point(187, 127);
            this.txtOutAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutAccount.Name = "txtOutAccount";
            this.txtOutAccount.Size = new System.Drawing.Size(254, 25);
            this.txtOutAccount.TabIndex = 2;
            this.txtOutAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOutPwd
            // 
            this.lblOutPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutPwd.Location = new System.Drawing.Point(21, 192);
            this.lblOutPwd.Name = "lblOutPwd";
            this.lblOutPwd.Size = new System.Drawing.Size(159, 29);
            this.lblOutPwd.TabIndex = 49;
            this.lblOutPwd.Text = "출금 계좌 비밀번호";
            this.lblOutPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOutPwd
            // 
            this.txtOutPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutPwd.Location = new System.Drawing.Point(187, 187);
            this.txtOutPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutPwd.Name = "txtOutPwd";
            this.txtOutPwd.Size = new System.Drawing.Size(254, 25);
            this.txtOutPwd.TabIndex = 3;
            this.txtOutPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmSavingExtension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1067, 548);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSavingExtension";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SavingExtension";
            this.Load += new System.EventHandler(this.frmSavingExtension_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemver)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbxNewAccount.ResumeLayout(false);
            this.gbxNewAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMemver;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblpayPerMonth;
        private System.Windows.Forms.TextBox txtpayPerMonth;
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
    }
}