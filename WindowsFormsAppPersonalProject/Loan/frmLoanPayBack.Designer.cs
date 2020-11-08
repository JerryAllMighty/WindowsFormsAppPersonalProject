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
            this.splitContainer1.Size = new System.Drawing.Size(1015, 393);
            this.splitContainer1.SplitterDistance = 139;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMember.Location = new System.Drawing.Point(0, 0);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersWidth = 51;
            this.dgvMember.RowTemplate.Height = 27;
            this.dgvMember.Size = new System.Drawing.Size(1015, 139);
            this.dgvMember.TabIndex = 0;
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
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "대출 상환 정보 입력";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(876, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 57);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.Location = new System.Drawing.Point(731, 181);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(139, 57);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "다음";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRestart.Location = new System.Drawing.Point(630, 182);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "+재등록";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // btn1000
            // 
            this.btn1000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1000.Location = new System.Drawing.Point(549, 181);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(75, 23);
            this.btn1000.TabIndex = 8;
            this.btn1000.Text = "+1천";
            this.btn1000.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1.Location = new System.Drawing.Point(468, 182);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "+1만";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            this.btn10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn10.Location = new System.Drawing.Point(387, 181);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(75, 23);
            this.btn10.TabIndex = 6;
            this.btn10.Text = "+10만";
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // btn50
            // 
            this.btn50.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn50.Location = new System.Drawing.Point(306, 182);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(75, 23);
            this.btn50.TabIndex = 5;
            this.btn50.Text = "+50만";
            this.btn50.UseVisualStyleBackColor = true;
            // 
            // btn100
            // 
            this.btn100.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn100.Location = new System.Drawing.Point(225, 182);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(75, 23);
            this.btn100.TabIndex = 4;
            this.btn100.Text = "+100만";
            this.btn100.UseVisualStyleBackColor = true;
            // 
            // btn500
            // 
            this.btn500.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn500.Location = new System.Drawing.Point(144, 181);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(75, 23);
            this.btn500.TabIndex = 3;
            this.btn500.Text = "+500만";
            this.btn500.UseVisualStyleBackColor = true;
            // 
            // txtPayBack
            // 
            this.txtPayBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPayBack.Location = new System.Drawing.Point(297, 130);
            this.txtPayBack.Name = "txtPayBack";
            this.txtPayBack.Size = new System.Drawing.Size(354, 25);
            this.txtPayBack.TabIndex = 2;
            // 
            // txtOutAccPwd
            // 
            this.txtOutAccPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutAccPwd.Location = new System.Drawing.Point(297, 78);
            this.txtOutAccPwd.Name = "txtOutAccPwd";
            this.txtOutAccPwd.Size = new System.Drawing.Size(354, 25);
            this.txtOutAccPwd.TabIndex = 1;
            // 
            // cbxOutAccount
            // 
            this.cbxOutAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxOutAccount.FormattingEnabled = true;
            this.cbxOutAccount.Location = new System.Drawing.Point(297, 28);
            this.cbxOutAccount.Name = "cbxOutAccount";
            this.cbxOutAccount.Size = new System.Drawing.Size(354, 23);
            this.cbxOutAccount.TabIndex = 0;
            // 
            // lblPayBack
            // 
            this.lblPayBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPayBack.AutoSize = true;
            this.lblPayBack.Location = new System.Drawing.Point(141, 135);
            this.lblPayBack.Name = "lblPayBack";
            this.lblPayBack.Size = new System.Drawing.Size(67, 15);
            this.lblPayBack.TabIndex = 2;
            this.lblPayBack.Text = "상환금액";
            // 
            // lblOutAccPwd
            // 
            this.lblOutAccPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutAccPwd.AutoSize = true;
            this.lblOutAccPwd.Location = new System.Drawing.Point(141, 83);
            this.lblOutAccPwd.Name = "lblOutAccPwd";
            this.lblOutAccPwd.Size = new System.Drawing.Size(132, 15);
            this.lblOutAccPwd.TabIndex = 1;
            this.lblOutAccPwd.Text = "출금계좌 비밀번호";
            // 
            // lblOutAccount
            // 
            this.lblOutAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutAccount.AutoSize = true;
            this.lblOutAccount.Location = new System.Drawing.Point(141, 32);
            this.lblOutAccount.Name = "lblOutAccount";
            this.lblOutAccount.Size = new System.Drawing.Size(97, 15);
            this.lblOutAccount.TabIndex = 0;
            this.lblOutAccount.Text = "출금계좌번호";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer2.Size = new System.Drawing.Size(1015, 505);
            this.splitContainer2.SplitterDistance = 108;
            this.splitContainer2.TabIndex = 1;
            this.splitContainer2.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 12);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(197, 56);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.TabStop = false;
            this.trackBar1.TickFrequency = 3;
            // 
            // frmLoanPayBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 505);
            this.Controls.Add(this.splitContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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