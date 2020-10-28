namespace WindowsFormsAppPersonalProject
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
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCheckPw = new System.Windows.Forms.Label();
            this.txtCheckingPwd = new System.Windows.Forms.TextBox();
            this.gBoxKindOfAccount = new System.Windows.Forms.GroupBox();
            this.rbtnS = new System.Windows.Forms.RadioButton();
            this.rbtnA = new System.Windows.Forms.RadioButton();
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
            this.panel1.SuspendLayout();
            this.gBoxKindOfAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(172, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 21);
            this.txtName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCheckPw);
            this.panel1.Controls.Add(this.txtCheckingPwd);
            this.panel1.Controls.Add(this.gBoxKindOfAccount);
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
            this.panel1.Location = new System.Drawing.Point(10, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 502);
            this.panel1.TabIndex = 0;
            // 
            // lblCheckPw
            // 
            this.lblCheckPw.Location = new System.Drawing.Point(28, 253);
            this.lblCheckPw.Name = "lblCheckPw";
            this.lblCheckPw.Size = new System.Drawing.Size(100, 23);
            this.lblCheckPw.TabIndex = 11;
            this.lblCheckPw.Text = "비밀번호확인";
            // 
            // txtCheckingPwd
            // 
            this.txtCheckingPwd.Location = new System.Drawing.Point(172, 250);
            this.txtCheckingPwd.Name = "txtCheckingPwd";
            this.txtCheckingPwd.PasswordChar = '*';
            this.txtCheckingPwd.Size = new System.Drawing.Size(223, 21);
            this.txtCheckingPwd.TabIndex = 12;
            this.txtCheckingPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheckingPwd_KeyPress);
            // 
            // gBoxKindOfAccount
            // 
            this.gBoxKindOfAccount.Controls.Add(this.rbtnS);
            this.gBoxKindOfAccount.Controls.Add(this.rbtnA);
            this.gBoxKindOfAccount.Location = new System.Drawing.Point(30, 421);
            this.gBoxKindOfAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBoxKindOfAccount.Name = "gBoxKindOfAccount";
            this.gBoxKindOfAccount.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBoxKindOfAccount.Size = new System.Drawing.Size(195, 63);
            this.gBoxKindOfAccount.TabIndex = 10;
            this.gBoxKindOfAccount.TabStop = false;
            this.gBoxKindOfAccount.Text = "계정의 종류";
            // 
            // rbtnS
            // 
            this.rbtnS.AutoSize = true;
            this.rbtnS.Location = new System.Drawing.Point(104, 32);
            this.rbtnS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnS.Name = "rbtnS";
            this.rbtnS.Size = new System.Drawing.Size(59, 16);
            this.rbtnS.TabIndex = 1;
            this.rbtnS.TabStop = true;
            this.rbtnS.Text = "회원용";
            this.rbtnS.UseVisualStyleBackColor = true;
            this.rbtnS.CheckedChanged += new System.EventHandler(this.rbtnS_CheckedChanged);
            // 
            // rbtnA
            // 
            this.rbtnA.AutoSize = true;
            this.rbtnA.Location = new System.Drawing.Point(6, 34);
            this.rbtnA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(71, 16);
            this.rbtnA.TabIndex = 0;
            this.rbtnA.TabStop = true;
            this.rbtnA.Text = "관리자용";
            this.rbtnA.UseVisualStyleBackColor = true;
            this.rbtnA.CheckedChanged += new System.EventHandler(this.rbtnA_CheckedChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(270, 420);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(125, 64);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "등록";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(28, 147);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 23);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(172, 144);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(223, 21);
            this.txtID.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(28, 94);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "주소";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(172, 91);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(223, 21);
            this.txtAddress.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(28, 306);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 23);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "연락처";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(172, 303);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(223, 21);
            this.txtPhone.TabIndex = 5;
            // 
            // lblPwd
            // 
            this.lblPwd.Location = new System.Drawing.Point(28, 200);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(100, 23);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "비밀번호";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(172, 197);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(223, 21);
            this.txtPwd.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(28, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "이름";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // WhenCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 528);
            this.Controls.Add(this.panel1);
            this.Name = "WhenCreate";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "WhenCreate";
            this.Load += new System.EventHandler(this.WhenCreate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBoxKindOfAccount.ResumeLayout(false);
            this.gBoxKindOfAccount.PerformLayout();
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
        private System.Windows.Forms.GroupBox gBoxKindOfAccount;
        private System.Windows.Forms.RadioButton rbtnS;
        private System.Windows.Forms.RadioButton rbtnA;
        private System.Windows.Forms.Label lblCheckPw;
        private System.Windows.Forms.TextBox txtCheckingPwd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}