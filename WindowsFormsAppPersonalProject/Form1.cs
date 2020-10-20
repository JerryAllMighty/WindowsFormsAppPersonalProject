using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPersonalProject
{
    public partial class Form1 : Form
    {
        Customer c1;
        Loan l1;
        AccountView a1;
        Sending s1;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "JerryBanking";
            menuStrip1.Enabled = false;
            progressBar1.Visible = false;
        }
       
        private void 고객ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c1 = new Customer();
            c1.MdiParent = this;
            c1.Show();
            c1.Activate();
            
        }

        private void 계좌ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a1 = new AccountView();
            a1.MdiParent = this;
            a1.Show();
            a1.Activate();
        }

        private void 대출ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            l1 = new Loan();
            l1.MdiParent = this;
            l1.Show();
            l1.Activate();
        }
        private void 이체ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s1 = new Sending();
            s1.MdiParent = this;
            s1.Show();
            s1.Activate();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //정보 확인

                if (true)       //로그인 성공
                {
                    groupBox1.Visible = false;
                    menuStrip1.Enabled = true;
                    timer1.Enabled = true;
                    timer1.Interval = 1000;
                    progressBar1.Value = 50;
                   
                }
                else 
                {
                    MessageBox.Show("입력값이 올바르지 않습니다. 다시 시도해주십시오.");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 10)
            {
                progressBar1.Value = progressBar1.Value - 10;
            }
            
            else if (progressBar1.Value < 10)
            {
                timer1.Stop();
                MessageBox.Show("로그인 세션이 만료되었습니다. 다시 로그인해주세요.");
                new Form();     //이게 맞나??  세션 만료되면 다시 처음 화면으로 돌아가게 할거임
                groupBox1.Visible = true;
                textBox3.Clear();
                textBox2.Clear();
                textBox2.Focus();
                
            }
        }
    }
}
