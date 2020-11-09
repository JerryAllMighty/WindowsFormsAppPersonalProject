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
    public partial class AccountView : Form
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

        public AccountView()
        {
            InitializeComponent();
        }

        public AccountView(Customer customerInfo)
        {
            InitializeComponent();
            CustomerNum = customerInfo.CustomerNum;
            CustomerName = customerInfo.CustomerName;
            CustomerAddress = customerInfo.CustomerAddress;
            CustomerID = customerInfo.CustomerID;
            IsAdmin = customerInfo.IsAdmin;
            CustomerPw = customerInfo.CustomerPw;
            Phone = customerInfo.Phone;
            CustomerEmail = customerInfo.CustomerEmail;
            CustomerImage = customerInfo.CustomerImage;
        }

        public Customer customerinfo 
        {
            get 
            {
                return new Customer(CustomerNum, CustomerName, CustomerAddress,
                                    CustomerID, IsAdmin, CustomerPw, Phone, CustomerEmail, CustomerImage);
            }
        }

        
        private void AccountView_Load(object sender, EventArgs e)
        {
            CommonUtil.SetinitGridView(dgvMember);
            CommonUtil.SetinitGridView(dgvMember2);
            CommonUtil.AddGridTextColumn(dgvMember, "고객 번호", "CustomerNum");
            CommonUtil.AddGridTextColumn(dgvMember, "고객 이름", "CustomerName");
            CommonUtil.AddGridTextColumn(dgvMember, "고객  주소", "CustomerAddress", 130);
            CommonUtil.AddGridTextColumn(dgvMember, "일반계좌 보유", "NAccountSoFar", 120);
            CommonUtil.AddGridTextColumn(dgvMember, "적금계좌 보유", "SAccountSoFar", 120);
            CommonUtil.AddGridTextColumn(dgvMember, "예금계좌 보유", "DAccountSoFar", 120);

            try
            {
                CustomerDB db = new CustomerDB();
                DataTable dt = db.countAccountSoFar(CustomerNum);
                
                if (dt != null)
                {
                    dgvMember.DataSource = dt;
                }
                db.Dispose();
            }
            catch (Exception)
            { 
            
            }

        }

        private void btnDeposit_Click(object sender, EventArgs e)       //예금 계좌 조회
        {
            dgvMember2.Columns.Clear();

            CommonUtil.AddGridTextColumn(dgvMember2, "계좌 번호", "DAccountNum", 80);
            CommonUtil.AddGridTextColumn(dgvMember2, "생성 날짜", "DateCreated", 120);
            CommonUtil.AddGridTextColumn(dgvMember2, "고객 번호", "CustomerNum");
            CommonUtil.AddGridTextColumn(dgvMember2, "고객 이름", "CustomerName");
            CommonUtil.AddGridTextColumn(dgvMember2, "계좌 종류", "KindOfAcc");
            CommonUtil.AddGridTextColumn(dgvMember2, "예금액", "AmountOfDeposit");
            CommonUtil.AddGridTextColumn(dgvMember2, "출금 계좌", "OutAccount");
            CommonUtil.AddGridTextColumn(dgvMember2, "출금 계좌 비밀번호", "OutAccountPwd");
            CommonUtil.AddGridTextColumn(dgvMember2, "비밀번호", "NewPwd");
            CommonUtil.AddGridTextColumn(dgvMember2, "현재 잔액", "CurrentMoney");

            try
            {
                DepositAccountDB db = new DepositAccountDB();
                DataTable dt = db.GetEveryData(CustomerNum);
                if (dt != null)
                {
                    dgvMember2.DataSource = dt;
                }
                db.Dispose();

            }
            catch (Exception)
            {
                MessageBox.Show("계좌 조회에 실패했습니다.");
            }
        }

        private void btnSavings_Click(object sender, EventArgs e)       //적금 계좌 조회
        {
            dgvMember2.Columns.Clear();

            CommonUtil.AddGridTextColumn(dgvMember2, "계좌 번호", "SAccountNum", 100);
            CommonUtil.AddGridTextColumn(dgvMember2, "생성 날짜", "DateCreated", 120);
            CommonUtil.AddGridTextColumn(dgvMember2, "고객 번호", "CustomerNum");
            CommonUtil.AddGridTextColumn(dgvMember2, "고객 이름", "CustomerName");
            CommonUtil.AddGridTextColumn(dgvMember2, "계좌 종류", "KindOfAcc");
            CommonUtil.AddGridTextColumn(dgvMember2, "가입 기간", "Duration");
            CommonUtil.AddGridTextColumn(dgvMember2, "매회 납입 금액", "PayPerMonth",120);
            CommonUtil.AddGridTextColumn(dgvMember2, "출금 계좌", "OutAccount");
            CommonUtil.AddGridTextColumn(dgvMember2, "출금 계좌 비밀번호", "OutAccountPwd",150);
            CommonUtil.AddGridTextColumn(dgvMember2, "계좌 비밀번호", "NewPwd", 120);
            CommonUtil.AddGridTextColumn(dgvMember2, "현재 잔액", "CurrentMoney");

            try
            {
                SavingDB db = new SavingDB();
                DataTable dt = db.GetEveryData(CustomerNum);
                if (dt != null)
                {
                    dgvMember2.DataSource = dt;
                }
                db.Dispose();

            }
            catch (Exception)
            {
                MessageBox.Show("계좌 조회에 실패했습니다.");
            }
        }
private void btnNormal_Click(object sender, EventArgs e)        //일반 계좌 조회
        {
            dgvMember2.Columns.Clear();

            CommonUtil.AddGridTextColumn(dgvMember2,"계좌 번호", "NAccountNum", 80 );
            CommonUtil.AddGridTextColumn(dgvMember2,"생성 날짜", "DateCreated", 120);
            CommonUtil.AddGridTextColumn(dgvMember2,"고객 번호","CustomerNum");
            CommonUtil.AddGridTextColumn(dgvMember2,"고객 이름", "CustomerName");
            CommonUtil.AddGridTextColumn(dgvMember2,"계좌 종류", "KindOfAcc");
            CommonUtil.AddGridTextColumn(dgvMember2,"비밀번호", "Pwd");
            CommonUtil.AddGridTextColumn(dgvMember2,"현재 잔액", "CurrentMoney");

            try
            {
                NormalAccountDB db = new NormalAccountDB();
                DataTable dt = db.GetEveryData(CustomerNum);
                if (dt != null)
                {
                    dgvMember2.DataSource = dt;
                }
                db.Dispose();
                
            }
            catch (Exception)
            {
                MessageBox.Show("계좌 조회에 실패했습니다.");
            }
        }
    }
}
