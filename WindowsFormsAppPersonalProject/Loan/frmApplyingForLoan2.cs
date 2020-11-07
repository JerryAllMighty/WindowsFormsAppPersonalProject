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
    public partial class frmApplyingForLoan2 : Form
    {
        public string CustomerNum;
        public string CustomerName;
        public string CustomerAddress;
        public string CustomerID;
        public string IsAdmin;
        public string CustomerPw;
        public string Phone;
        public string CustomerEmail;
        public string CustomerImage;


        public string LoanNum;
        public string DAccountNum;
        public string AmountOfLoan;
        public string ReturnWhenExpired;
        public string PayBackMethod;
        public string Purpose;
        public string LoanPeriod;
        public string NAccountNum;
        public string Pwd;
        public string LoanDate;
        public string InterestRate;
        public string RegularPayBack;
       



        public frmApplyingForLoan2()
        {
            InitializeComponent();
        }
        public frmApplyingForLoan2(Customer cusinfo)
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

        public frmApplyingForLoan2(Loan loanInfo)
        {
            InitializeComponent();
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
        }

        public Customer customerInfo
        {
            get
            {
                return new Customer(CustomerNum, CustomerName, CustomerAddress, 
                                        CustomerID, IsAdmin, CustomerPw, Phone, CustomerEmail, CustomerImage);
            }
        }

        public Loan LoanInfo
        {
            get
            {

                return new Loan(DAccountNum, AmountOfLoan, ReturnWhenExpired, PayBackMethod, Purpose,
                                LoanPeriod, NAccountNum, Pwd, InterestRate,
                                RegularPayBack, CustomerNum, CustomerName);
            }
        }

        private void frmApplyingForLoan2_Load(object sender, EventArgs e)
        {
            lblName2.Text = CustomerName;
            lblLoanPeriod2.Text =  DateTime.Now.AddMonths(int.Parse(LoanPeriod)).ToString();
            lblPayBackMethod2.Text = PayBackMethod;
            if (DAccountNum == "선택안함")
            {
                lblKindOfLoan2.Text = "예금 담보가 아닌 일반 대출";
            }
            else { lblKindOfLoan2.Text = "예금(신탁) 담보 대출"; }
            lblAmountOfLoan2.Text = AmountOfLoan;
            lblInterest2.Text = "연 \t" + InterestRate + "%";
            if (RegularPayBack.Length > 0)
                lblRegularWhen2.Text = "매 월" + RegularPayBack + "일";
            else { lblRegularWhen2.Text = "정해지지 않음"; }
        }

        private void btnInsert_Click(object sender, EventArgs e)        
        {
            if (MessageBox.Show("정말로 대출을 신청하시겠습니까?", "최종 대출 신청 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //db열어서 넣어주자 정보를
                LoanDB db = new LoanDB();
                bool result =  db.Insert(LoanInfo);
                if (result)
                {
                    MessageBox.Show("최종 대출 신청이 완료되었습니다.");
                }
                else 
                {
                    MessageBox.Show("대출 신청이 실패했습니다. 다시 시도하여 주십시오.");
                }
                db.Dispose();
                
            }
            else 
            {
                this.Close();
            }
        }
    }
}
