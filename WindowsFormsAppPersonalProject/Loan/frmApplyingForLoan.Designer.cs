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
            this.groupBox1.Size = new System.Drawing.Size(847, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상담정보입력";
            // 
            // cbxOutAccount
            // 
            this.cbxOutAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxOutAccount.BackColor = System.Drawing.Color.White;
            this.cbxOutAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOutAccount.FormattingEnabled = true;
            this.cbxOutAccount.Location = new System.Drawing.Point(595, 84);
            this.cbxOutAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxOutAccount.Name = "cbxOutAccount";
            this.cbxOutAccount.Size = new System.Drawing.Size(176, 20);
            this.cbxOutAccount.TabIndex = 6;
            this.cbxOutAccount.SelectedIndexChanged += new System.EventHandler(this.cbxOutAccount_SelectedIndexChanged);
            // 
            // lblDay
            // 
            this.lblDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(751, 214);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(17, 12);
            this.lblDay.TabIndex = 26;
            this.lblDay.Text = "일";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDay.Visible = false;
            // 
            // lblEveryMonth
            // 
            this.lblEveryMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEveryMonth.AutoSize = true;
            this.lblEveryMonth.Location = new System.Drawing.Point(622, 214);
            this.lblEveryMonth.Name = "lblEveryMonth";
            this.lblEveryMonth.Size = new System.Drawing.Size(29, 12);
            this.lblEveryMonth.TabIndex = 25;
            this.lblEveryMonth.Text = "매월";
            this.lblEveryMonth.Visible = false;
            // 
            // txtRegularWhen
            // 
            this.txtRegularWhen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegularWhen.Location = new System.Drawing.Point(674, 211);
            this.txtRegularWhen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegularWhen.Name = "txtRegularWhen";
            this.txtRegularWhen.Size = new System.Drawing.Size(78, 21);
            this.txtRegularWhen.TabIndex = 8;
            this.txtRegularWhen.Visible = false;
            this.txtRegularWhen.TextChanged += new System.EventHandler(this.txtRegularWhen_TextChanged);
            // 
            // lblRegularWhen
            // 
            this.lblRegularWhen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegularWhen.AutoSize = true;
            this.lblRegularWhen.Location = new System.Drawing.Point(416, 214);
            this.lblRegularWhen.Name = "lblRegularWhen";
            this.lblRegularWhen.Size = new System.Drawing.Size(129, 12);
            this.lblRegularWhen.TabIndex = 24;
            this.lblRegularWhen.Text = "정기 상환 시 상환 날짜";
            this.lblRegularWhen.Visible = false;
            // 
            // lblWhatisit
            // 
            this.lblWhatisit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWhatisit.AutoSize = true;
            this.lblWhatisit.Location = new System.Drawing.Point(416, 181);
            this.lblWhatisit.Name = "lblWhatisit";
            this.lblWhatisit.Size = new System.Drawing.Size(83, 12);
            this.lblWhatisit.TabIndex = 22;
            this.lblWhatisit.Text = "자유적금이란?";
            this.lblWhatisit.Visible = false;
            this.lblWhatisit.MouseEnter += new System.EventHandler(this.lblWhatisit_MouseEnter);
            // 
            // txtOutPwd
            // 
            this.txtOutPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutPwd.BackColor = System.Drawing.Color.White;
            this.txtOutPwd.Location = new System.Drawing.Point(595, 126);
            this.txtOutPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutPwd.Name = "txtOutPwd";
            this.txtOutPwd.Size = new System.Drawing.Size(176, 21);
            this.txtOutPwd.TabIndex = 7;
            this.txtOutPwd.TextChanged += new System.EventHandler(this.txtOutPwd_TextChanged);
            // 
            // lblOutAccountPwd
            // 
            this.lblOutAccountPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutAccountPwd.AutoSize = true;
            this.lblOutAccountPwd.Location = new System.Drawing.Point(416, 126);
            this.lblOutAccountPwd.Name = "lblOutAccountPwd";
            this.lblOutAccountPwd.Size = new System.Drawing.Size(111, 12);
            this.lblOutAccountPwd.TabIndex = 20;
            this.lblOutAccountPwd.Text = "*출금계좌 비밀번호";
            // 
            // lblOutAccount
            // 
            this.lblOutAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutAccount.AutoSize = true;
            this.lblOutAccount.Location = new System.Drawing.Point(416, 86);
            this.lblOutAccount.Name = "lblOutAccount";
            this.lblOutAccount.Size = new System.Drawing.Size(63, 12);
            this.lblOutAccount.TabIndex = 18;
            this.lblOutAccount.Text = "*출금 계좌";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(639, 274);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 42);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.Location = new System.Drawing.Point(416, 274);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(135, 42);
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
            this.cbxDepositNum.Location = new System.Drawing.Point(219, 86);
            this.cbxDepositNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxDepositNum.Name = "cbxDepositNum";
            this.cbxDepositNum.Size = new System.Drawing.Size(128, 20);
            this.cbxDepositNum.TabIndex = 0;
            this.cbxDepositNum.SelectedValueChanged += new System.EventHandler(this.cbxDepositNum_SelectedValueChanged);
            // 
            // lblDAccountNum
            // 
            this.lblDAccountNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDAccountNum.AutoSize = true;
            this.lblDAccountNum.Location = new System.Drawing.Point(44, 86);
            this.lblDAccountNum.Name = "lblDAccountNum";
            this.lblDAccountNum.Size = new System.Drawing.Size(137, 12);
            this.lblDAccountNum.TabIndex = 14;
            this.lblDAccountNum.Text = "담보 제공 예금 계좌번호";
            // 
            // lblKindOfLoan2
            // 
            this.lblKindOfLoan2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindOfLoan2.AutoSize = true;
            this.lblKindOfLoan2.Location = new System.Drawing.Point(216, 41);
            this.lblKindOfLoan2.Name = "lblKindOfLoan2";
            this.lblKindOfLoan2.Size = new System.Drawing.Size(119, 12);
            this.lblKindOfLoan2.TabIndex = 13;
            this.lblKindOfLoan2.Text = "예금(신탁) 담보 대출";
            this.lblKindOfLoan2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKindOfLoan
            // 
            this.lblKindOfLoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKindOfLoan.AutoSize = true;
            this.lblKindOfLoan.Location = new System.Drawing.Point(44, 41);
            this.lblKindOfLoan.Name = "lblKindOfLoan";
            this.lblKindOfLoan.Size = new System.Drawing.Size(61, 12);
            this.lblKindOfLoan.TabIndex = 12;
            this.lblKindOfLoan.Text = "대출 구분 ";
            // 
            // txtWhenExpire
            // 
            this.txtWhenExpire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWhenExpire.BackColor = System.Drawing.Color.White;
            this.txtWhenExpire.Location = new System.Drawing.Point(219, 189);
            this.txtWhenExpire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWhenExpire.Name = "txtWhenExpire";
            this.txtWhenExpire.Size = new System.Drawing.Size(128, 21);
            this.txtWhenExpire.TabIndex = 2;
            this.txtWhenExpire.TextChanged += new System.EventHandler(this.txtWhenExpire_TextChanged);
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
            this.cbxPayBackMethod.Location = new System.Drawing.Point(219, 244);
            this.cbxPayBackMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPayBackMethod.Name = "cbxPayBackMethod";
            this.cbxPayBackMethod.Size = new System.Drawing.Size(128, 20);
            this.cbxPayBackMethod.TabIndex = 3;
            this.cbxPayBackMethod.SelectedIndexChanged += new System.EventHandler(this.cbxPayBackMethod_SelectedIndexChanged);
            this.cbxPayBackMethod.SelectedValueChanged += new System.EventHandler(this.cbxPayBackMethod_SelectedValueChanged);
            // 
            // lblPayBackMethod
            // 
            this.lblPayBackMethod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPayBackMethod.AutoSize = true;
            this.lblPayBackMethod.Location = new System.Drawing.Point(44, 244);
            this.lblPayBackMethod.Name = "lblPayBackMethod";
            this.lblPayBackMethod.Size = new System.Drawing.Size(95, 12);
            this.lblPayBackMethod.TabIndex = 9;
            this.lblPayBackMethod.Text = "*대출금상환방법";
            // 
            // lblMonth
            // 
            this.lblMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(738, 41);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(29, 12);
            this.lblMonth.TabIndex = 8;
            this.lblMonth.Text = "개월";
            // 
            // lblWon
            // 
            this.lblWon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWon.AutoSize = true;
            this.lblWon.Location = new System.Drawing.Point(332, 131);
            this.lblWon.Name = "lblWon";
            this.lblWon.Size = new System.Drawing.Size(17, 12);
            this.lblWon.TabIndex = 7;
            this.lblWon.Text = "원";
            this.lblWon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPeriod.BackColor = System.Drawing.Color.White;
            this.txtPeriod.Location = new System.Drawing.Point(595, 41);
            this.txtPeriod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(138, 21);
            this.txtPeriod.TabIndex = 5;
            this.txtPeriod.TextChanged += new System.EventHandler(this.txtPeriod_TextChanged);
            // 
            // txtAmountOfLoan
            // 
            this.txtAmountOfLoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmountOfLoan.BackColor = System.Drawing.Color.White;
            this.txtAmountOfLoan.Location = new System.Drawing.Point(219, 126);
            this.txtAmountOfLoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmountOfLoan.Name = "txtAmountOfLoan";
            this.txtAmountOfLoan.Size = new System.Drawing.Size(111, 21);
            this.txtAmountOfLoan.TabIndex = 1;
            this.txtAmountOfLoan.TextChanged += new System.EventHandler(this.txtAmountOfLoan_TextChanged);
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
            this.cbxPurpose.Location = new System.Drawing.Point(219, 298);
            this.cbxPurpose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPurpose.Name = "cbxPurpose";
            this.cbxPurpose.Size = new System.Drawing.Size(128, 20);
            this.cbxPurpose.TabIndex = 4;
            this.cbxPurpose.SelectedIndexChanged += new System.EventHandler(this.cbxPurpose_SelectedIndexChanged);
            // 
            // lblPurpose
            // 
            this.lblPurpose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(44, 298);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(77, 12);
            this.lblPurpose.TabIndex = 3;
            this.lblPurpose.Text = "자금사용목적";
            // 
            // lblWhenExpire
            // 
            this.lblWhenExpire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWhenExpire.AutoSize = true;
            this.lblWhenExpire.Location = new System.Drawing.Point(44, 189);
            this.lblWhenExpire.Name = "lblWhenExpire";
            this.lblWhenExpire.Size = new System.Drawing.Size(101, 12);
            this.lblWhenExpire.TabIndex = 2;
            this.lblWhenExpire.Text = "만기일시상환금액";
            this.lblWhenExpire.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // lblPeriod
            // 
            this.lblPeriod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(416, 41);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(59, 12);
            this.lblPeriod.TabIndex = 1;
            this.lblPeriod.Text = "*대출기간";
            // 
            // lblAmountOfLoan
            // 
            this.lblAmountOfLoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmountOfLoan.AutoSize = true;
            this.lblAmountOfLoan.Location = new System.Drawing.Point(44, 126);
            this.lblAmountOfLoan.Name = "lblAmountOfLoan";
            this.lblAmountOfLoan.Size = new System.Drawing.Size(59, 12);
            this.lblAmountOfLoan.TabIndex = 0;
            this.lblAmountOfLoan.Text = "*신청금액";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmApplyingForLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 360);
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
    }
}