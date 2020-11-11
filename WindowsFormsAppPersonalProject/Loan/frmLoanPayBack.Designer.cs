namespace WindowsFormsAppPersonalProject
{
    partial class frmLoanPayBack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoanPayBack));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btn1000 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.txtPayBack = new System.Windows.Forms.TextBox();
            this.txtOutAccPwd = new System.Windows.Forms.TextBox();
            this.cbxOutAccount = new System.Windows.Forms.ComboBox();
            this.lblPayBack = new System.Windows.Forms.Label();
            this.lblOutAccPwd = new System.Windows.Forms.Label();
            this.lblOutAccount = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvMember);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(888, 315);
            this.splitContainer1.SplitterDistance = 111;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMember.Location = new System.Drawing.Point(0, 0);
            this.dgvMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersWidth = 51;
            this.dgvMember.RowTemplate.Height = 27;
            this.dgvMember.Size = new System.Drawing.Size(888, 111);
            this.dgvMember.TabIndex = 0;
            this.dgvMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnRestart);
            this.groupBox1.Controls.Add(this.btn1000);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.btn10);
            this.groupBox1.Controls.Add(this.btn50);
            this.groupBox1.Controls.Add(this.btn100);
            this.groupBox1.Controls.Add(this.btn500);
            this.groupBox1.Controls.Add(this.txtPayBack);
            this.groupBox1.Controls.Add(this.txtOutAccPwd);
            this.groupBox1.Controls.Add(this.cbxOutAccount);
            this.groupBox1.Controls.Add(this.lblPayBack);
            this.groupBox1.Controls.Add(this.lblOutAccPwd);
            this.groupBox1.Controls.Add(this.lblOutAccount);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(888, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "대출 상환 정보 입력";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(766, 145);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 46);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.Location = new System.Drawing.Point(640, 145);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(122, 46);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "다음";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRestart.Location = new System.Drawing.Point(551, 146);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(66, 18);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "+재등록";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btn1000
            // 
            this.btn1000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1000.Location = new System.Drawing.Point(480, 145);
            this.btn1000.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(66, 18);
            this.btn1000.TabIndex = 8;
            this.btn1000.Text = "+1천";
            this.btn1000.UseVisualStyleBackColor = true;
            this.btn1000.Click += new System.EventHandler(this.btn1000_Click);
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1.Location = new System.Drawing.Point(410, 146);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(66, 18);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "+1만";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn10
            // 
            this.btn10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn10.Location = new System.Drawing.Point(339, 145);
            this.btn10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(66, 18);
            this.btn10.TabIndex = 6;
            this.btn10.Text = "+10만";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn50
            // 
            this.btn50.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn50.Location = new System.Drawing.Point(268, 146);
            this.btn50.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(66, 18);
            this.btn50.TabIndex = 5;
            this.btn50.Text = "+50만";
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
            // 
            // btn100
            // 
            this.btn100.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn100.Location = new System.Drawing.Point(197, 146);
            this.btn100.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(66, 18);
            this.btn100.TabIndex = 4;
            this.btn100.Text = "+100만";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn500
            // 
            this.btn500.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn500.Location = new System.Drawing.Point(126, 145);
            this.btn500.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(66, 18);
            this.btn500.TabIndex = 3;
            this.btn500.Text = "+500만";
            this.btn500.UseVisualStyleBackColor = true;
            this.btn500.Click += new System.EventHandler(this.btn500_Click);
            // 
            // txtPayBack
            // 
            this.txtPayBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPayBack.Location = new System.Drawing.Point(260, 104);
            this.txtPayBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPayBack.Name = "txtPayBack";
            this.txtPayBack.Size = new System.Drawing.Size(310, 21);
            this.txtPayBack.TabIndex = 2;
            // 
            // txtOutAccPwd
            // 
            this.txtOutAccPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutAccPwd.Location = new System.Drawing.Point(260, 62);
            this.txtOutAccPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutAccPwd.Name = "txtOutAccPwd";
            this.txtOutAccPwd.Size = new System.Drawing.Size(310, 21);
            this.txtOutAccPwd.TabIndex = 1;
            // 
            // cbxOutAccount
            // 
            this.cbxOutAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxOutAccount.FormattingEnabled = true;
            this.cbxOutAccount.Location = new System.Drawing.Point(260, 22);
            this.cbxOutAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxOutAccount.Name = "cbxOutAccount";
            this.cbxOutAccount.Size = new System.Drawing.Size(310, 20);
            this.cbxOutAccount.TabIndex = 0;
            this.cbxOutAccount.Enter += new System.EventHandler(this.cbxOutAccount_Enter);
            // 
            // lblPayBack
            // 
            this.lblPayBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPayBack.AutoSize = true;
            this.lblPayBack.Location = new System.Drawing.Point(123, 108);
            this.lblPayBack.Name = "lblPayBack";
            this.lblPayBack.Size = new System.Drawing.Size(53, 12);
            this.lblPayBack.TabIndex = 2;
            this.lblPayBack.Text = "상환금액";
            // 
            // lblOutAccPwd
            // 
            this.lblOutAccPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutAccPwd.AutoSize = true;
            this.lblOutAccPwd.Location = new System.Drawing.Point(123, 66);
            this.lblOutAccPwd.Name = "lblOutAccPwd";
            this.lblOutAccPwd.Size = new System.Drawing.Size(105, 12);
            this.lblOutAccPwd.TabIndex = 1;
            this.lblOutAccPwd.Text = "출금계좌 비밀번호";
            // 
            // lblOutAccount
            // 
            this.lblOutAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutAccount.AutoSize = true;
            this.lblOutAccount.Location = new System.Drawing.Point(123, 26);
            this.lblOutAccount.Name = "lblOutAccount";
            this.lblOutAccount.Size = new System.Drawing.Size(77, 12);
            this.lblOutAccount.TabIndex = 0;
            this.lblOutAccount.Text = "출금계좌번호";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.trackBar1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(888, 404);
            this.splitContainer2.SplitterDistance = 86;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 1;
            this.splitContainer2.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(10, 10);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(172, 45);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.TabStop = false;
            this.trackBar1.TickFrequency = 3;
            // 
            // frmLoanPayBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 404);
            this.Controls.Add(this.splitContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLoanPayBack";
            this.Text = "대출상환";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLoanPayBack_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPayBack;
        private System.Windows.Forms.TextBox txtOutAccPwd;
        private System.Windows.Forms.ComboBox cbxOutAccount;
        private System.Windows.Forms.Label lblPayBack;
        private System.Windows.Forms.Label lblOutAccPwd;
        private System.Windows.Forms.Label lblOutAccount;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btn1000;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnCancel;
    }
}