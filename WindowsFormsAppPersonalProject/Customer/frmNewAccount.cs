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
        string CustomerNum;
        string CustomerName;
        string CustomerAddress;
        string CustomerID;
        string IsAdmin;
        string CustomerPw;
        string Phone;
        string CustomerEmail;
        string CustomerImage;

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
            CustomerEmail = cusinfo.CustomerEmail;
            CustomerImage = cusinfo.CustomerImage;
        }

        public NormalAccount accountinfo        //일반계좌에 정보 넘겨줄 떄 사용
        {
            get
            {
                return new NormalAccount(CustomerNum, CustomerName,cbxKindOfAccount.SelectedItem.ToString(), txtNewPwd.Text);     //
            }

        }

        public Savings savingInfo //적금 계좌에 넘겨줄 때 사용
        {
            get
            {
                return new Savings(CustomerNum, CustomerName, cbxKindOfAccount.SelectedItem.ToString(),
                                    cbxduration.SelectedItem.ToString(), txtpayPerMonth.Text, txtOutAccount.Text,
                                    txtOutPwd.Text, txtNewPwd.Text);
            }
        }

        public DepositAccount depositInfo       //예금 계좌에 넘겨줄 때 사용
        {
            get
            {
                return new DepositAccount(CustomerNum,CustomerName, cbxKindOfAccount.SelectedItem.ToString(),
                               txtAmountOfDeposit.Text, txtOutAccount.Text, txtOutPwd.Text, txtNewPwd.Text);
            }
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {
         
        }

        private void btnNewAccount_Click(object sender, EventArgs e)        //계좌 생성 버튼 클릭
        {
            //출금 계좌와 신규 계좌 비밀번호들이 4자리가 아닐 때
            if (txtOutPwd.TextLength != 4 || txtCheckNewPwd.Text.Length != 4)
            {
                MessageBox.Show("계좌의 비밀번호들은 4자리여야만 합니다.");
                return;
            }
            if (cbxKindOfAccount.SelectedItem.ToString().Length < 1)        //계좌 종류 반드시 선택하게하기
            {
                MessageBox.Show("계좌의 종류는 반드시 선택해주셔야합니다.");
                return;
            }
            if (txtNewPwd.Text.Length < 1 || txtCheckNewPwd.Text.Length < 1)        //신규 계좌 정보 꼭 입력하게 하기
            {
                MessageBox.Show("신규 계좌 정보는 반드시 입력해주셔야합니다.");
                return;
            }
            if (cbxKindOfAccount.SelectedItem.ToString() == "일반 계좌")
            {
                //일반 계좌에 연결
                NormalAccountDB db = new NormalAccountDB();
                
                if (!db.Insert(accountinfo))
                {
                    MessageBox.Show("실행 도중 오류가 발생하였습니다.");
                    return;
                }
                db.Dispose();
            }
            else if (cbxKindOfAccount.SelectedItem.ToString() == "예금 계좌")
            {
                if (!CheckOutAccount())      //출금 계좌와 비번이 맞는지 확인하는 함수 호출
                    return;
                //예금 계좌에 연결
                DepositAccountDB db = new DepositAccountDB();
                if (!db.Insert(depositInfo))
                {
                    MessageBox.Show("실행 도중 오류가 발생하였습니다.");
                    return;
                }
                db.Dispose();
            }
            else if (cbxKindOfAccount.SelectedItem.ToString() == "적금 계좌")
            {
                if (!CheckOutAccount())      //출금 계좌와 비번이 맞는지 확인하는 함수 호출
                    return;
                //적금 계좌에 연결
                SavingDB db = new SavingDB();
                
                if (!db.Insert(savingInfo))
                {
                    MessageBox.Show("실행 도중 오류가 발생하였습니다.");
                    return;
                }
                db.Dispose();
            }
            else
            {
                MessageBox.Show("반드시 계좌 종류를 선택하셔야합니다.");
                return;
            }
           
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
            //값이 바뀔 때마다 기존에 입력되어있던 값들, 계좌 종류에 따라 사용 불가했던 컨트롤들이 모두 초기화되게 하기
            txtpayPerMonth.Text = cbxduration.Text = txtOutAccount.Text = txtOutPwd.Text =
                cbxduration.Text = txtNewPwd.Text = txtCheckNewPwd.Text = txtAmountOfDeposit.Text = string.Empty;

            //라벨들 초기화
            lbltxtKindOfAccount.Enabled = lblduration.Enabled = lblpayPerMonth.Enabled = lblOutAccount.Enabled =
               lblOutPwd.Enabled = lblNewPwd.Enabled = lblCheckNewPwd.Enabled = lblAmountOfDeposit.Enabled = true;

            //텍스트박스들 초기화
            txtpayPerMonth.Enabled = cbxduration.Enabled = txtOutAccount.Enabled = txtOutPwd.Enabled =
                cbxduration.Enabled = txtNewPwd.Enabled = txtCheckNewPwd.Enabled = txtAmountOfDeposit.Enabled = true;       


            if (cbxKindOfAccount.SelectedItem.ToString() == "일반 계좌")        //다른 계좌 컨트롤들 못 쓰게 해주기
            {
                lblduration.Enabled = false;
                cbxduration.Enabled = false;

                lblpayPerMonth.Enabled = false;
                txtpayPerMonth.Enabled = false;

                lblOutAccount.Enabled = false;
                txtOutAccount.Enabled = false;

                lblOutPwd.Enabled = false;
                txtOutPwd.Enabled = false;

                lblAmountOfDeposit.Enabled = false;
                txtAmountOfDeposit.Enabled = false;

            }
            else if (cbxKindOfAccount.SelectedItem.ToString() == "적금 계좌")       //다른 계좌 컨트롤들 못 쓰게 해주기
            {
                lblAmountOfDeposit.Enabled = false;
                txtAmountOfDeposit.Enabled = false;
            }
            else      //다른 계좌 컨트롤들 못 쓰게 해주기
            {
                //예금 계좌 선택 시
                lblpayPerMonth.Enabled = false;
                txtpayPerMonth.Enabled = false;
            }
        }

        public bool CheckOutAccount()     //출금은 무조건 일반 계좌에서만 되기에 일반 계좌 db를 갔다온다
        {
            NormalAccountDB db = new NormalAccountDB();
            DataTable dt =  db.GetEveryData(CustomerNum);
            try
            {
                if(dt != null)
                {
                    StringBuilder sb = new StringBuilder();
                    if (txtOutAccount.Text.Trim().Equals(dt.Rows[0]["NAccountNum"].ToString()))        //일반계정의 계좌번호가 입력한 것과 같을 때
                    {
                       // txtOutAccount.BackColor = Color.Green;
                    }
                    else 
                    {
                        sb.Append("귀하의 일반 계좌에 존재하지 않는 계좌번호입니다. \n");
                        MessageBox.Show(sb.ToString());
                        return false;
                    }
                    if (txtOutPwd.Text.Trim().Equals(dt.Rows[0]["Pwd"].ToString()))            //일반계정의 계좌 비밀번호가 입력한 것과 같을 때
                    {
                     //   txtOutPwd.BackColor = Color.Green;
                    }
                    else
                    {
                        sb.Append("일치하지 않는 계좌 비밀번호입니다.");
                        MessageBox.Show(sb.ToString());
                        return false;
                    }

                    
                    db.Dispose();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;

            }
            
        }

        private void txtNewPwd_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPwd.Text.Length > 4)
            {
                MessageBox.Show("비밀번호는 반드시 4자리입니다.");
                txtNewPwd.Text = "";
            }
            
        }

        private void txtOutPwd_TextChanged(object sender, EventArgs e)
        {
            if (txtOutPwd.Text.Length > 4)
            {
                MessageBox.Show("비밀번호는 반드시 4자리입니다.");
                txtOutPwd.Text = "";
            }
        }
    }
}
