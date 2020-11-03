namespace WindowsFormsAppPersonalProject
{
    partial class AccountView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnSavings = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.dgvMember2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember2)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 128;
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
            this.dgvMember.RowTemplate.Height = 23;
            this.dgvMember.Size = new System.Drawing.Size(800, 128);
            this.dgvMember.TabIndex = 0;
            this.dgvMember.TabStop = false;
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
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvMember2);
            this.splitContainer2.Size = new System.Drawing.Size(800, 318);
            this.splitContainer2.SplitterDistance = 161;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 1;
            this.splitContainer2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNormal);
            this.groupBox1.Controls.Add(this.btnSavings);
            this.groupBox1.Controls.Add(this.btnDeposit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "어떤 계좌를 조회하실 것인지 선택해주십시오";
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNormal.Location = new System.Drawing.Point(478, 101);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(115, 50);
            this.btnNormal.TabIndex = 2;
            this.btnNormal.Text = "일반";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnSavings
            // 
            this.btnSavings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSavings.Location = new System.Drawing.Point(329, 101);
            this.btnSavings.Name = "btnSavings";
            this.btnSavings.Size = new System.Drawing.Size(115, 50);
            this.btnSavings.TabIndex = 1;
            this.btnSavings.Text = "적금";
            this.btnSavings.UseVisualStyleBackColor = true;
            this.btnSavings.Click += new System.EventHandler(this.btnSavings_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeposit.Location = new System.Drawing.Point(177, 101);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(115, 50);
            this.btnDeposit.TabIndex = 0;
            this.btnDeposit.Text = "예금";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // dgvMember2
            // 
            this.dgvMember2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMember2.Location = new System.Drawing.Point(0, 0);
            this.dgvMember2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMember2.Name = "dgvMember2";
            this.dgvMember2.RowHeadersWidth = 51;
            this.dgvMember2.RowTemplate.Height = 27;
            this.dgvMember2.Size = new System.Drawing.Size(800, 154);
            this.dgvMember2.TabIndex = 0;
            this.dgvMember2.TabStop = false;
            // 
            // AccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.MinimizeBox = false;
            this.Name = "AccountView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "AccountView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AccountView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnSavings;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvMember2;
    }
}