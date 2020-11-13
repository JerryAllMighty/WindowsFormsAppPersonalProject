using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPersonalProject.Sending;

namespace WindowsFormsAppPersonalProject
{
    public partial class frmSending : Form
    {
        StringBuilder sb = new StringBuilder();

       string CustomerNum;
       string CustomerName;
       string CustomerAddress;
       string CustomerID;
       string IsAdmin;
       string CustomerPw;
       string Phone;
       string CustomerEmail;
       string CustomerImage;

        string InputAcc;        //입금계좌로 입력을 했거나 혹은 최신 목록에서 선택을 했거나
        string ReceiverName;
        DataTable dt;

        public frmSending()
        {
            InitializeComponent();
        }
        public frmSending(Customer cusinfo)
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

        public Customer CustomerInfo
        {
            get
            {
                return new Customer(CustomerNum, CustomerName, CustomerAddress,
                                        CustomerID, IsAdmin, CustomerPw, Phone, CustomerEmail, CustomerImage);
            }

        }

        public SendingClass SendingInfo {
            get
            {
                return new SendingClass(cbxOutAcc.SelectedItem.ToString(), txtAmountOfSending.Text, "", InputAcc, CustomerNum, CustomerName, ReceiverName);
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmSending_Load(object sender, EventArgs e)
        {
            lblAlert.Text = "출금 계좌를 먼저 선택해주셔야합니다.";

            NormalAccountDB db = new NormalAccountDB();
            dt =  db.WhenYouSend(CustomerNum);
            db.Dispose();
            bool bFlag, cFlag;
            if (dt != null)             //쿼리 값이 참일때만 컨트롤들에 값을 더해주게 유효성 체크
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    bFlag = true;
                    cFlag = true;
                    for (int j = 0; j < i; j++)         //반복문을 돌면서 중복되는 값들은 더해주지 않기
                    {
                        if (dt.Rows[i]["NAccountNum"].ToString() == dt.Rows[j]["NAccountNum"].ToString())
                        {
                            bFlag = false;

                        }
                        if (dt.Rows[i]["RecentlySentTo"].ToString() == dt.Rows[j]["RecentlySentTo"].ToString())
                        {
                            cFlag = false;
                        }
                    }
                    if (bFlag)
                    {
                        cbxOutAcc.Items.Add(dt.Rows[i]["NAccountNum"].ToString());

                    }
                    if (cFlag)
                    {
                        cbxRecently.Items.Insert(0, dt.Rows[i]["RecentlySentTo"].ToString());
                    }
                }
            }
        }

        private void cbxOutAcc_SelectedValueChanged(object sender, EventArgs e)     //출금계좌가 선택이 될 때 현재 금액에 금액 바인딩해주기
        {
            //고른 일반계좌 번호의 금액
            if (cbxOutAcc.SelectedItem.ToString().Length > 0)
            {
                txtCurrentLeftOver.Text = dt.Rows[cbxOutAcc.SelectedIndex]["CurrentMoney"].ToString();
                lblAlert.Text = "";
            }
            else
                lblAlert.Text = "출금 계좌를 먼저 선택해주셔야합니다.";
            
        }

        private void comboBox3_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnSend_Click(object sender, EventArgs e)      //계좌이체 버튼 클릭
        {
            if (txtAmountOfSending.TextLength < 1 || txtAmountOfSending.TextLength < 1 || txtAmountOfSending.TextLength < 1 || txtAmountOfSending.TextLength < 1)
            {
                MessageBox.Show("필수 입력 항목들은 꼭 입력해주셔야합니다.");
                return;
            }
            if (MessageBox.Show("입력하신 정보가 맞습니까?", "최종 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //db들어가서 입금계좌 정보에 해당하는 고객정보가져오라
                NormalAccountDB db = new NormalAccountDB();
                DataTable dt2 = db.GetNormalAccountData(InputAcc.Trim().Replace(" ", ""));
                
                if ( dt2 == null)
                {
                    MessageBox.Show("해당 입금 계좌가 존재하지 않습니다.\n입금 계좌 정보를 다시 한 번 확인해주세요.");
                    return;
                }
                else 
                {
                    ReceiverName = dt2.Rows[0]["CustomerName"].ToString();      //결과가 뭐라도 나왔으니 수신인 이름에 값을 준다

                    if (db.GetEveryData(cbxOutAcc.SelectedItem.ToString(), txtOutPwd.Text) == null)     //출금 계좌 유효성 체크
                    {
                        MessageBox.Show("출금 계좌의 정보를 다시 한 번 확인해주세요.");
                        return;
                    }
                    if (MessageBox.Show($@"받으시는 분의 성함이 맞습니까?  
                                                         입금주명 : {ReceiverName}
                                                         입금 계좌 : {InputAcc}",
                         "이체 정보 확인", (MessageBoxButtons.YesNo)) == DialogResult.Yes)
                    {
                        frmSending2 frm = new frmSending2(SendingInfo);
                        frm.Show();
                        frm.Activate();
                    }
                }
            }
        }

        private void cbxRecently_SelectedValueChanged(object sender, EventArgs e)   //최근 목록의 값이 변하면 입급계좌 항목은 동일하게 만들어주기
        {
            InputAcc = cbxRecently.SelectedItem.ToString();
            txtInputAcc.Text = cbxRecently.SelectedItem.ToString(); 
        }

        private void txtInputAcc_TextChanged(object sender, EventArgs e)        //입급계좌 항목의 값이 입력된다면 콤보박스는 비워주기
        {
            InputAcc = txtInputAcc.Text;
            cbxRecently.Text = "";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SendingDB dbS = new SendingDB();
            if (dbS.GetEveryData(CustomerNum) == null)
            {
                MessageBox.Show("이체 내역을 불러오지 못 했습니다. 다시 시도해주세요.");
                return;

            }
            else
            { 
                dgvMember.DataSource = dt;
            }

        }       //이체내역 조회

        private void cbxOutAcc_Enter(object sender, EventArgs e)        //출금 계좌에 입력이 들어왔을 때, 일반 계좌가 없을 시
        {
            if (dt == null)
            {
                if (MessageBox.Show("출금 계좌가 존재하지 않습니다. 새로 개설하시겠습니까?", "출금 계좌 정보 없음", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    frmNewAccount frm = new frmNewAccount(CustomerInfo);
                    //this.Hide();
                    frm.Show();
                    frm.Activate();
                }
            }
        }
    }
}
