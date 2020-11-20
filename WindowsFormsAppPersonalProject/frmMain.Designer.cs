namespace WindowsFormsAppPersonalProject
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.고객ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.계좌ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.대출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이체ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메세지박스ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.메세지박스ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.계좌연장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예금ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.적금ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.고객ToolStripMenuItem,
            this.계좌ToolStripMenuItem,
            this.대출ToolStripMenuItem,
            this.이체ToolStripMenuItem,
            this.로그아웃ToolStripMenuItem,
            this.메세지박스ToolStripMenuItem,
            this.계좌연장ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(914, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // 고객ToolStripMenuItem
            // 
            this.고객ToolStripMenuItem.Name = "고객ToolStripMenuItem";
            this.고객ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.고객ToolStripMenuItem.Text = "고객";
            this.고객ToolStripMenuItem.Click += new System.EventHandler(this.고객ToolStripMenuItem_Click);
            // 
            // 계좌ToolStripMenuItem
            // 
            this.계좌ToolStripMenuItem.Name = "계좌ToolStripMenuItem";
            this.계좌ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.계좌ToolStripMenuItem.Text = "계좌조회";
            this.계좌ToolStripMenuItem.Click += new System.EventHandler(this.계좌ToolStripMenuItem_Click);
            // 
            // 대출ToolStripMenuItem
            // 
            this.대출ToolStripMenuItem.Name = "대출ToolStripMenuItem";
            this.대출ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.대출ToolStripMenuItem.Text = "대출";
            this.대출ToolStripMenuItem.Click += new System.EventHandler(this.대출ToolStripMenuItem_Click);
            // 
            // 이체ToolStripMenuItem
            // 
            this.이체ToolStripMenuItem.Name = "이체ToolStripMenuItem";
            this.이체ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.이체ToolStripMenuItem.Text = "이체";
            this.이체ToolStripMenuItem.Click += new System.EventHandler(this.이체ToolStripMenuItem_Click);
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            this.로그아웃ToolStripMenuItem.Click += new System.EventHandler(this.로그아웃ToolStripMenuItem_Click);
            // 
            // 메세지박스ToolStripMenuItem
            // 
            this.메세지박스ToolStripMenuItem.Name = "메세지박스ToolStripMenuItem";
            this.메세지박스ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.메세지박스ToolStripMenuItem.Text = "메세지박스";
            this.메세지박스ToolStripMenuItem.Click += new System.EventHandler(this.메세지박스ToolStripMenuItem_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5,
            this.메세지박스ToolStripMenuItem1});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip3.Size = new System.Drawing.Size(914, 30);
            this.menuStrip3.TabIndex = 1;
            this.menuStrip3.TabStop = true;
            this.menuStrip3.Text = "menuStrip3";
            this.menuStrip3.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(83, 26);
            this.toolStripMenuItem1.Text = "고객관리";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(83, 26);
            this.toolStripMenuItem2.Text = "계좌관리";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(83, 26);
            this.toolStripMenuItem3.Text = "대출현황";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(83, 26);
            this.toolStripMenuItem5.Text = "로그아웃";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // 메세지박스ToolStripMenuItem1
            // 
            this.메세지박스ToolStripMenuItem1.Name = "메세지박스ToolStripMenuItem1";
            this.메세지박스ToolStripMenuItem1.Size = new System.Drawing.Size(98, 26);
            this.메세지박스ToolStripMenuItem1.Text = "메세지박스";
            this.메세지박스ToolStripMenuItem1.Click += new System.EventHandler(this.메세지박스ToolStripMenuItem1_Click);
            // 
            // 계좌연장ToolStripMenuItem
            // 
            this.계좌연장ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.예금ToolStripMenuItem,
            this.적금ToolStripMenuItem});
            this.계좌연장ToolStripMenuItem.Name = "계좌연장ToolStripMenuItem";
            this.계좌연장ToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.계좌연장ToolStripMenuItem.Text = "계좌 연장";
            // 
            // 예금ToolStripMenuItem
            // 
            this.예금ToolStripMenuItem.Name = "예금ToolStripMenuItem";
            this.예금ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.예금ToolStripMenuItem.Text = "예금";
            this.예금ToolStripMenuItem.Click += new System.EventHandler(this.예금ToolStripMenuItem_Click);
            // 
            // 적금ToolStripMenuItem
            // 
            this.적금ToolStripMenuItem.Name = "적금ToolStripMenuItem";
            this.적금ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.적금ToolStripMenuItem.Text = "적금";
            this.적금ToolStripMenuItem.Click += new System.EventHandler(this.적금ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 고객ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 계좌ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 대출ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이체ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem 메세지박스ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메세지박스ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 계좌연장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 예금ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 적금ToolStripMenuItem;
    }
}

