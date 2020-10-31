namespace WindowsFormsAppPersonalProject
{
    partial class frmUpdate
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCheckPw = new System.Windows.Forms.Label();
            this.txtCheckingPwd = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gBoxKindOfAccount = new System.Windows.Forms.GroupBox();
            this.rbtnS = new System.Windows.Forms.RadioButton();
            this.rbtnA = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gBoxKindOfAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblCheckPw
            // 
            this.lblCheckPw.Location = new System.Drawing.Point(32, 316);
            this.lblCheckPw.Name = "lblCheckPw";
            this.lblCheckPw.Size = new System.Drawing.Size(114, 29);
            this.lblCheckPw.TabIndex = 11;
            this.lblCheckPw.Text = "비밀번호확인";
            // 
            // txtCheckingPwd
            // 
            this.txtCheckingPwd.Location = new System.Drawing.Point(197, 312);
            this.txtCheckingPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCheckingPwd.Name = "txtCheckingPwd";
            this.txtCheckingPwd.PasswordChar = '*';
            this.txtCheckingPwd.Size = new System.Drawing.Size(254, 25);
            this.txtCheckingPwd.TabIndex = 5;
            this.txtCheckingPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(308, 444);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 80);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "변경";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(32, 184);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(114, 29);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gBoxKindOfAccount);
            this.panel1.Controls.Add(this.lblCheckPw);
            this.panel1.Controls.Add(this.txtCheckingPwd);
            this.panel1.Controls.Add(this.btnUpdate);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 548);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // gBoxKindOfAccount
            // 
            this.gBoxKindOfAccount.Controls.Add(this.rbtnS);
            this.gBoxKindOfAccount.Controls.Add(this.rbtnA);
            this.gBoxKindOfAccount.Location = new System.Drawing.Point(35, 444);
            this.gBoxKindOfAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBoxKindOfAccount.Name = "gBoxKindOfAccount";
            this.gBoxKindOfAccount.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBoxKindOfAccount.Size = new System.Drawing.Size(223, 79);
            this.gBoxKindOfAccount.TabIndex = 12;
            this.gBoxKindOfAccount.TabStop = false;
            this.gBoxKindOfAccount.Text = "계정의 종류";
            // 
            // rbtnS
            // 
            this.rbtnS.AutoSize = true;
            this.rbtnS.Location = new System.Drawing.Point(119, 40);
            this.rbtnS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnS.Name = "rbtnS";
            this.rbtnS.Size = new System.Drawing.Size(73, 19);
            this.rbtnS.TabIndex = 9;
            this.rbtnS.TabStop = true;
            this.rbtnS.Text = "회원용";
            this.rbtnS.UseVisualStyleBackColor = true;
            // 
            // rbtnA
            // 
            this.rbtnA.AutoSize = true;
            this.rbtnA.Location = new System.Drawing.Point(7, 42);
            this.rbtnA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(88, 19);
            this.rbtnA.TabIndex = 8;
            this.rbtnA.TabStop = true;
            this.rbtnA.Text = "관리자용";
            this.rbtnA.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(197, 180);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(254, 25);
            this.txtID.TabIndex = 3;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(32, 118);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(114, 29);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "주소";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(197, 114);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(254, 25);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(32, 382);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(114, 29);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "연락처";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(197, 379);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(254, 25);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // lblPwd
            // 
            this.lblPwd.Location = new System.Drawing.Point(32, 250);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(114, 29);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "비밀번호";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(197, 246);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(254, 25);
            this.txtPwd.TabIndex = 4;
            this.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPwd.Leave += new System.EventHandler(this.txtPwd_Leave);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(32, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(114, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "이름";
            // 
            // txtName
            // 
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtName.Location = new System.Drawing.Point(197, 48);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 25);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 548);
            this.Controls.Add(this.panel1);
            this.Name = "frmUpdate";
            this.Text = "고객 정보 수정";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBoxKindOfAccount.ResumeLayout(false);
            this.gBoxKindOfAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCheckPw;
        private System.Windows.Forms.TextBox txtCheckingPwd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gBoxKindOfAccount;
        private System.Windows.Forms.RadioButton rbtnS;
        private System.Windows.Forms.RadioButton rbtnA;
    }
}