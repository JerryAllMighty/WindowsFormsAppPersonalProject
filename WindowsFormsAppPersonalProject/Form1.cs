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
        private Login login;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Login login)
        {
            InitializeComponent();
            this.login = login;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "JerryBanking";
            Login login = new Login();

            if (login.ID == "SCustomerID")
            {
                menuStrip1.Visible = true;
            }
            else if(login.ID == "ACustomerID")
                menuStrip3.Visible = true;
        }
       
        private void 고객ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer c1 = new Customer();
            c1.MdiParent = this;
            c1.Show();
            c1.Activate();
            
        }

        private void 계좌ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountView a1 = new AccountView();
            a1.MdiParent = this;
            a1.Show();
            a1.Activate();
        }

        private void 대출ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loan l1 = new Loan();
            l1.MdiParent = this;
            l1.Show();
            l1.Activate();
        }
        private void 이체ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sending s1 = new Sending();
            s1.MdiParent = this;
            s1.Show();
            s1.Activate();
        }

        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
