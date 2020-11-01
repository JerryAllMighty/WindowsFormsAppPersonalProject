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

        public NormalAccount accountinfo
        {
            get
            {
                return new NormalAccount(CustomerNum, cbxKindOfAccount.SelectedItem.ToString(), txtNewPwd.Text);     //
            }

        }

        private void NewAccount_Load(object sender, EventArgs e)
        {

        }

        private void cbxKindOfAccount_MouseLeave(object sender, EventArgs e)
        {
            if (cbxKindOfAccount.SelectedItem.ToString() == "일반 계좌")
            {
                txtpayPerMonth.Enabled = false;
                cbxduration.Enabled = false;
                txtOutAccount.Enabled = false;
                txtOutPwd.Enabled = false;
            }
            else
            { 
            
            }
        }

        private void btnNewAccount_Click(object sender, EventArgs e)        //계좌 생성 버튼 클릭
        {
            NormalAccountDB db = new NormalAccountDB();
            if (cbxKindOfAccount.SelectedItem.ToString() == "일반 계좌")
            {
                //일반 계좌에 연결
                db.Insert(accountinfo);
            }
            else if (cbxKindOfAccount.SelectedItem.ToString() == "예금 계좌")
            {
                //예금 계좌에 연결
            }
            else if (cbxKindOfAccount.SelectedItem.ToString() == "적금 계좌")
            { 
                 //적금 계좌에 연결
            }
            else
            {
                MessageBox.Show("반드시 계좌 종류를 선택하셔야합니다.");
                return;
            }

            MessageBox.Show("계좌 생성이 완료되었습니다.");
        }

        private void txtCheckNewPwd_TextChanged(object sender, EventArgs e)     //신규 계좌 비밀번호 생성 비밀번호 확인하기
        {
            //유효성체크
            if (txtCheckNewPwd.Text != txtCheckNewPwd.Text)
            {
                errorProvider1.SetError(txtCheckNewPwd, "비밀번호가 일치하지 않습니다.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
