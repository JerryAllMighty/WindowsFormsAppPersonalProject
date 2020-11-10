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
    public partial class frmLoanPayBack : Form
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

        public frmLoanPayBack()
        {
            InitializeComponent();
        }

        public frmLoanPayBack(Customer cusinfo)
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

        public Loan loanInfo {
            get
            {
                //대출 고유 번호도 삭제
                //대출신청 시간이 9번째인데, 이건 필요없어서 삭제
                return new Loan(
                    dgvMember.CurrentRow.Cells[1].Value.ToString(),
                    dgvMember.CurrentRow.Cells[2].Value.ToString(),
                    dgvMember.CurrentRow.Cells[3].Value.ToString(),
                    dgvMember.CurrentRow.Cells[4].Value.ToString(),
                    dgvMember.CurrentRow.Cells[5].Value.ToString(),
                    dgvMember.CurrentRow.Cells[6].Value.ToString(),
                    dgvMember.CurrentRow.Cells[7].Value.ToString(),
                    dgvMember.CurrentRow.Cells[8].Value.ToString(),     //비밀번호
                    dgvMember.CurrentRow.Cells[10].Value.ToString(),
                    dgvMember.CurrentRow.Cells[11].Value.ToString(),
                    dgvMember.CurrentRow.Cells[12].Value.ToString(),
                    dgvMember.CurrentRow.Cells[13].Value.ToString(),
                    dgvMember.CurrentRow.Cells[14].Value.ToString()
                    );
            }
        
        }


        private void frmLoanPayBack_Load(object sender, EventArgs e)
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
            CommonUtil.AddGridTextColumn(dgvMember, "남은 상환 금액", "LoanLeftOver");

            LoanDB db = new LoanDB();
            dgvMember.DataSource = db.GetEveryData(CustomerNum);

            txtPayBack.Text = "0";

        }

        private void btnNext_Click(object sender, EventArgs e)  //다음 버튼 클릭
        {

            if (cbxOutAccount.Text.Trim().Replace(" ", "").Length < 1 || txtOutAccPwd.Text.Trim().Replace(" ", "").Length < 1 ||
                txtPayBack.Text.Trim().Replace(" ", "").Length < 1)
            {
                MessageBox.Show("위의 3가지 항목은 반드시 입력해주세요.");
                return;
            }
            else 
            {
                NormalAccountDB db = new NormalAccountDB();
                if (db.GetEveryData(cbxOutAccount.Text, txtOutAccPwd.Text) == null)
                {
                    MessageBox.Show("출금 계좌 정보를 다시 한 번 확인해주세요.");
                }
                else 
                {
                    string LoanNum = dgvMember.CurrentRow.Cells[0].Value.ToString();
                    frmLoanPayBack2 frm = new frmLoanPayBack2(loanInfo, txtPayBack.Text, LoanNum);
                    frm.Show();
                    frm.Activate();
                }
            }
            

            
        }

        private void btn500_Click(object sender, EventArgs e)
        {
             txtPayBack.Text = (Convert.ToInt32(txtPayBack.Text) + 5000000).ToString();
        }

        private void btn100_Click(object sender, EventArgs e)
        {

        }

        private void btn50_Click(object sender, EventArgs e)
        {

        }

        private void btn10_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn1000_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

        }

        private void cbxOutAccount_Enter(object sender, EventArgs e)
        {
            //셀에서 클릭해야지만 여기에 값이 뜨게 하기
            
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)        //셀을 클릭해서 출금계좌컨트롤에 주기
        {

            
             dgvMember.CurrentRow.Selected = true;
             cbxOutAccount.Text =   dgvMember.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
