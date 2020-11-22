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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkControl11 = new WindowsFormsAppPersonalProject.CheckControl1();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.dgvMemver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemver.Size = new System.Drawing.Size(1078, 276);
            this.dgvMemver.StandardTab = true;
            this.dgvMemver.TabIndex = 0;
            this.dgvMemver.TabStop = false;
            this.dgvMemver.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemver_CellDoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.splitContainer1.Panel2.Controls.Add(this.checkControl11);
            this.splitContainer1.Panel2.Controls.Add(this.lblCurrentMoney);
            this.splitContainer1.Panel2.Controls.Add(this.txtCurrentMoney);
            this.splitContainer1.Panel2.Controls.Add(this.gbxNewAccount);
            this.splitContainer1.Panel2.Controls.Add(this.cbxduration);
            this.splitContainer1.Panel2.Controls.Add(this.lblduration);
            this.splitContainer1.Panel2.Controls.Add(this.btndepositExtension);
            this.splitContainer1.Panel2.Controls.Add(this.lblOutAccount);
            this.splitContainer1.Panel2.Controls.Add(this.txtOutAccount);
            this.splitContainer1.Panel2.Controls.Add(this.lblOutPwd);
            this.splitContainer1.Panel2.Controls.Add(this.txtOutPwd);
            this.splitContainer1.Size = new System.Drawing.Size(1078, 552);
            this.splitContainer1.SplitterDistance = 276;
            this.splitContainer1.TabIndex = 32;
            // 
            // checkControl11
            // 
            this.checkControl11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkControl11.Location = new System.Drawing.Point(558, 213);
            this.checkControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkControl11.Name = "checkControl11";
            this.checkControl11.Size = new System.Drawing.Size(216, 20);
            this.checkControl11.TabIndex = 42;
            this.checkControl11.TabStop = false;
            // 
            // lblCurrentMoney
            // 
            this.lblCurrentMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentMoney.Location = new System.Drawing.Point(78, 91);
            this.lblCurrentMoney.Name = "lblCurrentMoney";
            this.lblCurrentMoney.Size = new System.Drawing.Size(114, 29);
            this.lblCurrentMoney.TabIndex = 41;
            this.lblCurrentMoney.Text = "현재 예치 금액";
            this.lblCurrentMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCurrentMoney
            // 
            this.txtCurrentMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurrentMoney.Location = new System.Drawing.Point(242, 88);
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
            this.gbxNewAccount.Location = new System.Drawing.Point(558, 30);
            this.gbxNewAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxNewAccount.Name = "gbxNewAccount";
            this.gbxNewAccount.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxNewAccount.Size = new System.Drawing.Size(508, 143);
            this.gbxNewAccount.TabIndex = 4;
            this.gbxNewAccount.TabStop = false;
            this.gbxNewAccount.Text = "예금 계좌 비밀번호 변경";
            // 
            // lblCheckNewPwd
            // 
            this.lblCheckNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckNewPwd.Location = new System.Drawing.Point(22, 86);
            this.lblCheckNewPwd.Name = "lblCheckNewPwd";
            this.lblCheckNewPwd.Size = new System.Drawing.Size(114, 29);
            this.lblCheckNewPwd.TabIndex = 7;
            this.lblCheckNewPwd.Text = "비밀번호 확인";
            // 
            // txtCheckNewPwd
            // 
            this.txtCheckNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCheckNewPwd.Location = new System.Drawing.Point(187, 83);
            this.txtCheckNewPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCheckNewPwd.Name = "txtCheckNewPwd";
            this.txtCheckNewPwd.Size = new System.Drawing.Size(254, 25);
            this.txtCheckNewPwd.TabIndex = 6;
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewPwd.Location = new System.Drawing.Point(22, 53);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(114, 29);
            this.lblNewPwd.TabIndex = 5;
            this.lblNewPwd.Text = "비밀번호";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPwd.Location = new System.Drawing.Point(187, 50);
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
            this.cbxduration.Location = new System.Drawing.Point(242, 30);
            this.cbxduration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxduration.Name = "cbxduration";
            this.cbxduration.Size = new System.Drawing.Size(254, 23);
            this.cbxduration.TabIndex = 0;
            // 
            // btndepositExtension
            // 
            this.btndepositExtension.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndepositExtension.Location = new System.Drawing.Point(923, 178);
            this.btndepositExtension.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndepositExtension.Name = "btndepositExtension";
            this.btndepositExtension.Size = new System.Drawing.Size(143, 80);
            this.btndepositExtension.TabIndex = 7;
            this.btndepositExtension.Text = "계좌 연장";
            this.btndepositExtension.UseVisualStyleBackColor = true;
            // 
            // lblduration
            // 
            this.lblduration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblduration.Location = new System.Drawing.Point(78, 30);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(114, 29);
            this.lblduration.TabIndex = 32;
            this.lblduration.Text = "*가입기간 연장";
            this.lblduration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutAccount
            // 
            this.lblOutAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutAccount.Location = new System.Drawing.Point(78, 152);
            this.lblOutAccount.Name = "lblOutAccount";
            this.lblOutAccount.Size = new System.Drawing.Size(114, 29);
            this.lblOutAccount.TabIndex = 38;
            this.lblOutAccount.Text = "출금계좌 변경";
            this.lblOutAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOutAccount
            // 
            this.txtOutAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutAccount.Location = new System.Drawing.Point(242, 148);
            this.txtOutAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutAccount.Name = "txtOutAccount";
            this.txtOutAccount.Size = new System.Drawing.Size(254, 25);
            this.txtOutAccount.TabIndex = 2;
            this.txtOutAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOutPwd
            // 
            this.lblOutPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutPwd.Location = new System.Drawing.Point(78, 213);
            this.lblOutPwd.Name = "lblOutPwd";
            this.lblOutPwd.Size = new System.Drawing.Size(159, 29);
            this.lblOutPwd.TabIndex = 35;
            this.lblOutPwd.Text = "출금 계좌 비밀번호";
            this.lblOutPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOutPwd
            // 
            this.txtOutPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutPwd.Location = new System.Drawing.Point(242, 208);
            this.txtOutPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutPwd.Name = "txtOutPwd";
            this.txtOutPwd.Size = new System.Drawing.Size(254, 25);
            this.txtOutPwd.TabIndex = 3;
            this.txtOutPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmDepositExtension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1078, 552);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDepositExtension";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "예금 연장";
            this.Load += new System.EventHandler(this.frmDepositExtension_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.SplitContainer splitContainer1;
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
    }
}