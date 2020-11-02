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
    public partial class frmMain : Form
    {
        public string CustomerNum;
        public string CustomerName;
        public string CustomerAddress;
        public string CustomerID;
        public string IsAdmin;
        public string CustomerPw;
        public string Phone;

        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(Customer cusinfo)
        {
            InitializeComponent();
            CustomerNum = cusinfo.CustomerNum;
            CustomerName = cusinfo.CustomerName;
            CustomerAddress= cusinfo.CustomerAddress;
            CustomerID = cusinfo.CustomerID;
            IsAdmin = cusinfo.IsAdmin;
            CustomerPw = cusinfo.CustomerPw;
            Phone = cusinfo.Phone;

        }

        public Customer customerInfo
        {
            get
            {
                return  new Customer(CustomerNum, CustomerName, CustomerAddress, CustomerID, IsAdmin, CustomerPw, Phone);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "JerryBanking";
           
            if (IsAdmin == "0")
            {
                menuStrip1.Visible = true;
            }
            else if(IsAdmin == "1")
                menuStrip3.Visible = true;
        }
       
        private void 고객ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer c1 = new frmCustomer(customerInfo);
            c1.MdiParent = this;
            c1.Show();
            c1.Activate();
            
        }

        private void 계좌ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountView a1 = new AccountView(customerInfo);
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
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
