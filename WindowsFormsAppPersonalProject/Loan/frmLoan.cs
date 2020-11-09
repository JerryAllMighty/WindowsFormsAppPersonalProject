using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPersonalProject;

namespace WindowsFormsAppPersonalProject
{
    public partial class frmLoan : Form
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

        public frmLoan()
        {
            InitializeComponent();
        }
        public frmLoan(Customer cusinfo)
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

        private void Loan_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)        //대출 신청 버튼
        {
            frmApplyingForLoan frm = new frmApplyingForLoan(customerInfo);
            frm.Show();
            frm.Activate();
        }

        private void btnPayBack_Click(object sender, EventArgs e)       //대출 상환 버튼
        {
            frmLoanPayBack frm = new frmLoanPayBack();
            frm.Show();
            frm.Activate();
        }

        private void btnSelect_Click(object sender, EventArgs e)        //대출 조회 버튼
        {
            //디비 열어서 현재 대출 상황 보여주기
        }

        private void btnInfo_Click(object sender, EventArgs e)      //대출정보 조회
        {
            //어떻게 할까 고민중
        }
    }
}
