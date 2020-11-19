namespace WindowsFormsAppPersonalProject
{
    partial class frmSending
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.cbxDepositAcc = new System.Windows.Forms.ComboBox();
            this.lblMyDeposit = new System.Windows.Forms.Label();
            this.cbxSavingAcc = new System.Windows.Forms.ComboBox();
            this.lblAlert = new System.Windows.Forms.Label();
            this.txtInputAcc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblOutAcc = new System.Windows.Forms.Label();
            this.cbxOutAcc = new System.Windows.Forms.ComboBox();
            this.txtOutPwd = new System.Windows.Forms.TextBox();
            this.lblOutPwd = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtCurrentLeftOver = new System.Windows.Forms.TextBox();
            this.lblCurrentOver = new System.Windows.Forms.Label();
            this.cbxRecently = new System.Windows.Forms.ComboBox();
            this.txtAmountOfSending = new System.Windows.Forms.TextBox();
            this.lblInputAcc = new System.Windows.Forms.Label();
            this.lblRecently = new System.Windows.Forms.Label();
            this.lblAmountOfSending = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.splitter1);
            this.splitContainer1.Panel1.Controls.Add(this.dgvMember);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(801, 540);
            this.splitContainer1.SplitterDistance = 138;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 138);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMember.Location = new System.Drawing.Point(0, 0);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersWidth = 51;
            this.dgvMember.RowTemplate.Height = 23;
            this.dgvMember.Size = new System.Drawing.Size(801, 138);
            this.dgvMember.TabIndex = 1;
            this.dgvMember.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lblAlert);
            this.groupBox1.Controls.Add(this.txtInputAcc);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtCurrentLeftOver);
            this.groupBox1.Controls.Add(this.lblCurrentOver);
            this.groupBox1.Controls.Add(this.cbxRecently);
            this.groupBox1.Controls.Add(this.txtAmountOfSending);
            this.groupBox1.Controls.Add(this.lblInputAcc);
            this.groupBox1.Controls.Add(this.lblRecently);
            this.groupBox1.Controls.Add(this.lblAmountOfSending);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "이체";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.lblDeposit);
            this.groupBox3.Controls.Add(this.cbxDepositAcc);
            this.groupBox3.Controls.Add(this.lblMyDeposit);
            this.groupBox3.Controls.Add(this.cbxSavingAcc);
            this.groupBox3.Location = new System.Drawing.Point(297, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 150);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "내 계좌로 입금";
            // 
            // lblDeposit
            // 
            this.lblDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDeposit.Location = new System.Drawing.Point(14, 57);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(74, 31);
            this.lblDeposit.TabIndex = 20;
            this.lblDeposit.Text = "내 예금 계좌";
            this.lblDeposit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbxDepositAcc
            // 
            this.cbxDepositAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxDepositAcc.FormattingEnabled = true;
            this.cbxDepositAcc.Location = new System.Drawing.Point(113, 57);
            this.cbxDepositAcc.Name = "cbxDepositAcc";
            this.cbxDepositAcc.Size = new System.Drawing.Size(156, 20);
            this.cbxDepositAcc.TabIndex = 21;
            this.cbxDepositAcc.SelectedValueChanged += new System.EventHandler(this.cbxDepositAcc_SelectedValueChanged);
            // 
            // lblMyDeposit
            // 
            this.lblMyDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMyDeposit.Location = new System.Drawing.Point(14, 98);
            this.lblMyDeposit.Name = "lblMyDeposit";
            this.lblMyDeposit.Size = new System.Drawing.Size(74, 31);
            this.lblMyDeposit.TabIndex = 18;
            this.lblMyDeposit.Text = "내 적금 계좌";
            this.lblMyDeposit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbxSavingAcc
            // 
            this.cbxSavingAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxSavingAcc.FormattingEnabled = true;
            this.cbxSavingAcc.Location = new System.Drawing.Point(113, 98);
            this.cbxSavingAcc.Name = "cbxSavingAcc";
            this.cbxSavingAcc.Size = new System.Drawing.Size(156, 20);
            this.cbxSavingAcc.TabIndex = 19;
            this.cbxSavingAcc.SelectedValueChanged += new System.EventHandler(this.cbxSavingAcc_SelectedValueChanged);
            // 
            // lblAlert
            // 
            this.lblAlert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlert.Location = new System.Drawing.Point(300, 241);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(257, 23);
            this.lblAlert.TabIndex = 17;
            this.lblAlert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInputAcc
            // 
            this.txtInputAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInputAcc.Location = new System.Drawing.Point(109, 168);
            this.txtInputAcc.Name = "txtInputAcc";
            this.txtInputAcc.Size = new System.Drawing.Size(156, 21);
            this.txtInputAcc.TabIndex = 2;
            this.txtInputAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInputAcc.TextChanged += new System.EventHandler(this.txtInputAcc_TextChanged);
            this.txtInputAcc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputAcc_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.Controls.Add(this.lblOutAcc);
            this.groupBox2.Controls.Add(this.cbxOutAcc);
            this.groupBox2.Controls.Add(this.txtOutPwd);
            this.groupBox2.Controls.Add(this.lblOutPwd);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Location = new System.Drawing.Point(6, 266);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(566, 127);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "출금 계좌 정보";
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.Location = new System.Drawing.Point(421, 8);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(130, 55);
            this.btnSelect.TabIndex = 18;
            this.btnSelect.Text = "이체 내역 조회";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblOutAcc
            // 
            this.lblOutAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutAcc.Location = new System.Drawing.Point(4, 32);
            this.lblOutAcc.Name = "lblOutAcc";
            this.lblOutAcc.Size = new System.Drawing.Size(69, 31);
            this.lblOutAcc.TabIndex = 13;
            this.lblOutAcc.Text = "*출금 계좌";
            this.lblOutAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxOutAcc
            // 
            this.cbxOutAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxOutAcc.FormattingEnabled = true;
            this.cbxOutAcc.Location = new System.Drawing.Point(103, 46);
            this.cbxOutAcc.Name = "cbxOutAcc";
            this.cbxOutAcc.Size = new System.Drawing.Size(156, 20);
            this.cbxOutAcc.TabIndex = 4;
            this.cbxOutAcc.SelectedValueChanged += new System.EventHandler(this.cbxOutAcc_SelectedValueChanged);
            this.cbxOutAcc.Enter += new System.EventHandler(this.cbxOutAcc_Enter);
            // 
            // txtOutPwd
            // 
            this.txtOutPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutPwd.Location = new System.Drawing.Point(103, 90);
            this.txtOutPwd.Name = "txtOutPwd";
            this.txtOutPwd.Size = new System.Drawing.Size(156, 21);
            this.txtOutPwd.TabIndex = 5;
            this.txtOutPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutPwd_KeyPress);
            // 
            // lblOutPwd
            // 
            this.lblOutPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutPwd.Location = new System.Drawing.Point(4, 76);
            this.lblOutPwd.Name = "lblOutPwd";
            this.lblOutPwd.Size = new System.Drawing.Size(69, 34);
            this.lblOutPwd.TabIndex = 12;
            this.lblOutPwd.Text = "*출금 계좌 비밀 번호";
            this.lblOutPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSend.Location = new System.Drawing.Point(421, 67);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(130, 55);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "계좌 이체";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtCurrentLeftOver
            // 
            this.txtCurrentLeftOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurrentLeftOver.Location = new System.Drawing.Point(109, 76);
            this.txtCurrentLeftOver.Name = "txtCurrentLeftOver";
            this.txtCurrentLeftOver.ReadOnly = true;
            this.txtCurrentLeftOver.Size = new System.Drawing.Size(156, 21);
            this.txtCurrentLeftOver.TabIndex = 0;
            this.txtCurrentLeftOver.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCurrentOver
            // 
            this.lblCurrentOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentOver.Location = new System.Drawing.Point(10, 76);
            this.lblCurrentOver.Name = "lblCurrentOver";
            this.lblCurrentOver.Size = new System.Drawing.Size(65, 31);
            this.lblCurrentOver.TabIndex = 11;
            this.lblCurrentOver.Text = "현재 잔액";
            this.lblCurrentOver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxRecently
            // 
            this.cbxRecently.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxRecently.FormattingEnabled = true;
            this.cbxRecently.Location = new System.Drawing.Point(109, 214);
            this.cbxRecently.Name = "cbxRecently";
            this.cbxRecently.Size = new System.Drawing.Size(156, 20);
            this.cbxRecently.TabIndex = 3;
            this.cbxRecently.SelectedValueChanged += new System.EventHandler(this.cbxRecently_SelectedValueChanged);
            // 
            // txtAmountOfSending
            // 
            this.txtAmountOfSending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmountOfSending.Location = new System.Drawing.Point(109, 122);
            this.txtAmountOfSending.Name = "txtAmountOfSending";
            this.txtAmountOfSending.Size = new System.Drawing.Size(156, 21);
            this.txtAmountOfSending.TabIndex = 1;
            this.txtAmountOfSending.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountOfSending.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountOfSending_KeyPress);
            // 
            // lblInputAcc
            // 
            this.lblInputAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInputAcc.Location = new System.Drawing.Point(-3, 168);
            this.lblInputAcc.Name = "lblInputAcc";
            this.lblInputAcc.Size = new System.Drawing.Size(78, 31);
            this.lblInputAcc.TabIndex = 2;
            this.lblInputAcc.Text = "*입금 계좌";
            this.lblInputAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblInputAcc.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblRecently
            // 
            this.lblRecently.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecently.Location = new System.Drawing.Point(10, 214);
            this.lblRecently.Name = "lblRecently";
            this.lblRecently.Size = new System.Drawing.Size(65, 31);
            this.lblRecently.TabIndex = 1;
            this.lblRecently.Text = "최근 목록";
            this.lblRecently.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAmountOfSending
            // 
            this.lblAmountOfSending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmountOfSending.Location = new System.Drawing.Point(-3, 122);
            this.lblAmountOfSending.Name = "lblAmountOfSending";
            this.lblAmountOfSending.Size = new System.Drawing.Size(78, 31);
            this.lblAmountOfSending.TabIndex = 0;
            this.lblAmountOfSending.Text = "*이체 금액";
            this.lblAmountOfSending.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmSending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 540);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.MinimizeBox = false;
            this.Name = "frmSending";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sending";
            this.Load += new System.EventHandler(this.frmSending_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInputAcc;
        private System.Windows.Forms.Label lblRecently;
        private System.Windows.Forms.Label lblAmountOfSending;
        private System.Windows.Forms.ComboBox cbxRecently;
        private System.Windows.Forms.TextBox txtAmountOfSending;
        private System.Windows.Forms.TextBox txtOutPwd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtCurrentLeftOver;
        private System.Windows.Forms.Label lblCurrentOver;
        private System.Windows.Forms.Label lblOutPwd;
        private System.Windows.Forms.ComboBox cbxOutAcc;
        private System.Windows.Forms.Label lblOutAcc;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtInputAcc;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cbxSavingAcc;
        private System.Windows.Forms.Label lblMyDeposit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.ComboBox cbxDepositAcc;
    }
}