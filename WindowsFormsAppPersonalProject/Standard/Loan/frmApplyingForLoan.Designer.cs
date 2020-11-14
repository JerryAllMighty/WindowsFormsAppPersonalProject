namespace WindowsFormsAppPersonalProject
{
    partial class frmApplyingForLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApplyingForLoan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkControl11 = new WindowsFormsAppPersonalProject.CheckControl1();
            this.cbxOutAccount = new System.Windows.Forms.ComboBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblEveryMonth = new System.Windows.Forms.Label();
            this.txtRegularWhen = new System.Windows.Forms.TextBox();
            this.lblRegularWhen = new System.Windows.Forms.Label();
            this.lblWhatisit = new System.Windows.Forms.Label();
            this.txtOutPwd = new System.Windows.Forms.TextBox();
            this.lblOutAccountPwd = new System.Windows.Forms.Label();
            this.lblOutAccount = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cbxDepositNum = new System.Windows.Forms.ComboBox();
            this.lblDAccountNum = new System.Windows.Forms.Label();
            this.lblKindOfLoan2 = new System.Windows.Forms.Label();
            this.lblKindOfLoan = new System.Windows.Forms.Label();
            this.txtWhenExpire = new System.Windows.Forms.TextBox();
            this.cbxPayBackMethod = new System.Windows.Forms.ComboBox();
            this.lblPayBackMethod = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblWon = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtAmountOfLoan = new System.Windows.Forms.TextBox();
            this.cbxPurpose = new System.Windows.Forms.ComboBox();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblWhenExpire = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblAmountOfLoan = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkControl11);
            this.groupBox1.Controls.Add(this.cbxOutAccount);
            this.groupBox1.Controls.Add(this.lblDay);
            this.groupBox1.Controls.Add(this.lblEveryMonth);
            this.groupBox1.Controls.Add(this.txtRegularWhen);
            this.groupBox1.Controls.Add(this.lblRegularWhen);
            this.groupBox1.Controls.Add(this.lblWhatisit);
            this.groupBox1.Controls.Add(this.txtOutPwd);
            this.groupBox1.Controls.Add(this.lblOutAccountPwd);
            this.groupBox1.Controls.Add(this.lblOutAccount);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.cbxDepositNum);
            this.groupBox1.Controls.Add(this.lblDAccountNum);
            this.groupBox1.Controls.Add(this.lblKindOfLoan2);
            this.groupBox1.Controls.Add(this.lblKindOfLoan);
            this.groupBox1.Controls.Add(this.txtWhenExpire);
            this.groupBox1.Controls.Add(this.cbxPayBackMethod);
            this.groupBox1.Controls.Add(this.lblPayBackMethod);
            this.groupBox1.Controls.Add(this.lblMonth);
            this.groupBox1.Controls.Add(this.lblWon);
            this.groupBox1.Controls.Add(this.txtPeriod);
            this.groupBox1.Controls.Add(this.txtAmountOfLoan);
            this.groupBox1.Controls.Add(this.cbxPurpose);
            this.groupBox1.Controls.Add(this.lblPurpose);
            this.groupBox1.Controls.Add(this.lblWhenExpire);
            this.groupBox1.Controls.Add(this.lblPeriod);
            this.groupBox1.Controls.Add(this.lblAmountOfLoan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(968, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상담정보입력";
            // 
            // checkControl11
            // 
            this.checkControl11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkControl11.Location = new System.Drawing.Point(364, 23);
            this.checkControl11.Name = "checkControl11";
            this.checkControl11.Size = new System.Drawing.Size(216, 20);
            this.checkControl11.TabIndex = 27;
            // 
            // cbxOutAccount
            // 
            this.cbxOutAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxOutAccount.BackColor = System.Drawing.Color.White;
            this.cbxOutAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOutAccount.FormattingEnabled = true;
            this.cbxOutAccount.Location = new System.Drawing.Point(711, 122);
            this.cbxOutAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxOutAccount.Name = "cbxOutAccount";
            this.cbxOutAccount.Size = new System.Drawing.Size(201, 23);
            this.cbxOutAccount.TabIndex = 6;
            this.cbxOutAccount.SelectedIndexChanged += new System.EventHandler(this.cbxOutAccount_SelectedIndexChanged);
            // 
            // lblDay
            // 
            this.lblDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(889, 285);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(22, 15);
            this.lblDay.TabIndex = 26;
            this.lblDay.Text = "일";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDay.Visible = false;
            // 
            // lblEveryMonth
            // 
            this.lblEveryMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEveryMonth.AutoSize = true;
            this.lblEveryMonth.Location = new System.Drawing.Point(742, 285);
            this.lblEveryMonth.Name = "lblEveryMonth";
            this.lblEveryMonth.Size = new System.Drawing.Size(37, 15);
            this.lblEveryMonth.TabIndex = 25;
            this.lblEveryMonth.Text = "매월";
            this.lblEveryMonth.Visible = false;
            // 
            // txtRegularWhen
            // 
            this.txtRegularWhen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegularWhen.Location = new System.Drawing.Point(801, 281);
            this.txtRegularWhen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegularWhen.Name = "txtRegularWhen";
            this.txtRegularWhen.Size = new System.Drawing.Size(89, 25);
            this.txtRegularWhen.TabIndex = 8;
            this.txtRegularWhen.Visible = false;
            this.txtRegularWhen.TextChanged += new System.EventHandler(this.txtRegularWhen_TextChanged);
            this.txtRegularWhen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegularWhen_KeyPress);
            // 
            // lblRegularWhen
            // 
            this.lblRegularWhen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegularWhen.AutoSize = true;
            this.lblRegularWhen.Location = new System.Drawing.Point(506, 285);
            this.lblRegularWhen.Name = "lblRegularWhen";
            this.lblRegularWhen.Size = new System.Drawing.Size(162, 15);
            this.lblRegularWhen.TabIndex = 24;
            this.lblRegularWhen.Text = "정기 상환 시 상환 날짜";
            this.lblRegularWhen.Visible = false;
            // 
            // lblWhatisit
            // 
            this.lblWhatisit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWhatisit.AutoSize = true;
            this.lblWhatisit.Location = new System.Drawing.Point(563, 243);
            this.lblWhatisit.Name = "lblWhatisit";
            this.lblWhatisit.Size = new System.Drawing.Size(105, 15);
            this.lblWhatisit.TabIndex = 22;
            this.lblWhatisit.Text = "자유적금이란?";
            this.lblWhatisit.Visible = false;
            this.lblWhatisit.MouseEnter += new System.EventHandler(this.lblWhatisit_MouseEnter);
            // 
            // txtOutPwd
            // 
            this.txtOutPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutPwd.BackColor = System.Drawing.Color.White;
            this.txtOutPwd.Location = new System.Drawing.Point(711, 175);
            this.txtOutPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutPwd.Name = "txtOutPwd";
            this.txtOutPwd.Size = new System.Drawing.Size(201, 25);
            this.txtOutPwd.TabIndex = 7;
            this.txtOutPwd.TextChanged += new System.EventHandler(this.txtOutPwd_TextChanged);
            this.txtOutPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutPwd_KeyPress);
            // 
            // lblOutAccountPwd
            // 
            this.lblOutAccountPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutAccountPwd.AutoSize = true;
            this.lblOutAccountPwd.Location = new System.Drawing.Point(529, 175);
            this.lblOutAccountPwd.Name = "lblOutAccountPwd";
            this.lblOutAccountPwd.Size = new System.Drawing.Size(139, 15);
            this.lblOutAccountPwd.TabIndex = 20;
            this.lblOutAccountPwd.Text = "*출금계좌 비밀번호";
            // 
            // lblOutAccount
            // 
            this.lblOutAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutAccount.AutoSize = true;
            this.lblOutAccount.Location = new System.Drawing.Point(589, 125);
            this.lblOutAccount.Name = "lblOutAccount";
            this.lblOutAccount.Size = new System.Drawing.Size(79, 15);
            this.lblOutAccount.TabIndex = 18;
            this.lblOutAccount.Text = "*출금 계좌";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(761, 359);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 52);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.Location = new System.Drawing.Point(506, 359);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(154, 52);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "다음";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cbxDepositNum
            // 
            this.cbxDepositNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxDepositNum.BackColor = System.Drawing.Color.White;
            this.cbxDepositNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepositNum.FormattingEnabled = true;
            this.cbxDepositNum.Location = new System.Drawing.Point(212, 125);
            this.cbxDepositNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxDepositNum.Name = "cbxDepositNum";
            this.cbxDepositNum.Size = new System.Drawing.Size(146, 23);
            this.cbxDepositNum.TabIndex = 0;
            this.cbxDepositNum.SelectedValueChanged += new System.EventHandler(this.cbxDepositNum_SelectedValueChanged);
            // 
            // lblDAccountNum
            // 
            this.lblDAccountNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDAccountNum.AutoSize = true;
            this.lblDAccountNum.Location = new System.Drawing.Point(12, 125);
            this.lblDAccountNum.Name = "lblDAccountNum";
            this.lblDAccountNum.Size = new System.Drawing.Size(172, 15);
            this.lblDAccountNum.TabIndex = 14;
            this.lblDAccountNum.Text = "담보 제공 예금 계좌번호";
            this.lblDAccountNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKindOfLoan2
            // 
            this.lblKindOfLoan2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindOfLoan2.AutoSize = true;
            this.lblKindOfLoan2.Location = new System.Drawing.Point(209, 68);
            this.lblKindOfLoan2.Name = "lblKindOfLoan2";
            this.lblKindOfLoan2.Size = new System.Drawing.Size(149, 15);
            this.lblKindOfLoan2.TabIndex = 13;
            this.lblKindOfLoan2.Text = "예금(신탁) 담보 대출";
            this.lblKindOfLoan2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKindOfLoan
            // 
            this.lblKindOfLoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindOfLoan.AutoSize = true;
            this.lblKindOfLoan.Location = new System.Drawing.Point(107, 68);
            this.lblKindOfLoan.Name = "lblKindOfLoan";
            this.lblKindOfLoan.Size = new System.Drawing.Size(77, 15);
            this.lblKindOfLoan.TabIndex = 12;
            this.lblKindOfLoan.Text = "대출 구분 ";
            this.lblKindOfLoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWhenExpire
            // 
            this.txtWhenExpire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWhenExpire.BackColor = System.Drawing.Color.White;
            this.txtWhenExpire.Location = new System.Drawing.Point(212, 253);
            this.txtWhenExpire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWhenExpire.Name = "txtWhenExpire";
            this.txtWhenExpire.Size = new System.Drawing.Size(146, 25);
            this.txtWhenExpire.TabIndex = 2;
            this.txtWhenExpire.TextChanged += new System.EventHandler(this.txtWhenExpire_TextChanged);
            this.txtWhenExpire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWhenExpire_KeyPress);
            // 
            // cbxPayBackMethod
            // 
            this.cbxPayBackMethod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxPayBackMethod.BackColor = System.Drawing.Color.White;
            this.cbxPayBackMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayBackMethod.FormattingEnabled = true;
            this.cbxPayBackMethod.Items.AddRange(new object[] {
            "자유 반환",
            "정기 반환"});
            this.cbxPayBackMethod.Location = new System.Drawing.Point(212, 322);
            this.cbxPayBackMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPayBackMethod.Name = "cbxPayBackMethod";
            this.cbxPayBackMethod.Size = new System.Drawing.Size(146, 23);
            this.cbxPayBackMethod.TabIndex = 3;
            this.cbxPayBackMethod.SelectedIndexChanged += new System.EventHandler(this.cbxPayBackMethod_SelectedIndexChanged);
            this.cbxPayBackMethod.SelectedValueChanged += new System.EventHandler(this.cbxPayBackMethod_SelectedValueChanged);
            // 
            // lblPayBackMethod
            // 
            this.lblPayBackMethod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPayBackMethod.AutoSize = true;
            this.lblPayBackMethod.Location = new System.Drawing.Point(65, 322);
            this.lblPayBackMethod.Name = "lblPayBackMethod";
            this.lblPayBackMethod.Size = new System.Drawing.Size(119, 15);
            this.lblPayBackMethod.TabIndex = 9;
            this.lblPayBackMethod.Text = "*대출금상환방법";
            this.lblPayBackMethod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMonth
            // 
            this.lblMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(874, 68);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 15);
            this.lblMonth.TabIndex = 8;
            this.lblMonth.Text = "개월";
            // 
            // lblWon
            // 
            this.lblWon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWon.AutoSize = true;
            this.lblWon.Location = new System.Drawing.Point(341, 181);
            this.lblWon.Name = "lblWon";
            this.lblWon.Size = new System.Drawing.Size(22, 15);
            this.lblWon.TabIndex = 7;
            this.lblWon.Text = "원";
            this.lblWon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPeriod.BackColor = System.Drawing.Color.White;
            this.txtPeriod.Location = new System.Drawing.Point(711, 68);
            this.txtPeriod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(157, 25);
            this.txtPeriod.TabIndex = 5;
            this.txtPeriod.TextChanged += new System.EventHandler(this.txtPeriod_TextChanged);
            this.txtPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriod_KeyPress);
            // 
            // txtAmountOfLoan
            // 
            this.txtAmountOfLoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmountOfLoan.BackColor = System.Drawing.Color.White;
            this.txtAmountOfLoan.Location = new System.Drawing.Point(212, 175);
            this.txtAmountOfLoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmountOfLoan.Name = "txtAmountOfLoan";
            this.txtAmountOfLoan.Size = new System.Drawing.Size(126, 25);
            this.txtAmountOfLoan.TabIndex = 1;
            this.txtAmountOfLoan.TextChanged += new System.EventHandler(this.txtAmountOfLoan_TextChanged);
            this.txtAmountOfLoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountOfLoan_KeyPress);
            // 
            // cbxPurpose
            // 
            this.cbxPurpose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxPurpose.BackColor = System.Drawing.Color.White;
            this.cbxPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPurpose.FormattingEnabled = true;
            this.cbxPurpose.Items.AddRange(new object[] {
            "주택구입",
            "내구재구입",
            "생활비",
            "금융투자",
            "결혼자금",
            "사업자금",
            "교육비 기타",
            "대출상환",
            "부동산투자",
            "의료비"});
            this.cbxPurpose.Location = new System.Drawing.Point(212, 389);
            this.cbxPurpose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPurpose.Name = "cbxPurpose";
            this.cbxPurpose.Size = new System.Drawing.Size(146, 23);
            this.cbxPurpose.TabIndex = 4;
            this.cbxPurpose.SelectedIndexChanged += new System.EventHandler(this.cbxPurpose_SelectedIndexChanged);
            // 
            // lblPurpose
            // 
            this.lblPurpose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(87, 389);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(97, 15);
            this.lblPurpose.TabIndex = 3;
            this.lblPurpose.Text = "자금사용목적";
            this.lblPurpose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWhenExpire
            // 
            this.lblWhenExpire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWhenExpire.AutoSize = true;
            this.lblWhenExpire.Location = new System.Drawing.Point(57, 253);
            this.lblWhenExpire.Name = "lblWhenExpire";
            this.lblWhenExpire.Size = new System.Drawing.Size(127, 15);
            this.lblWhenExpire.TabIndex = 2;
            this.lblWhenExpire.Text = "만기일시상환금액";
            this.lblWhenExpire.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWhenExpire.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // lblPeriod
            // 
            this.lblPeriod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(594, 68);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(74, 15);
            this.lblPeriod.TabIndex = 1;
            this.lblPeriod.Text = "*대출기간";
            // 
            // lblAmountOfLoan
            // 
            this.lblAmountOfLoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmountOfLoan.AutoSize = true;
            this.lblAmountOfLoan.Location = new System.Drawing.Point(110, 175);
            this.lblAmountOfLoan.Name = "lblAmountOfLoan";
            this.lblAmountOfLoan.Size = new System.Drawing.Size(74, 15);
            this.lblAmountOfLoan.TabIndex = 0;
            this.lblAmountOfLoan.Text = "*신청금액";
            this.lblAmountOfLoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmApplyingForLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmApplyingForLoan";
            this.Text = "대출 신청";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmApplyingForLoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblAmountOfLoan;
        private System.Windows.Forms.Label lblWhenExpire;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblWon;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.TextBox txtAmountOfLoan;
        private System.Windows.Forms.ComboBox cbxPurpose;
        private System.Windows.Forms.ComboBox cbxPayBackMethod;
        private System.Windows.Forms.Label lblPayBackMethod;
        private System.Windows.Forms.Label lblKindOfLoan2;
        private System.Windows.Forms.Label lblKindOfLoan;
        private System.Windows.Forms.TextBox txtWhenExpire;
        private System.Windows.Forms.Label lblDAccountNum;
        private System.Windows.Forms.ComboBox cbxDepositNum;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtOutPwd;
        private System.Windows.Forms.Label lblOutAccountPwd;
        private System.Windows.Forms.Label lblOutAccount;
        private System.Windows.Forms.TextBox txtRegularWhen;
        private System.Windows.Forms.Label lblRegularWhen;
        private System.Windows.Forms.Label lblWhatisit;
        private System.Windows.Forms.Label lblEveryMonth;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbxOutAccount;
        private CheckControl1 checkControl11;
    }
}