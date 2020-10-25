namespace WindowsFormsAppPersonalProject
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
            this.gBoxKindOfAccount = new System.Windows.Forms.GroupBox();
            this.rbtnDeposit = new System.Windows.Forms.RadioButton();
            this.rbtRedemption = new System.Windows.Forms.RadioButton();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.lbltxtID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbltxtAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbltxtPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbltxtPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lbltxtName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rbtnNormal = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.gBoxKindOfAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gBoxKindOfAccount);
            this.panel1.Controls.Add(this.btnNewAccount);
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
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 518);
            this.panel1.TabIndex = 1;
            // 
            // gBoxKindOfAccount
            // 
            this.gBoxKindOfAccount.Controls.Add(this.rbtnNormal);
            this.gBoxKindOfAccount.Controls.Add(this.rbtnDeposit);
            this.gBoxKindOfAccount.Controls.Add(this.rbtRedemption);
            this.gBoxKindOfAccount.Location = new System.Drawing.Point(518, 48);
            this.gBoxKindOfAccount.Name = "gBoxKindOfAccount";
            this.gBoxKindOfAccount.Size = new System.Drawing.Size(223, 108);
            this.gBoxKindOfAccount.TabIndex = 10;
            this.gBoxKindOfAccount.TabStop = false;
            this.gBoxKindOfAccount.Text = "계좌의 종류";
            // 
            // rbtnDeposit
            // 
            this.rbtnDeposit.AutoSize = true;
            this.rbtnDeposit.Location = new System.Drawing.Point(119, 40);
            this.rbtnDeposit.Name = "rbtnDeposit";
            this.rbtnDeposit.Size = new System.Drawing.Size(58, 19);
            this.rbtnDeposit.TabIndex = 1;
            this.rbtnDeposit.TabStop = true;
            this.rbtnDeposit.Text = "예금";
            this.rbtnDeposit.UseVisualStyleBackColor = true;
            // 
            // rbtRedemption
            // 
            this.rbtRedemption.AutoSize = true;
            this.rbtRedemption.Location = new System.Drawing.Point(7, 42);
            this.rbtRedemption.Name = "rbtRedemption";
            this.rbtRedemption.Size = new System.Drawing.Size(58, 19);
            this.rbtRedemption.TabIndex = 0;
            this.rbtRedemption.TabStop = true;
            this.rbtRedemption.Text = "적금";
            this.rbtRedemption.UseVisualStyleBackColor = true;
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Location = new System.Drawing.Point(598, 335);
            this.btnNewAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(143, 80);
            this.btnNewAccount.TabIndex = 6;
            this.btnNewAccount.Text = "계좌 생성";
            this.btnNewAccount.UseVisualStyleBackColor = true;
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(197, 48);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 25);
            this.txtName.TabIndex = 1;
            // 
            // rbtnNormal
            // 
            this.rbtnNormal.AutoSize = true;
            this.rbtnNormal.Location = new System.Drawing.Point(6, 83);
            this.rbtnNormal.Name = "rbtnNormal";
            this.rbtnNormal.Size = new System.Drawing.Size(58, 19);
            this.rbtnNormal.TabIndex = 2;
            this.rbtnNormal.TabStop = true;
            this.rbtnNormal.Text = "일반";
            this.rbtnNormal.UseVisualStyleBackColor = true;
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.panel1);
            this.Name = "NewAccount";
            this.Text = "NewAccount";
            this.Load += new System.EventHandler(this.NewAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBoxKindOfAccount.ResumeLayout(false);
            this.gBoxKindOfAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gBoxKindOfAccount;
        private System.Windows.Forms.RadioButton rbtnDeposit;
        private System.Windows.Forms.RadioButton rbtRedemption;
        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.Label lbltxtID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbltxtAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbltxtPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbltxtPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lbltxtName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rbtnNormal;
    }
}