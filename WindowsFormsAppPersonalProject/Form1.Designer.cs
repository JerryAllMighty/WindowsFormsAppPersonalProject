namespace WindowsFormsAppPersonalProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.고객ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.계좌ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예금ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.현재금액ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출금ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.대출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.지점ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.고객ToolStripMenuItem,
            this.계좌ToolStripMenuItem,
            this.예금ToolStripMenuItem,
            this.출금ToolStripMenuItem,
            this.대출ToolStripMenuItem,
            this.지점ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 고객ToolStripMenuItem
            // 
            this.고객ToolStripMenuItem.Name = "고객ToolStripMenuItem";
            this.고객ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.고객ToolStripMenuItem.Text = "고객";
            this.고객ToolStripMenuItem.Click += new System.EventHandler(this.고객ToolStripMenuItem_Click);
            // 
            // 계좌ToolStripMenuItem
            // 
            this.계좌ToolStripMenuItem.Name = "계좌ToolStripMenuItem";
            this.계좌ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.계좌ToolStripMenuItem.Text = "계좌조회";
            this.계좌ToolStripMenuItem.Click += new System.EventHandler(this.계좌ToolStripMenuItem_Click);
            // 
            // 예금ToolStripMenuItem
            // 
            this.예금ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.현재금액ToolStripMenuItem});
            this.예금ToolStripMenuItem.Name = "예금ToolStripMenuItem";
            this.예금ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.예금ToolStripMenuItem.Text = "입금";
            this.예금ToolStripMenuItem.Click += new System.EventHandler(this.예금ToolStripMenuItem_Click);
            // 
            // 현재금액ToolStripMenuItem
            // 
            this.현재금액ToolStripMenuItem.Name = "현재금액ToolStripMenuItem";
            this.현재금액ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.현재금액ToolStripMenuItem.Text = "현재금액";
            // 
            // 출금ToolStripMenuItem
            // 
            this.출금ToolStripMenuItem.Name = "출금ToolStripMenuItem";
            this.출금ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.출금ToolStripMenuItem.Text = "출금";
            this.출금ToolStripMenuItem.Click += new System.EventHandler(this.출금ToolStripMenuItem_Click);
            // 
            // 대출ToolStripMenuItem
            // 
            this.대출ToolStripMenuItem.Name = "대출ToolStripMenuItem";
            this.대출ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.대출ToolStripMenuItem.Text = "대출";
            this.대출ToolStripMenuItem.Click += new System.EventHandler(this.대출ToolStripMenuItem_Click);
            // 
            // 지점ToolStripMenuItem
            // 
            this.지점ToolStripMenuItem.Name = "지점ToolStripMenuItem";
            this.지점ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.지점ToolStripMenuItem.Text = "지점";
            this.지점ToolStripMenuItem.Click += new System.EventHandler(this.지점ToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 29);
            this.textBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(165, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 137);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "로그인을 시도해주십시오";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(202, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(277, 29);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 고객ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 계좌ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 예금ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 현재금액ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 출금ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 대출ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 지점ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
    }
}

