﻿namespace WindowsFormsAppPersonalProject
{
    partial class NewAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            this.gbxNewAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 518);
            this.panel1.TabIndex = 1;
            // 
            // gbxNewAccount
            // 
            this.gbxNewAccount.Controls.Add(this.lblCheckNewPwd);
            this.gbxNewAccount.Controls.Add(this.txtCheckNewPwd);
            this.gbxNewAccount.Controls.Add(this.lblNewPwd);
            this.gbxNewAccount.Controls.Add(this.txtNewPwd);
            this.gbxNewAccount.Location = new System.Drawing.Point(518, 215);
            this.gbxNewAccount.Name = "gbxNewAccount";
            this.gbxNewAccount.Size = new System.Drawing.Size(538, 200);
            this.gbxNewAccount.TabIndex = 13;
            this.gbxNewAccount.TabStop = false;
            this.gbxNewAccount.Text = "신규 계좌 비밀번호 생성";
            // 
            // lblCheckNewPwd
            // 
            this.lblCheckNewPwd.Location = new System.Drawing.Point(3, 174);
            this.lblCheckNewPwd.Name = "lblCheckNewPwd";
            this.lblCheckNewPwd.Size = new System.Drawing.Size(114, 29);
            this.lblCheckNewPwd.TabIndex = 7;
            this.lblCheckNewPwd.Text = "비밀번호 확인";
            // 
            // txtCheckNewPwd
            // 
            this.txtCheckNewPwd.Location = new System.Drawing.Point(168, 171);
            this.txtCheckNewPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCheckNewPwd.Name = "txtCheckNewPwd";
            this.txtCheckNewPwd.Size = new System.Drawing.Size(254, 25);
            this.txtCheckNewPwd.TabIndex = 8;
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.Location = new System.Drawing.Point(3, 78);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(114, 29);
            this.lblNewPwd.TabIndex = 5;
            this.lblNewPwd.Text = "비밀번호";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(168, 75);
            this.txtNewPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(254, 25);
            this.txtNewPwd.TabIndex = 6;
            // 
            // cbxduration
            // 
            this.cbxduration.FormattingEnabled = true;
            this.cbxduration.Items.AddRange(new object[] {
            "1개월",
            "3개월",
            "6개월",
            "12개월",
            "24개월"});
            this.cbxduration.Location = new System.Drawing.Point(197, 135);
            this.cbxduration.Name = "cbxduration";
            this.cbxduration.Size = new System.Drawing.Size(254, 23);
            this.cbxduration.TabIndex = 12;
            // 
            // cbxKindOfAccount
            // 
            this.cbxKindOfAccount.FormattingEnabled = true;
            this.cbxKindOfAccount.Items.AddRange(new object[] {
            "적금 계좌",
            "예금 계좌",
            "일반 계좌"});
            this.cbxKindOfAccount.Location = new System.Drawing.Point(197, 51);
            this.cbxKindOfAccount.Name = "cbxKindOfAccount";
            this.cbxKindOfAccount.Size = new System.Drawing.Size(254, 23);
            this.cbxKindOfAccount.TabIndex = 11;
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Location = new System.Drawing.Point(518, 51);
            this.btnNewAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(143, 80);
            this.btnNewAccount.TabIndex = 6;
            this.btnNewAccount.Text = "계좌 생성";
            this.btnNewAccount.UseVisualStyleBackColor = true;
            // 
            // lblpayPerMonth
            // 
            this.lblpayPerMonth.Location = new System.Drawing.Point(32, 219);
            this.lblpayPerMonth.Name = "lblpayPerMonth";
            this.lblpayPerMonth.Size = new System.Drawing.Size(114, 29);
            this.lblpayPerMonth.TabIndex = 9;
            this.lblpayPerMonth.Text = "매회 납입 금액";
            this.lblpayPerMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpayPerMonth
            // 
            this.txtpayPerMonth.Location = new System.Drawing.Point(197, 215);
            this.txtpayPerMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpayPerMonth.Name = "txtpayPerMonth";
            this.txtpayPerMonth.Size = new System.Drawing.Size(254, 25);
            this.txtpayPerMonth.TabIndex = 3;
            // 
            // lblduration
            // 
            this.lblduration.Location = new System.Drawing.Point(32, 135);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(114, 29);
            this.lblduration.TabIndex = 0;
            this.lblduration.Text = "가입기간";
            this.lblduration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutAccount
            // 
            this.lblOutAccount.Location = new System.Drawing.Point(32, 293);
            this.lblOutAccount.Name = "lblOutAccount";
            this.lblOutAccount.Size = new System.Drawing.Size(114, 29);
            this.lblOutAccount.TabIndex = 5;
            this.lblOutAccount.Text = "출금계좌";
            this.lblOutAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOutAccount
            // 
            this.txtOutAccount.Location = new System.Drawing.Point(197, 289);
            this.txtOutAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutAccount.Name = "txtOutAccount";
            this.txtOutAccount.Size = new System.Drawing.Size(254, 25);
            this.txtOutAccount.TabIndex = 5;
            // 
            // lblOutPwd
            // 
            this.lblOutPwd.Location = new System.Drawing.Point(32, 386);
            this.lblOutPwd.Name = "lblOutPwd";
            this.lblOutPwd.Size = new System.Drawing.Size(114, 29);
            this.lblOutPwd.TabIndex = 3;
            this.lblOutPwd.Text = "출금 계좌 비밀번호";
            this.lblOutPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOutPwd
            // 
            this.txtOutPwd.Location = new System.Drawing.Point(197, 383);
            this.txtOutPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutPwd.Name = "txtOutPwd";
            this.txtOutPwd.Size = new System.Drawing.Size(254, 25);
            this.txtOutPwd.TabIndex = 4;
            // 
            // lbltxtKindOfAccount
            // 
            this.lbltxtKindOfAccount.Location = new System.Drawing.Point(32, 51);
            this.lbltxtKindOfAccount.Name = "lbltxtKindOfAccount";
            this.lbltxtKindOfAccount.Size = new System.Drawing.Size(114, 29);
            this.lbltxtKindOfAccount.TabIndex = 1;
            this.lbltxtKindOfAccount.Text = "계좌종류";
            this.lbltxtKindOfAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 534);
            this.Controls.Add(this.panel1);
            this.Name = "NewAccount";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "NewAccount";
            this.Load += new System.EventHandler(this.NewAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxNewAccount.ResumeLayout(false);
            this.gbxNewAccount.PerformLayout();
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
    }
}