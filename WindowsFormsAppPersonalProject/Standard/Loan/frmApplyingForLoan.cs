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
    public partial class frmApplyingForLoan : Form
    {
        DataTable dt;

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
        string DAccountNum ;
        string AmountOfLoan;
        string ReturnWhenExpired;
        string PayBackMethod;
        string Purpose;
        string LoanPeriod;
        string NAccountNum;
        string Pwd;
        string LoanDate;
        string InterestRate = "1.1"; //담보가 있으면 1.1, 없으면 1.2퍼센트
        string RegularPayBack;
        string LoanLeftover;
        string AmountOfPayBack;

        

        public frmApplyingForLoan()
        {
            InitializeComponent();
        }

        public frmApplyingForLoan(Customer cusinfo)
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

        public Loan LoanInfo 
        {
            get 
            {
                
                return new Loan(DAccountNum, AmountOfLoan, ReturnWhenExpired, PayBackMethod, Purpose,
                               LoanPeriod, NAccountNum, Pwd , InterestRate, 
                                RegularPayBack, CustomerNum, CustomerName, LoanLeftover );
            }
        }
        private void txtAmountOfLoan_TextChanged(object sender, EventArgs e)
        {
            AmountOfLoan = txtAmountOfLoan.Text;
        }

        private void txtWhenExpire_TextChanged(object sender, EventArgs e)
        {
            ReturnWhenExpired = txtWhenExpire.Text;
        }

        private void cbxPayBackMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
          PayBackMethod = cbxPayBackMethod.SelectedItem.ToString();
        }

        private void cbxPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
           Purpose = cbxPurpose.Text;
        }

        private void txtPeriod_TextChanged(object sender, EventArgs e)
        {
             LoanPeriod = txtPeriod.Text;
        }

        private void cbxOutAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            NAccountNum = cbxOutAccount.SelectedItem.ToString();
        }

        private void txtOutPwd_TextChanged(object sender, EventArgs e)
        {
            //비밀번호는 4자리로 입력받기
            if (txtOutPwd.Text.Length > 4)
            {
                MessageBox.Show("비밀번호는 반드시 4자리여야합니다.");
                txtOutPwd.Text = "";
            }
            else
                Pwd = txtOutPwd.Text;
        }

        private void frmApplyingForLoan_Load(object sender, EventArgs e)
        {
            //대출 담보를 선택하지 않을 시 대출 이율이 달라진다
            if (cbxDepositNum.Text.Trim().Replace(" ", "").Length < 1)
            {
                InterestRate = "1.2";
                errorProvider1.SetError(cbxDepositNum, "담보가 없을 시 대출 이율이 소폭 상승됩니다.\n 반드시 상담원과 대출 이율을 확인해주세요.");
            }

            //담보 제공 예금 계좌번호 콤보 박스 컨트롤 설정해주기
            CustomerDB db = new CustomerDB();
            dt = db.WhenYouApplyForLoan(int.Parse(CustomerNum));
            bool bFlag;

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)             //쿼리문의 결과중 예금 계좌 1개 당 여러개의 
                {                                                    //일반계좌가 나올 수 있으니 같은 예금계좌를 2번 추가해주는 것을 방지하기 위해서 반복문 돌기

                    bFlag = true;
                    for (int j = 0; j < i; j++)
                    {
                        if (dt.Rows[i]["DAccountNum"].ToString() == dt.Rows[j]["DAccountNum"].ToString())
                        {
                            bFlag = false;
                            break;
                        }
                    }
                    if (bFlag)
                    {
                        cbxDepositNum.Items.Add($"{dt.Rows[i]["DAccountNum"].ToString()}");
                    }
                }

                //출금 계좌 콤보 박스 컨트롤 설정해주기
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbxOutAccount.Items.Add($"{dt.Rows[i]["NAccountNum"].ToString()}");
                }

            }
            //cbxDepositNum.Items.Add("선택안함");        //dt가 null이어도 선택안함은 있어야함

           
        }

        private void btnNext_Click(object sender, EventArgs e)      //다음 버튼 클릭
        {
            //필수 입력칸들은 반드시 입력할 수 있게 체크
            if (txtAmountOfLoan.Text.Trim().Replace(" ", "").Length < 1 || cbxPayBackMethod.SelectedItem.ToString().Length < 1 ||
                txtPeriod.Text.Trim().Replace(" ", "").Length < 1 || txtOutPwd.Text.Trim().Replace(" ", "").Length < 1 ||
                cbxOutAccount.SelectedItem.ToString().Trim().Replace(" ", "").Length < 1)
            {
                MessageBox.Show("*표시는 필수 입력항목입니다. 반드시 입력해주세요.");
                return;
            }
            //계좌 비밀번호가 4자리가 아닐 시 걸러내기
            if (txtOutPwd.Text.Length != 4)
            {
                MessageBox.Show("계좌 비밀번호는 반드시 4자리여야합니다.");
            }

            //출금계좌와 비밀번호가 일치하는지 확인하기
            NormalAccountDB db = new NormalAccountDB();       
            if (db.GetEveryData(cbxOutAccount.SelectedItem.ToString(), txtOutPwd.Text) == null)
            {
                MessageBox.Show("출금 계좌와 비밀번호를 다시 한 번 확인해주세요.");
                return;
            }

            LoanLeftover = Multiply(txtAmountOfLoan.Text, InterestRate).ToString("N0");
                //(Convert.ToInt32(txtAmountOfLoan.Text) * Convert.ToInt32(InterestRate)).ToString();

            //한 번 더 정보가 맞는지 물어보기
            if (MessageBox.Show("대출 정보를 확실하게 확인하신 것이 맞습니까?", "대출 정보 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmApplyingForLoan2 frm = new frmApplyingForLoan2(LoanInfo);
                frm.Show();
                frm.Activate();
            }
        }
        private double Multiply(string a, string b)
        {
            int A = Convert.ToInt32(a);
            double B = Convert.ToDouble(b);
            return A * B;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "만기일시 상환 금액";
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(lblWhenExpire, "JerryBank 대출은 매월 대출금의 일정 금액을 상환하는 대출입니다. \n" +
                                                "하지만 대출금액의 60% 이내에서 대출 만기에 한 번에 상환할 수 있습니다.\n" +
                                                "예) 총 대출금액 1억원인 경우 만기일시 상환금액을 4천만원으로 지정하시면 대출기간 동안 \n" +
                                                "6천만원을 나누어 상환하고 만기에 4천만원을 한 번에 상환하게 됩니다.");
            toolTip1.AutoPopDelay = 20000;
            
            
        }

        private void cbxPayBackMethod_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxPayBackMethod.SelectedItem.ToString() == "자유 반환")
            {
                lblWhatisit.Visible = true;
                lblRegularWhen.Visible = false;
                txtRegularWhen.Visible = false;
                lblEveryMonth.Visible = false;
                lblDay.Visible = false;
            }
            else 
            {
                lblWhatisit.Visible = false;
                lblRegularWhen.Visible = true;
                txtRegularWhen.Visible = true;
                lblEveryMonth.Visible = true;
                lblDay.Visible = true;
            }
        }

        private void lblWhatisit_MouseEnter(object sender, EventArgs e)
        {
            toolTip2.ToolTipTitle = "자유 상환";
            toolTip2.IsBalloon = true;
            toolTip2.SetToolTip(lblWhatisit, "규칙적인 상환이 어렵거나 희망하지 않을 시, \n" +
                                                 "상환 시기를 설정하지 않고 반환하는 방법입니다.\n" +
                                                 "단, 이자는 동일 대출 기간의 정규 상환과 동일하게 적용됩니다.");
            toolTip2.AutoPopDelay = 20000;
        }

        private void cbxDepositNum_SelectedValueChanged(object sender, EventArgs e)     //예금담보 선택에 따라서 이자율이 변한다
        {
            //예금 담보를 선택했는지 안 했는지에 따라서 이자율을 차등해서 주기
            //아무것도 선택 안 할 시 기본적으로 20%이게 load 이벤트에 코딩했음
            //어떤 것이라도 담보가 있을 시에 10%이게 설정
            if(cbxDepositNum.SelectedItem.ToString().Trim().Replace(" ", "").Length > 0) 
            {
                InterestRate = "1.1";
                DAccountNum =cbxDepositNum.SelectedItem.ToString();
                errorProvider1.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRegularWhen_TextChanged(object sender, EventArgs e)
        {
           RegularPayBack = txtRegularWhen.Text;
        }


        #region 유효성체크
        private void txtAmountOfLoan_KeyPress(object sender, KeyPressEventArgs e) //대출 신청 금액에 숫자만 입력받게 체크
        {
            if (!CommonUtil.NumberCheck(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtWhenExpire_KeyPress(object sender, KeyPressEventArgs e) //만기상환금액에 숫자만 입력받게 체크
        {
            if (!CommonUtil.NumberCheck(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPeriod_KeyPress(object sender, KeyPressEventArgs e)     //대출기간 숫자만 입력받게 체크
        {
            if (!CommonUtil.NumberCheck(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtOutPwd_KeyPress(object sender, KeyPressEventArgs e)     //출금계좌 비밀번호 숫자만 입력받게 체크
        {
            if (!CommonUtil.NumberCheck(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRegularWhen_KeyPress(object sender, KeyPressEventArgs e)        //정기 상환 날짜도 숫자만 입력받게 체크
        {
            if (!CommonUtil.NumberCheck(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
