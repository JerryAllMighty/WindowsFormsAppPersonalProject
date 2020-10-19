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
        Customer c1 = new Customer();
        Location l1 = new Location();
        Loan loan = new Loan();
        Withdrawal w1 = new Withdrawal();
        Deposit d1 = new Deposit();
        Account a1 = new Account();
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "JerryBanking";
            c1.MdiParent = this;
        }

        private void 고객ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c1.Show();
        }

        private void 계좌ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a1.Show();
        }

        private void 예금ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d1.Show();
        }

        private void 출금ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w1.Show();
        }

        private void 대출ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loan.Show();
        }


        private void 지점ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            l1.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //정보 확인

                if (true)
                {
                    groupBox1.Visible = false;
                }
                else 
                {
                    MessageBox.Show("입력값이 올바르지 않습니다. 다시 시도해주십시오.");
                }
            }
        }
    }
}
