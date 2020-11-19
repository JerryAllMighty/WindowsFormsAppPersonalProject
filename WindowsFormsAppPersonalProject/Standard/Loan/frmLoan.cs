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
            CommonUtil.SetinitGridView(dgvMember);
            CommonUtil.AddGridTextColumn(dgvMember, "대출번호", "LoanNum");
            CommonUtil.AddGridTextColumn(dgvMember, "담보제공예금계좌번호", "DAccountNum", 150);
            CommonUtil.AddGridTextColumn(dgvMember, "대출금액", "AmountOfLoan");
            CommonUtil.AddGridTextColumn(dgvMember, "만기일시상환금액", "ReturnWhenExpired", 150);
            CommonUtil.AddGridTextColumn(dgvMember, "대출금상환방법", "PayBackMethod");
            CommonUtil.AddGridTextColumn(dgvMember, "대출목적", "Purpose");
            CommonUtil.AddGridTextColumn(dgvMember, "대출기간", "LoanExpire");
            CommonUtil.AddGridTextColumn(dgvMember, "출금계좌", "NAccountNum");
            CommonUtil.AddGridTextColumn(dgvMember, "출금계좌비밀번호", "Pwd");
            CommonUtil.AddGridTextColumn(dgvMember, "대출시작일시", "LoanStarted");
            CommonUtil.AddGridTextColumn(dgvMember, "대출금리", "InterestRate");
            CommonUtil.AddGridTextColumn(dgvMember, "정규상환일", "RegularPayBackDate");
            CommonUtil.AddGridTextColumn(dgvMember, "고객번호", "CustomerNum");
            CommonUtil.AddGridTextColumn(dgvMember, "고객이름", "CustomerName");


        }

        private void btnInsert_Click(object sender, EventArgs e)        //대출 신청 버튼
        {
            frmApplyingForLoan frm = new frmApplyingForLoan(customerInfo);
            frm.Show();
            frm.Activate();
        }

        private void btnPayBack_Click(object sender, EventArgs e)       //대출 상환 버튼
        {
            frmLoanPayBack frm = new frmLoanPayBack(customerInfo);
            frm.Show();
            frm.Activate();
        }

        private void btnSelect_Click(object sender, EventArgs e)        //대출 조회 버튼
        {
            //디비 열어서 현재 대출 상황 보여주기
            LoanDB db = new LoanDB();
            DataTable dt = db.GetEveryData(CustomerNum);
            if (dt != null)
            {
                dgvMember.DataSource = dt;
            }
            else { MessageBox.Show("대출 내역이 존재하지 않습니다."); }
        }

        private void btnInfo_Click(object sender, EventArgs e)      //대출정보 조회
        {
            //어떻게 할까 고민중
        }
    }
}
