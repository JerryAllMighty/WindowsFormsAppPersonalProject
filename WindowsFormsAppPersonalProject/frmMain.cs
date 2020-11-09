﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPersonalProject.CustomerManagement;

namespace WindowsFormsAppPersonalProject
{
    public partial class frmMain : Form
    {
       string CustomerNum;
       string CustomerName;
       string CustomerAddress;
       string CustomerID;
       string IsAdmin;
       string CustomerPw;
       string Phone;
       string CustomerEmail;
       string CustomerImage;


        private bool bActivateFlag = false;

        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(Customer cusinfo)
        {
            InitializeComponent();
            CustomerNum = cusinfo.CustomerNum;
            CustomerName = cusinfo.CustomerName;
            CustomerAddress = cusinfo.CustomerAddress;
            CustomerID = cusinfo.CustomerID;
            IsAdmin = cusinfo.IsAdmin;
            CustomerPw = cusinfo.CustomerPw;
            Phone = cusinfo.Phone;
            CustomerEmail = cusinfo.CustomerEmail;
            CustomerImage = cusinfo.CustomerImage;

        }

        public Customer customerInfo
        {
            get
            {
                return new Customer(CustomerNum, CustomerName, CustomerAddress,
                                            CustomerID, IsAdmin, CustomerPw, Phone, CustomerEmail, CustomerImage);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "JerryBanking";
            

            if (IsAdmin == "N")
            {
                menuStrip1.Visible = true;
            }
            else if (IsAdmin == "Y")
                menuStrip3.Visible = true;


        }

        private void 고객ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer c1 = new frmCustomer(customerInfo);
            c1.MdiParent = this;
            c1.Show();
            c1.Activate();

        }
        #region 회원용메뉴
        private void 계좌ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountView a1 = new AccountView(customerInfo);
            a1.MdiParent = this;
            a1.Show();
            a1.Activate();
        }

        private void 대출ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoan l1 = new frmLoan(customerInfo);
            l1.MdiParent = this;
            l1.Show();
            l1.Activate();
        }
        private void 이체ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSending s1 = new frmSending(customerInfo);
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
        #endregion

        #region 관리자용메뉴
        private void toolStripMenuItem1_Click(object sender, EventArgs e)       //고객관리
        {
            frmCustomerManagement m1 = new frmCustomerManagement(customerInfo);
            m1.Show();
            m1.Activate();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)       //계좌관리
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)       //대출 현황
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)       //로그아웃
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
            login.Activate();
        }
        #endregion

        private void 메세지박스ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJerryTalk frm = new frmJerryTalk(customerInfo);
            frm.Show();
            frm.Activate();
        }

        private void 메세지박스ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmJerryTalk frm = new frmJerryTalk(customerInfo);
            frm.Show();
            frm.Activate();
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (!bActivateFlag)
            {
                //새로온 메세지가 있다면 팝업 띄우기
                List<string> list = new List<string>();
                foreach (string str in frmJerryTalk.HasReadOrNot)
                {
                    list.Add(str.Substring(0, 1));
                }
                if (!list.Contains("Y") && list.Count > 0)
                {
                    MessageBox.Show("새로 온 메세지가 있습니다. 확인하시겠습니까?");
                }

                bActivateFlag = true;
            }
        }
    }
}
