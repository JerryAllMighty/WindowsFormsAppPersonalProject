namespace WindowsFormsAppPersonalProject.CustomerManagement
{
    partial class frmCustomerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerManagement));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메세지보내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.관리자로임명ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.일반회원으로변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.휴면계좌로전환ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.휴면계좌해제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.수정ToolStripMenuItem,
            this.메세지보내기ToolStripMenuItem,
            this.관리자로임명ToolStripMenuItem,
            this.일반회원으로변경ToolStripMenuItem,
            this.휴면계좌로전환ToolStripMenuItem,
            this.휴면계좌해제ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 148);
            // 
            // 수정ToolStripMenuItem
            // 
            this.수정ToolStripMenuItem.Name = "수정ToolStripMenuItem";
            this.수정ToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.수정ToolStripMenuItem.Text = "수정";
            this.수정ToolStripMenuItem.Click += new System.EventHandler(this.수정ToolStripMenuItem_Click);
            // 
            // 메세지보내기ToolStripMenuItem
            // 
            this.메세지보내기ToolStripMenuItem.Name = "메세지보내기ToolStripMenuItem";
            this.메세지보내기ToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.메세지보내기ToolStripMenuItem.Text = "메세지보내기";
            this.메세지보내기ToolStripMenuItem.Click += new System.EventHandler(this.메세지보내기ToolStripMenuItem_Click);
            // 
            // 관리자로임명ToolStripMenuItem
            // 
            this.관리자로임명ToolStripMenuItem.Name = "관리자로임명ToolStripMenuItem";
            this.관리자로임명ToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.관리자로임명ToolStripMenuItem.Text = "관리자로 임명";
            this.관리자로임명ToolStripMenuItem.Click += new System.EventHandler(this.관리자로임명ToolStripMenuItem_Click);
            // 
            // 일반회원으로변경ToolStripMenuItem
            // 
            this.일반회원으로변경ToolStripMenuItem.Name = "일반회원으로변경ToolStripMenuItem";
            this.일반회원으로변경ToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.일반회원으로변경ToolStripMenuItem.Text = "일반 회원으로 변경";
            this.일반회원으로변경ToolStripMenuItem.Click += new System.EventHandler(this.일반회원으로변경ToolStripMenuItem_Click);
            // 
            // 휴면계좌로전환ToolStripMenuItem
            // 
            this.휴면계좌로전환ToolStripMenuItem.Name = "휴면계좌로전환ToolStripMenuItem";
            this.휴면계좌로전환ToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.휴면계좌로전환ToolStripMenuItem.Text = "휴면계좌로 전환";
            this.휴면계좌로전환ToolStripMenuItem.Click += new System.EventHandler(this.휴면계좌로전환ToolStripMenuItem_Click);
            // 
            // 휴면계좌해제ToolStripMenuItem
            // 
            this.휴면계좌해제ToolStripMenuItem.Name = "휴면계좌해제ToolStripMenuItem";
            this.휴면계좌해제ToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.휴면계좌해제ToolStripMenuItem.Text = "휴면계좌 해제";
            this.휴면계좌해제ToolStripMenuItem.Click += new System.EventHandler(this.휴면계좌해제ToolStripMenuItem_Click);
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
            this.dgvMember.Size = new System.Drawing.Size(800, 450);
            this.dgvMember.TabIndex = 3;
            this.dgvMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellContentClick);
            this.dgvMember.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMember_CellMouseDown);
            this.dgvMember.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMember_DataBindingComplete);
            // 
            // frmCustomerManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dgvMember);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCustomerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "고객관리";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomerManagement_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메세지보내기ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.ToolStripMenuItem 관리자로임명ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 일반회원으로변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 휴면계좌로전환ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 휴면계좌해제ToolStripMenuItem;
    }
}