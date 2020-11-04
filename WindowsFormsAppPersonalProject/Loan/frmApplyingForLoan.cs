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

        public string CustomerNum;
        public string CustomerName;
        public string CustomerAddress;
        public string CustomerID;
        public string IsAdmin;
        public string CustomerPw;
        public string Phone;

        public string daccountnum;
        public string interestrate = "10";

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
        }

        public Customer customerInfo
        {
            get
            {
                return new Customer(CustomerNum, CustomerName, CustomerAddress, CustomerID, IsAdmin, CustomerPw, Phone);
            }
        }

        public Loan LoanInfo 
        {
            get 
            {
                
                return new Loan(daccountnum, txtAmountOfLoan.Text, txtWhenExpire.Text, cbxPayBackMethod.SelectedItem.ToString(), cbxPurpose.Text,
                                txtPeriod.Text, cbxOutAccount.SelectedItem.ToString(), txtOutPwd.Text, interestrate, 
                                txtRegularWhen.Text, CustomerNum, CustomerName);
            }
            set
            {
                if (value.DAccountNum == "선택안함")
                    daccountnum = "";
                else
                    daccountnum = dt.Rows[cbxDepositNum.SelectedIndex]["DAccountNum"].ToString();
            }
        }


        private void frmApplyingForLoan_Load(object sender, EventArgs e)
        {
            //담보 제공 예금 계좌번호 콤보 박스 컨트롤 설정해주기
            CustomerDB db = new CustomerDB();
            dt = db.WhenYouApplyForLoan(int.Parse(CustomerNum));
            bool bFlag = true;

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)             //쿼리문의 결과중 예금 계좌 1개 당 여러개의 
                {                                                    //일반계좌가 나올 수 있으니 2번 예금계좌를 추가해주는 것을 방지하기 위해서 반복문 돌기
               
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
                        cbxDepositNum.Items.Add($"{dt.Rows[i]["DAccountNum"].ToString()}" + $"          {dt.Rows[i]["CustomerName"].ToString()}");
                    }
                }

                //출금 계좌 콤보 박스 컨트롤 설정해주기
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbxOutAccount.Items.Add($"{dt.Rows[i]["NAccountNum"].ToString()}");
                }

            }
            cbxDepositNum.Items.Add("선택안함");        //dt가 null이어도 선택안함은 있어야함

           
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("대출 정보를 확실하게 확인하신 것이 맞습니까?", "대출 정보 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmApplyingForLoan2 frm = new frmApplyingForLoan2(LoanInfo);
                frm.Show();
                frm.Activate();
            }
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

        private void cbxDepositNum_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxDepositNum.SelectedItem.ToString() == "선택안함")
            {
                interestrate = "20";
                LoanInfo.DAccountNum = "선택안함";
                errorProvider1.SetError(cbxDepositNum, "담보가 없을 시 대출 이율이 소폭 상승됩니다.\n 반드시 상담원과 대출 이율을 확인해주세요.");
            }
            else 
            {
                daccountnum = dt.Rows[cbxDepositNum.SelectedIndex]["DAccountNum"].ToString();
                errorProvider1.Clear();
            }
        }
    }
}
