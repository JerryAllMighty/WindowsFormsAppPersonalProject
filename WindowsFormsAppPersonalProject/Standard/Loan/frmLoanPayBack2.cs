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
    public partial class frmLoanPayBack2 : Form
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


        string LoanNum;
        string DAccountNum;
        string AmountOfLoan;
        string ReturnWhenExpired;
        string PayBackMethod;
        string Purpose;
        string LoanPeriod;
        string NAccountNum;
        string Pwd;
        string LoanDate;
        string InterestRate;
        string RegularPayBack;
        string LoanLeftover;
        string AmountOfPayBack;


        string LoanWillBeLeftOver;

        public frmLoanPayBack2()
        {
            InitializeComponent();
        }
        public frmLoanPayBack2(Customer cusinfo)
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

        public frmLoanPayBack2(Loan loanInfo, string amountofpayback, string loannum)
        {
            InitializeComponent();
            LoanNum = loannum;
            DAccountNum = loanInfo.DAccountNum;
            AmountOfLoan = loanInfo.AmountOfLoan;
            ReturnWhenExpired = loanInfo.ReturnWhenExpired;
            PayBackMethod = loanInfo.PayBackMethod;
            Purpose = loanInfo.Purpose;
            LoanPeriod = loanInfo.LoanExpire;
            NAccountNum = loanInfo.NAccountNum;
            Pwd = loanInfo.Pwd;
            InterestRate = loanInfo.InterestRate;
            RegularPayBack = loanInfo.RegularPayBack;
            CustomerNum = loanInfo.CustomerNum;
            CustomerName = loanInfo.CustomerName;
            LoanLeftover = loanInfo.LoanLeftover;       //이건 남은 상환금액인거고
            AmountOfPayBack = amountofpayback;      //상환하는 금액을 넘겨받은거야
        }


        private void frmLoanPayBack2_Load(object sender, EventArgs e)
        {
            txtLoanNum.Text = LoanNum;
            txtOutAcc.Text = NAccountNum;
            txtAmountOfPayBack.Text = AmountOfPayBack;

            //기존에 남은 금액 - 이번에 상환하는 금액
            LoanWillBeLeftOver = (Convert.ToInt32(LoanLeftover) - Convert.ToInt32(AmountOfPayBack)).ToString(); 
            
            txtLoanWillBeLeftOver.Text = LoanWillBeLeftOver;

        }

        private void userControlOutAcc1_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoanDB db = new LoanDB();
            if (db.Update(txtLoanWillBeLeftOver.Text, LoanNum))
            {
                MessageBox.Show("성공적으로 대출이 상환되었습니다.");
                this.Close();
            }
            else {
                MessageBox.Show("과정에 오류가 있습니다. 다시 시도해주세요.");
                return;
            }
            db.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
