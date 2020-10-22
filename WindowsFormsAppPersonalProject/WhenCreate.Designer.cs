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
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltxtName = new System.Windows.Forms.Label();
            this.lbltxtPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lbltxtPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbltxtAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbltxtID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(348, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 426);
            this.panel1.TabIndex = 0;
            // 
            // lbltxtName
            // 
            this.lbltxtName.Location = new System.Drawing.Point(28, 41);
            this.lbltxtName.Name = "lbltxtName";
            this.lbltxtName.Size = new System.Drawing.Size(100, 23);
            this.lbltxtName.TabIndex = 1;
            this.lbltxtName.Text = "이름";
            // 
            // lbltxtPwd
            // 
            this.lbltxtPwd.Location = new System.Drawing.Point(28, 242);
            this.lbltxtPwd.Name = "lbltxtPwd";
            this.lbltxtPwd.Size = new System.Drawing.Size(100, 23);
            this.lbltxtPwd.TabIndex = 3;
            this.lbltxtPwd.Text = "비밀번호";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(172, 239);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(223, 21);
            this.txtPwd.TabIndex = 4;
            // 
            // lbltxtPhone
            // 
            this.lbltxtPhone.Location = new System.Drawing.Point(28, 309);
            this.lbltxtPhone.Name = "lbltxtPhone";
            this.lbltxtPhone.Size = new System.Drawing.Size(100, 23);
            this.lbltxtPhone.TabIndex = 5;
            this.lbltxtPhone.Text = "연락처";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(172, 306);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(223, 21);
            this.txtPhone.TabIndex = 5;
            // 
            // lbltxtAddress
            // 
            this.lbltxtAddress.Location = new System.Drawing.Point(28, 108);
            this.lbltxtAddress.Name = "lbltxtAddress";
            this.lbltxtAddress.Size = new System.Drawing.Size(100, 23);
            this.lbltxtAddress.TabIndex = 0;
            this.lbltxtAddress.Text = "주소";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(172, 105);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(223, 21);
            this.txtAddress.TabIndex = 2;
            // 
            // lbltxtID
            // 
            this.lbltxtID.Location = new System.Drawing.Point(28, 175);
            this.lbltxtID.Name = "lbltxtID";
            this.lbltxtID.Size = new System.Drawing.Size(100, 23);
            this.lbltxtID.TabIndex = 9;
            this.lbltxtID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(172, 172);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(223, 21);
            this.txtID.TabIndex = 3;
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(12, 12);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowTemplate.Height = 23;
            this.dgvMember.Size = new System.Drawing.Size(306, 426);
            this.dgvMember.TabIndex = 7;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(270, 359);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(125, 64);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "등록";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // WhenCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.panel1);
            this.Name = "WhenCreate";
            this.Text = "WhenCreate";
            this.Load += new System.EventHandler(this.WhenCreate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.Button btnInsert;
    }
}