﻿namespace WindowsFormsAppPersonalProject
{
    partial class frmWhenCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWhenCreate));
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddrDetail = new System.Windows.Forms.Label();
            this.txtAddrDetail = new System.Windows.Forms.TextBox();
            this.txtZipNo = new System.Windows.Forms.TextBox();
            this.lblCheckEmail = new System.Windows.Forms.Label();
            this.cbxEmail = new System.Windows.Forms.ComboBox();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.btnAddSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblCheckPw = new System.Windows.Forms.Label();
            this.txtCheckingPwd = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.numberOnly1 = new WindowsFormsAppPersonalProject.NumberOnly();
            this.checkControl11 = new WindowsFormsAppPersonalProject.CheckControl1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtName.Location = new System.Drawing.Point(330, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 22);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblAddrDetail);
            this.panel1.Controls.Add(this.txtAddrDetail);
            this.panel1.Controls.Add(this.txtZipNo);
            this.panel1.Controls.Add(this.numberOnly1);
            this.panel1.Controls.Add(this.checkControl11);
            this.panel1.Controls.Add(this.lblCheckEmail);
            this.panel1.Controls.Add(this.cbxEmail);
            this.panel1.Controls.Add(this.btnAddPic);
            this.panel1.Controls.Add(this.btnAddSearch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.lblCheckPw);
            this.panel1.Controls.Add(this.txtCheckingPwd);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.lblPwd);
            this.panel1.Controls.Add(this.txtPwd);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(11, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 544);
            this.panel1.TabIndex = 0;
            // 
            // lblAddrDetail
            // 
            this.lblAddrDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddrDetail.Location = new System.Drawing.Point(205, 284);
            this.lblAddrDetail.Name = "lblAddrDetail";
            this.lblAddrDetail.Size = new System.Drawing.Size(78, 21);
            this.lblAddrDetail.TabIndex = 29;
            this.lblAddrDetail.Text = "*상세 주소";
            this.lblAddrDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddrDetail
            // 
            this.txtAddrDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddrDetail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAddrDetail.Location = new System.Drawing.Point(330, 283);
            this.txtAddrDetail.Name = "txtAddrDetail";
            this.txtAddrDetail.Size = new System.Drawing.Size(254, 22);
            this.txtAddrDetail.TabIndex = 6;
            this.txtAddrDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtZipNo
            // 
            this.txtZipNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtZipNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtZipNo.Location = new System.Drawing.Point(330, 219);
            this.txtZipNo.Name = "txtZipNo";
            this.txtZipNo.Size = new System.Drawing.Size(134, 22);
            this.txtZipNo.TabIndex = 4;
            this.txtZipNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtZipNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZipNo_KeyPress);
            // 
            // lblCheckEmail
            // 
            this.lblCheckEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCheckEmail.Location = new System.Drawing.Point(330, 181);
            this.lblCheckEmail.Name = "lblCheckEmail";
            this.lblCheckEmail.Size = new System.Drawing.Size(254, 21);
            this.lblCheckEmail.TabIndex = 24;
            this.lblCheckEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCheckEmail.Visible = false;
            // 
            // cbxEmail
            // 
            this.cbxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxEmail.FormattingEnabled = true;
            this.cbxEmail.Items.AddRange(new object[] {
            "@naver.com",
            "@gmail.com",
            "@live.com",
            "@hotmail.com",
            "@yahoo.com",
            "@yahoo.co.kr",
            "@hanmail.net",
            "@daum.net",
            "@aol.com",
            "@paran.com",
            "@hanmir.com",
            "@hitel.com",
            "@dreamwiz.com",
            "@nate.com",
            "@empal.com"});
            this.cbxEmail.Location = new System.Drawing.Point(625, 157);
            this.cbxEmail.Name = "cbxEmail";
            this.cbxEmail.Size = new System.Drawing.Size(254, 21);
            this.cbxEmail.TabIndex = 3;
            this.cbxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxEmail_KeyPress);
            // 
            // btnAddPic
            // 
            this.btnAddPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPic.Location = new System.Drawing.Point(12, 219);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(166, 46);
            this.btnAddPic.TabIndex = 18;
            this.btnAddPic.TabStop = false;
            this.btnAddPic.Text = "사진 추가";
            this.btnAddPic.UseVisualStyleBackColor = true;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // btnAddSearch
            // 
            this.btnAddSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddSearch.Location = new System.Drawing.Point(727, 219);
            this.btnAddSearch.Name = "btnAddSearch";
            this.btnAddSearch.Size = new System.Drawing.Size(152, 22);
            this.btnAddSearch.TabIndex = 7;
            this.btnAddSearch.Text = "주소 찾기";
            this.btnAddSearch.UseVisualStyleBackColor = true;
            this.btnAddSearch.Click += new System.EventHandler(this.btnAddSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 166);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.Location = new System.Drawing.Point(214, 157);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 21);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "*이메일";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmail.Location = new System.Drawing.Point(330, 156);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 22);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheck.Location = new System.Drawing.Point(727, 352);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(152, 22);
            this.btnCheck.TabIndex = 9;
            this.btnCheck.Text = "ID 중복확인";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblCheckPw
            // 
            this.lblCheckPw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckPw.Location = new System.Drawing.Point(180, 488);
            this.lblCheckPw.Name = "lblCheckPw";
            this.lblCheckPw.Size = new System.Drawing.Size(103, 21);
            this.lblCheckPw.TabIndex = 11;
            this.lblCheckPw.Text = "*비밀번호확인";
            this.lblCheckPw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCheckingPwd
            // 
            this.txtCheckingPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCheckingPwd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCheckingPwd.Location = new System.Drawing.Point(330, 487);
            this.txtCheckingPwd.Name = "txtCheckingPwd";
            this.txtCheckingPwd.PasswordChar = '*';
            this.txtCheckingPwd.Size = new System.Drawing.Size(254, 22);
            this.txtCheckingPwd.TabIndex = 11;
            this.txtCheckingPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCheckingPwd.TextChanged += new System.EventHandler(this.txtCheckingPwd_TextChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsert.Location = new System.Drawing.Point(736, 440);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(143, 69);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "등록";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.Location = new System.Drawing.Point(233, 352);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(47, 21);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "*ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtID.Location = new System.Drawing.Point(333, 351);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(254, 22);
            this.txtID.TabIndex = 8;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddress.Location = new System.Drawing.Point(230, 220);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(50, 21);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "*주소";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAddress.Location = new System.Drawing.Point(330, 251);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(254, 22);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhone.Location = new System.Drawing.Point(217, 80);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(63, 21);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "*연락처";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPhone.Location = new System.Drawing.Point(330, 80);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(254, 22);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // lblPwd
            // 
            this.lblPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPwd.Location = new System.Drawing.Point(202, 420);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(78, 21);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "*비밀번호";
            this.lblPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPwd
            // 
            this.txtPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPwd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPwd.Location = new System.Drawing.Point(333, 419);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(254, 22);
            this.txtPwd.TabIndex = 10;
            this.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Location = new System.Drawing.Point(230, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "*이름";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // numberOnly1
            // 
            this.numberOnly1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberOnly1.Location = new System.Drawing.Point(319, 109);
            this.numberOnly1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberOnly1.Name = "numberOnly1";
            this.numberOnly1.Size = new System.Drawing.Size(270, 22);
            this.numberOnly1.TabIndex = 26;
            // 
            // checkControl11
            // 
            this.checkControl11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkControl11.Location = new System.Drawing.Point(625, 12);
            this.checkControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkControl11.Name = "checkControl11";
            this.checkControl11.Size = new System.Drawing.Size(216, 20);
            this.checkControl11.TabIndex = 25;
            this.checkControl11.TabStop = false;
            // 
            // frmWhenCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 572);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWhenCreate";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.WhenCreate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblCheckPw;
        private System.Windows.Forms.TextBox txtCheckingPwd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAddSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.ComboBox cbxEmail;
        private System.Windows.Forms.Label lblCheckEmail;
        private CheckControl1 checkControl11;
        private NumberOnly numberOnly1;
        private System.Windows.Forms.TextBox txtAddrDetail;
        private System.Windows.Forms.TextBox txtZipNo;
        private System.Windows.Forms.Label lblAddrDetail;
    }
}