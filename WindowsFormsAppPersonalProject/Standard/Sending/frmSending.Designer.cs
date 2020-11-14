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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.splitContainer1.Size = new System.Drawing.Size(914, 562);
            this.splitContainer1.SplitterDistance = 144;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 144);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMember.Location = new System.Drawing.Point(0, 0);
            this.dgvMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersWidth = 51;
            this.dgvMember.RowTemplate.Height = 23;
            this.dgvMember.Size = new System.Drawing.Size(914, 144);
            this.dgvMember.TabIndex = 1;
            this.dgvMember.TabStop = false;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(914, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "이체";
            // 
            // lblAlert
            // 
            this.lblAlert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlert.Location = new System.Drawing.Point(343, 52);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(294, 29);
            this.lblAlert.TabIndex = 17;
            this.lblAlert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInputAcc
            // 
            this.txtInputAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInputAcc.Location = new System.Drawing.Point(125, 171);
            this.txtInputAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInputAcc.Name = "txtInputAcc";
            this.txtInputAcc.Size = new System.Drawing.Size(178, 25);
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
            this.groupBox2.Location = new System.Drawing.Point(15, 241);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(622, 159);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "출금 계좌 정보";
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.Location = new System.Drawing.Point(469, 10);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(149, 69);
            this.btnSelect.TabIndex = 18;
            this.btnSelect.Text = "이체 내역 조회";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblOutAcc
            // 
            this.lblOutAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutAcc.Location = new System.Drawing.Point(6, 21);
            this.lblOutAcc.Name = "lblOutAcc";
            this.lblOutAcc.Size = new System.Drawing.Size(79, 39);
            this.lblOutAcc.TabIndex = 13;
            this.lblOutAcc.Text = "*출금 계좌";
            this.lblOutAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxOutAcc
            // 
            this.cbxOutAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxOutAcc.FormattingEnabled = true;
            this.cbxOutAcc.Location = new System.Drawing.Point(119, 39);
            this.cbxOutAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxOutAcc.Name = "cbxOutAcc";
            this.cbxOutAcc.Size = new System.Drawing.Size(178, 23);
            this.cbxOutAcc.TabIndex = 4;
            this.cbxOutAcc.SelectedValueChanged += new System.EventHandler(this.cbxOutAcc_SelectedValueChanged);
            this.cbxOutAcc.Enter += new System.EventHandler(this.cbxOutAcc_Enter);
            // 
            // txtOutPwd
            // 
            this.txtOutPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutPwd.Location = new System.Drawing.Point(119, 94);
            this.txtOutPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutPwd.Name = "txtOutPwd";
            this.txtOutPwd.Size = new System.Drawing.Size(178, 25);
            this.txtOutPwd.TabIndex = 5;
            this.txtOutPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutPwd_KeyPress);
            // 
            // lblOutPwd
            // 
            this.lblOutPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutPwd.Location = new System.Drawing.Point(6, 76);
            this.lblOutPwd.Name = "lblOutPwd";
            this.lblOutPwd.Size = new System.Drawing.Size(79, 42);
            this.lblOutPwd.TabIndex = 12;
            this.lblOutPwd.Text = "*출금 계좌 비밀 번호";
            this.lblOutPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSend.Location = new System.Drawing.Point(469, 84);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(149, 69);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "계좌 이체";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtCurrentLeftOver
            // 
            this.txtCurrentLeftOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurrentLeftOver.Location = new System.Drawing.Point(125, 52);
            this.txtCurrentLeftOver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurrentLeftOver.Name = "txtCurrentLeftOver";
            this.txtCurrentLeftOver.ReadOnly = true;
            this.txtCurrentLeftOver.Size = new System.Drawing.Size(178, 25);
            this.txtCurrentLeftOver.TabIndex = 0;
            this.txtCurrentLeftOver.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCurrentOver
            // 
            this.lblCurrentOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentOver.Location = new System.Drawing.Point(11, 52);
            this.lblCurrentOver.Name = "lblCurrentOver";
            this.lblCurrentOver.Size = new System.Drawing.Size(74, 39);
            this.lblCurrentOver.TabIndex = 11;
            this.lblCurrentOver.Text = "현재 잔액";
            this.lblCurrentOver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxRecently
            // 
            this.cbxRecently.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxRecently.FormattingEnabled = true;
            this.cbxRecently.Items.AddRange(new object[] {
            "한국은행",
            "산업 은행",
            "기업 은행",
            "수출입 은행",
            "수협",
            "농협",
            "국민은행",
            "우리은행",
            "SC제일",
            "한국씨티",
            "하나",
            "신한",
            "대구 은행",
            "부산 은행",
            "광주 은행",
            "제주 은행",
            "전북 은행",
            "경남 은행",
            "케이뱅크",
            "카카오",
            "모건스탠리",
            "HSBC",
            "도이치",
            "JP모건",
            "미즈호",
            "미쓰비시",
            "BOA",
            "BNP 파리바",
            "유니크레딧",
            "중국공상",
            "중국 은행",
            "중국광대 은행",
            "중국교통 은행",
            "중국농업 은행",
            "BNI",
            "스태이트 뱅크 오브 인디아",
            "ING은행"});
            this.cbxRecently.Location = new System.Drawing.Point(456, 178);
            this.cbxRecently.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxRecently.Name = "cbxRecently";
            this.cbxRecently.Size = new System.Drawing.Size(178, 23);
            this.cbxRecently.TabIndex = 3;
            this.cbxRecently.SelectedValueChanged += new System.EventHandler(this.cbxRecently_SelectedValueChanged);
            // 
            // txtAmountOfSending
            // 
            this.txtAmountOfSending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmountOfSending.Location = new System.Drawing.Point(125, 115);
            this.txtAmountOfSending.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmountOfSending.Name = "txtAmountOfSending";
            this.txtAmountOfSending.Size = new System.Drawing.Size(178, 25);
            this.txtAmountOfSending.TabIndex = 1;
            this.txtAmountOfSending.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountOfSending.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountOfSending_KeyPress);
            // 
            // lblInputAcc
            // 
            this.lblInputAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInputAcc.Location = new System.Drawing.Point(-4, 171);
            this.lblInputAcc.Name = "lblInputAcc";
            this.lblInputAcc.Size = new System.Drawing.Size(89, 39);
            this.lblInputAcc.TabIndex = 2;
            this.lblInputAcc.Text = "*입금 계좌";
            this.lblInputAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblInputAcc.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblRecently
            // 
            this.lblRecently.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecently.Location = new System.Drawing.Point(343, 178);
            this.lblRecently.Name = "lblRecently";
            this.lblRecently.Size = new System.Drawing.Size(74, 39);
            this.lblRecently.TabIndex = 1;
            this.lblRecently.Text = "최근 목록";
            this.lblRecently.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAmountOfSending
            // 
            this.lblAmountOfSending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmountOfSending.Location = new System.Drawing.Point(-4, 115);
            this.lblAmountOfSending.Name = "lblAmountOfSending";
            this.lblAmountOfSending.Size = new System.Drawing.Size(89, 39);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}