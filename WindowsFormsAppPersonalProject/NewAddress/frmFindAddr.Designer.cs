namespace WindowsFormsAppPersonalProject
{
    partial class frmFindAddr
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
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddr = new System.Windows.Forms.Button();
            this.txtZipno = new System.Windows.Forms.TextBox();
            this.txtJibun = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblZipNo = new System.Windows.Forms.Label();
            this.lblZibun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMember
            // 
            this.dgvMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(12, 12);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowTemplate.Height = 23;
            this.dgvMember.Size = new System.Drawing.Size(776, 175);
            this.dgvMember.TabIndex = 0;
            this.dgvMember.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Location = new System.Drawing.Point(90, 226);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(432, 21);
            this.txtSearch.TabIndex = 1;
            // 
            // btnAddr
            // 
            this.btnAddr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddr.Location = new System.Drawing.Point(627, 226);
            this.btnAddr.Name = "btnAddr";
            this.btnAddr.Size = new System.Drawing.Size(161, 49);
            this.btnAddr.TabIndex = 2;
            this.btnAddr.Text = "주소 검색";
            this.btnAddr.UseVisualStyleBackColor = true;
            this.btnAddr.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtZipno
            // 
            this.txtZipno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtZipno.Location = new System.Drawing.Point(90, 296);
            this.txtZipno.Multiline = true;
            this.txtZipno.Name = "txtZipno";
            this.txtZipno.Size = new System.Drawing.Size(265, 21);
            this.txtZipno.TabIndex = 3;
            // 
            // txtJibun
            // 
            this.txtJibun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJibun.Location = new System.Drawing.Point(90, 366);
            this.txtJibun.Multiline = true;
            this.txtJibun.Name = "txtJibun";
            this.txtJibun.Size = new System.Drawing.Size(432, 21);
            this.txtJibun.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.Location = new System.Drawing.Point(627, 351);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(161, 49);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(24, 226);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(57, 12);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "주소 검색";
            // 
            // lblZipNo
            // 
            this.lblZipNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblZipNo.AutoSize = true;
            this.lblZipNo.Location = new System.Drawing.Point(28, 300);
            this.lblZipNo.Name = "lblZipNo";
            this.lblZipNo.Size = new System.Drawing.Size(53, 12);
            this.lblZipNo.TabIndex = 7;
            this.lblZipNo.Text = "우편번호";
            // 
            // lblZibun
            // 
            this.lblZibun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblZibun.AutoSize = true;
            this.lblZibun.Location = new System.Drawing.Point(24, 374);
            this.lblZibun.Name = "lblZibun";
            this.lblZibun.Size = new System.Drawing.Size(57, 12);
            this.lblZibun.TabIndex = 8;
            this.lblZibun.Text = "지번 주소";
            // 
            // frmFindAddr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.lblZibun);
            this.Controls.Add(this.lblZipNo);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtJibun);
            this.Controls.Add(this.txtZipno);
            this.Controls.Add(this.btnAddr);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvMember);
            this.Name = "frmFindAddr";
            this.Text = "주소찾기";
            this.Load += new System.EventHandler(this.frmFindAddr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddr;
        private System.Windows.Forms.TextBox txtZipno;
        private System.Windows.Forms.TextBox txtJibun;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblZipNo;
        private System.Windows.Forms.Label lblZibun;
    }
}