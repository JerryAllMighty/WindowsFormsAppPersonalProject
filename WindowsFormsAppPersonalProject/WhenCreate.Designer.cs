﻿namespace WindowsFormsAppPersonalProject
{
    partial class WhenCreate
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lbltxtID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbltxtAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbltxtPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbltxtPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lbltxtName = new System.Windows.Forms.Label();
            this.gBoxKindOfAccount = new System.Windows.Forms.GroupBox();
            this.rbtnA = new System.Windows.Forms.RadioButton();
            this.rbtnS = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.gBoxKindOfAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(197, 48);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 25);
            this.txtName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gBoxKindOfAccount);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.lbltxtID);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lbltxtAddress);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.lbltxtPhone);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.lbltxtPwd);
            this.panel1.Controls.Add(this.txtPwd);
            this.panel1.Controls.Add(this.lbltxtName);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(12, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 532);
            this.panel1.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(309, 449);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(143, 80);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "등록";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lbltxtID
            // 
            this.lbltxtID.Location = new System.Drawing.Point(32, 219);
            this.lbltxtID.Name = "lbltxtID";
            this.lbltxtID.Size = new System.Drawing.Size(114, 29);
            this.lbltxtID.TabIndex = 9;
            this.lbltxtID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(197, 215);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(254, 25);
            this.txtID.TabIndex = 3;
            // 
            // lbltxtAddress
            // 
            this.lbltxtAddress.Location = new System.Drawing.Point(32, 135);
            this.lbltxtAddress.Name = "lbltxtAddress";
            this.lbltxtAddress.Size = new System.Drawing.Size(114, 29);
            this.lbltxtAddress.TabIndex = 0;
            this.lbltxtAddress.Text = "주소";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(197, 131);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(254, 25);
            this.txtAddress.TabIndex = 2;
            // 
            // lbltxtPhone
            // 
            this.lbltxtPhone.Location = new System.Drawing.Point(32, 386);
            this.lbltxtPhone.Name = "lbltxtPhone";
            this.lbltxtPhone.Size = new System.Drawing.Size(114, 29);
            this.lbltxtPhone.TabIndex = 5;
            this.lbltxtPhone.Text = "연락처";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(197, 382);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(254, 25);
            this.txtPhone.TabIndex = 5;
            // 
            // lbltxtPwd
            // 
            this.lbltxtPwd.Location = new System.Drawing.Point(32, 302);
            this.lbltxtPwd.Name = "lbltxtPwd";
            this.lbltxtPwd.Size = new System.Drawing.Size(114, 29);
            this.lbltxtPwd.TabIndex = 3;
            this.lbltxtPwd.Text = "비밀번호";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(197, 299);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(254, 25);
            this.txtPwd.TabIndex = 4;
            // 
            // lbltxtName
            // 
            this.lbltxtName.Location = new System.Drawing.Point(32, 51);
            this.lbltxtName.Name = "lbltxtName";
            this.lbltxtName.Size = new System.Drawing.Size(114, 29);
            this.lbltxtName.TabIndex = 1;
            this.lbltxtName.Text = "이름";
            // 
            // gBoxKindOfAccount
            // 
            this.gBoxKindOfAccount.Controls.Add(this.rbtnS);
            this.gBoxKindOfAccount.Controls.Add(this.rbtnA);
            this.gBoxKindOfAccount.Location = new System.Drawing.Point(39, 440);
            this.gBoxKindOfAccount.Name = "gBoxKindOfAccount";
            this.gBoxKindOfAccount.Size = new System.Drawing.Size(223, 79);
            this.gBoxKindOfAccount.TabIndex = 10;
            this.gBoxKindOfAccount.TabStop = false;
            this.gBoxKindOfAccount.Text = "계정의 종류";
            // 
            // rbtnA
            // 
            this.rbtnA.AutoSize = true;
            this.rbtnA.Location = new System.Drawing.Point(7, 42);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(88, 19);
            this.rbtnA.TabIndex = 0;
            this.rbtnA.TabStop = true;
            this.rbtnA.Text = "관리자용";
            this.rbtnA.UseVisualStyleBackColor = true;
            this.rbtnA.CheckedChanged += new System.EventHandler(this.rbtnA_CheckedChanged);
            // 
            // rbtnS
            // 
            this.rbtnS.AutoSize = true;
            this.rbtnS.Location = new System.Drawing.Point(119, 40);
            this.rbtnS.Name = "rbtnS";
            this.rbtnS.Size = new System.Drawing.Size(73, 19);
            this.rbtnS.TabIndex = 1;
            this.rbtnS.TabStop = true;
            this.rbtnS.Text = "회원용";
            this.rbtnS.UseVisualStyleBackColor = true;
            this.rbtnS.CheckedChanged += new System.EventHandler(this.rbtnS_CheckedChanged);
            // 
            // WhenCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 562);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WhenCreate";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "WhenCreate";
            this.Load += new System.EventHandler(this.WhenCreate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBoxKindOfAccount.ResumeLayout(false);
            this.gBoxKindOfAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltxtName;
        private System.Windows.Forms.Label lbltxtID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbltxtAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbltxtPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbltxtPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox gBoxKindOfAccount;
        private System.Windows.Forms.RadioButton rbtnS;
        private System.Windows.Forms.RadioButton rbtnA;
    }
}