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
    public partial class frmNewAccount : Form
    {
        public string CustomerNum;
        public string CustomerName;
        public string CustomerAddress;
        public string CustomerID;
        public string IsAdmin;
        public string CustomerPw;
        public string Phone;

        public frmNewAccount()
        {
            InitializeComponent();
        }
        public frmNewAccount(Customer cusinfo)
        {
            InitializeComponent();
            CustomerNum = cusinfo.CustomerNum;
            CustomerName = cusinfo.CustomerName;
            CustomerAddress = cusinfo.CustomerAddress;
            CustomerID = cusinfo.CustomerID;
            IsAdmin = cusinfo.IsAdmin;
            CustomerPw = cusinfo.CustomerPw;
            Phone = cusinfo.Phone;
        }

        public NormalAccount accountinfo        //일반계좌에 정보 넘겨줄 떄 사용
        {
            get
            {
                return new NormalAccount(CustomerNum, cbxKindOfAccount.SelectedItem.ToString(), txtNewPwd.Text);     //
            }

        }

        public Savings savingInfo //적금 계좌에 넘겨줄 때 사용
        {
            get
            {
                return new Savings(CustomerNum, cbxKindOfAccount.SelectedItem.ToString(),
                                    cbxduration.SelectedItem.ToString(), txtpayPerMonth.Text, txtOutAccount.Text,
                                    txtOutPwd.Text, txtNewPwd.Text);
            }
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnNewAccount_Click(object sender, EventArgs e)        //계좌 생성 버튼 클릭
        {
            
            if (cbxKindOfAccount.SelectedItem.ToString() == "일반 계좌")
            {
                //일반 계좌에 연결
                NormalAccountDB db = new NormalAccountDB();
                db.Insert(accountinfo);      
                db.Dispose();
            }
            else if (cbxKindOfAccount.SelectedItem.ToString() == "예금 계좌")
            {
                //예금 계좌에 연결

            }
            else if (cbxKindOfAccount.SelectedItem.ToString() == "적금 계좌")
            {
                //적금 계좌에 연결
                SavingDB db = new SavingDB();
                db.Insert(savingInfo);
                db.Dispose();
            }
            else
            {
                MessageBox.Show("반드시 계좌 종류를 선택하셔야합니다.");
                return;
            }
            //출금계좌가 DB NorMalAccount의 id,pw와 일치하는지 꼭! 연동시켜서 확인시켜주기
            MessageBox.Show("계좌 생성이 완료되었습니다.");
            this.Close();
        }

        private void txtCheckNewPwd_TextChanged(object sender, EventArgs e)     //신규 계좌 비밀번호 생성 비밀번호 확인하기
        {
            //유효성체크
            if (txtCheckNewPwd.Text != txtNewPwd.Text)
            {
                errorProvider1.SetError(txtCheckNewPwd, "비밀번호가 일치하지 않습니다.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cbxKindOfAccount_SelectedValueChanged(object sender, EventArgs e)      //선택값이 바뀔때마다
        {
            if (cbxKindOfAccount.SelectedItem.ToString() == "일반 계좌")
            {
                txtpayPerMonth.Enabled = false;
                cbxduration.Enabled = false;
                txtOutAccount.Enabled = false;
                txtOutPwd.Enabled = false;
            }
            else if (cbxKindOfAccount.SelectedItem.ToString() == "적금 계좌")
            {
                lblAmountOfDeposit.Enabled = false;
                txtAmountOfDeposit.Enabled = false;
            }
            else
            {
                //예금 계좌 선택 시
                lblpayPerMonth.Enabled = false;
                txtpayPerMonth.Enabled = false;
            }
        }
    }
}
