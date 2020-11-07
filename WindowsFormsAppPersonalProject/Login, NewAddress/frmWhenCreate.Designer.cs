namespace WindowsFormsAppPersonalProject
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddSearch = new System.Windows.Forms.Button();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.cbxEmail = new System.Windows.Forms.ComboBox();
            this.lblSearchPwQA = new System.Windows.Forms.Label();
            this.txtSearchPwAns = new System.Windows.Forms.TextBox();
            this.cbxSeacrchPw = new System.Windows.Forms.ComboBox();
            this.lblCheckEmail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtName.Location = new System.Drawing.Point(327, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCheckEmail);
            this.panel1.Controls.Add(this.cbxSeacrchPw);
            this.panel1.Controls.Add(this.txtSearchPwAns);
            this.panel1.Controls.Add(this.lblSearchPwQA);
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
            this.panel1.TabStop = true;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(227, 161);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 21);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "이메일";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(327, 161);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 22);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(729, 281);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(152, 22);
            this.btnCheck.TabIndex = 12;
            this.btnCheck.Text = "ID 중복확인";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblCheckPw
            // 
            this.lblCheckPw.Location = new System.Drawing.Point(183, 401);
            this.lblCheckPw.Name = "lblCheckPw";
            this.lblCheckPw.Size = new System.Drawing.Size(94, 21);
            this.lblCheckPw.TabIndex = 11;
            this.lblCheckPw.Text = "비밀번호확인";
            this.lblCheckPw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCheckingPwd
            // 
            this.txtCheckingPwd.Location = new System.Drawing.Point(327, 401);
            this.txtCheckingPwd.Name = "txtCheckingPwd";
            this.txtCheckingPwd.PasswordChar = '*';
            this.txtCheckingPwd.Size = new System.Drawing.Size(254, 22);
            this.txtCheckingPwd.TabIndex = 5;
            this.txtCheckingPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCheckingPwd.TextChanged += new System.EventHandler(this.txtCheckingPwd_TextChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(776, 471);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(143, 69);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "등록";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(230, 281);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(47, 21);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(327, 281);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(254, 22);
            this.txtID.TabIndex = 3;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(227, 221);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(50, 21);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "주소";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(327, 221);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(254, 22);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(224, 103);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 21);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "연락처";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(327, 103);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(254, 22);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPwd
            // 
            this.lblPwd.Location = new System.Drawing.Point(214, 341);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(63, 21);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "비밀번호";
            this.lblPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(327, 341);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(254, 22);
            this.txtPwd.TabIndex = 4;
            this.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(227, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "이름";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 166);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddSearch
            // 
            this.btnAddSearch.Location = new System.Drawing.Point(729, 221);
            this.btnAddSearch.Name = "btnAddSearch";
            this.btnAddSearch.Size = new System.Drawing.Size(152, 22);
            this.btnAddSearch.TabIndex = 17;
            this.btnAddSearch.Text = "주소 찾기";
            this.btnAddSearch.UseVisualStyleBackColor = true;
            this.btnAddSearch.Click += new System.EventHandler(this.btnAddSearch_Click);
            // 
            // btnAddPic
            // 
            this.btnAddPic.Location = new System.Drawing.Point(28, 221);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(152, 22);
            this.btnAddPic.TabIndex = 18;
            this.btnAddPic.Text = "사진 추가";
            this.btnAddPic.UseVisualStyleBackColor = true;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // cbxEmail
            // 
            this.cbxEmail.FormattingEnabled = true;
            this.cbxEmail.Location = new System.Drawing.Point(627, 162);
            this.cbxEmail.Name = "cbxEmail";
            this.cbxEmail.Size = new System.Drawing.Size(254, 21);
            this.cbxEmail.TabIndex = 19;
            // 
            // lblSearchPwQA
            // 
            this.lblSearchPwQA.Location = new System.Drawing.Point(177, 465);
            this.lblSearchPwQA.Name = "lblSearchPwQA";
            this.lblSearchPwQA.Size = new System.Drawing.Size(100, 38);
            this.lblSearchPwQA.TabIndex = 21;
            this.lblSearchPwQA.Text = "비밀번호 찾기 질문/답변";
            this.lblSearchPwQA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSearchPwAns
            // 
            this.txtSearchPwAns.Location = new System.Drawing.Point(327, 506);
            this.txtSearchPwAns.Name = "txtSearchPwAns";
            this.txtSearchPwAns.PasswordChar = '*';
            this.txtSearchPwAns.Size = new System.Drawing.Size(254, 22);
            this.txtSearchPwAns.TabIndex = 22;
            this.txtSearchPwAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxSeacrchPw
            // 
            this.cbxSeacrchPw.FormattingEnabled = true;
            this.cbxSeacrchPw.Location = new System.Drawing.Point(327, 465);
            this.cbxSeacrchPw.Name = "cbxSeacrchPw";
            this.cbxSeacrchPw.Size = new System.Drawing.Size(254, 21);
            this.cbxSeacrchPw.TabIndex = 23;
            // 
            // lblCheckEmail
            // 
            this.lblCheckEmail.Location = new System.Drawing.Point(324, 186);
            this.lblCheckEmail.Name = "lblCheckEmail";
            this.lblCheckEmail.Size = new System.Drawing.Size(257, 21);
            this.lblCheckEmail.TabIndex = 24;
            this.lblCheckEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCheckEmail.Visible = false;
            // 
            // frmWhenCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 572);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "frmWhenCreate";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.WhenCreate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lblSearchPwQA;
        private System.Windows.Forms.ComboBox cbxSeacrchPw;
        private System.Windows.Forms.TextBox txtSearchPwAns;
        private System.Windows.Forms.Label lblCheckEmail;
    }
}