﻿using System;
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
        DataTable dt2;
        bool bFlag;
        NormalAccountDB db;
        string MyAccountSending = "";

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

        public SendingClass SendingInfo
        {
            get
            {
                return new SendingClass(cbxOutAcc.SelectedItem.ToString(), txtAmountOfSending.Text, "", InputAcc, CustomerNum, CustomerName, ReceiverName);
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IterationRemoval(DataTable aa, string columnName, ComboBox cbx)        //중복을 제거하고 데이터를 가져와서 콤보박스에 뿌려주는 함수
        {
            if (aa != null)             //쿼리 값이 참일때만 컨트롤들에 값을 더해주게 유효성 체크
            {
                for (int i = 0; i < aa.Rows.Count; i++)
                {
                    bFlag = true;
                    for (int j = 0; j < i; j++)         //반복문을 돌면서 중복되는 값들은 더해주지 않기
                    {
                        if (aa.Rows[i][columnName].ToString() == aa.Rows[j][columnName].ToString())
                        {
                            bFlag = false;

                        }

                    }
                    if (bFlag)
                    {
                        cbx.Items.Add(aa.Rows[i][columnName].ToString());
                    }
                }
            }
            
        }

        private void frmSending_Load(object sender, EventArgs e)
        {
            lblAlert.Text = "출금 계좌를 먼저 선택해주셔야합니다.";

            db = new NormalAccountDB();
            
            dt2 = db.WhenYouLoadfrmSending(CustomerNum);        //출금계좌, 예금 계좌, 적금 계좌 콤보박스에 바인딩시키기 위함
            db.Dispose();

            if (dt2 != null)
            {
                IterationRemoval(dt2, "NAccountNum", cbxOutAcc);        //출금 계좌에 바인딩
                IterationRemoval(dt2, "RecentlySentTo", cbxRecently);       //최근 목록에 바인딩
                IterationRemoval(dt2, "DAccountNum", cbxDepositAcc);        //예금 계좌에 바인딩
                IterationRemoval(dt2, "SAccountNum", cbxSavingAcc);     //적금 계좌에 바인딩
            }
            else
            {
                MessageBox.Show("이체 정보를 가져오지 못했습니다. 잠시 후 다시 시도해주세요.");
                return;
            }

            
        }

        private void cbxOutAcc_SelectedValueChanged(object sender, EventArgs e)     //출금계좌가 선택이 될 때 현재 금액에 금액 바인딩해주기
        {
            //고른 일반계좌 번호의 금액
            if (cbxOutAcc.SelectedItem.ToString().Length > 0)
            {
                txtCurrentLeftOver.Text = dt2.Rows[cbxOutAcc.SelectedIndex]["CurrentMoney"].ToString();
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
            if (txtAmountOfSending.TextLength < 1 || InputAcc.Length < 1 || cbxOutAcc.SelectedItem.ToString().Length < 1 || txtOutPwd.TextLength < 1)
            {
                MessageBox.Show("필수 입력 항목들은 꼭 입력해주셔야합니다.");
                return;
            }

            //계좌에 남아있는 잔액보다 큰 돈은 보낼 수 없게 체크
             DataTable dt3 = db.GetCurrentMoney(cbxOutAcc.Text);

            if (dt3 != null)
            {       //출금 계좌 잔액에서 이체 금액을 뺀 값이 0보다 작을 경우
                if ((Convert.ToInt32(dt3.Rows[0][0].ToString()) - Convert.ToInt32(txtAmountOfSending.Text)) < 0)
                {
                    MessageBox.Show("계좌 잔액보다 큰 금액은 보낼 수 없습니다.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("출금 계좌의 잔액에 관한 자료를 가져오지 못했습니다.");
                return;
            }
            //내 계좌(일반 > 일반)으로 보내는 경우
            if (cbxOutAcc.Text == InputAcc)
            {
                MessageBox.Show("같은 계좌로 보낼 수는 없습니다.");
                return;
            }
            //내 계좌(예금, 적금)로 보내는 경우
            //이 때도 출금계좌 유효성 체크하자
            if (MyAccountSending.Length > 0)     //내 계좌 항목(예금, 적금)을 선택시 입금계좌 입력 항목을 비게 코딩했음
            {
                ReceiverName = $"{CustomerName}";
                if (MessageBox.Show($@"받으시는 분의 성함이 맞습니까?  
                                                         입금주명 : {ReceiverName}
                                                         입금 계좌 : {InputAcc}",
                    "이체 정보 확인", (MessageBoxButtons.YesNo)) == DialogResult.Yes)
                {
                    frmSending2 frm = new frmSending2(SendingInfo, MyAccountSending);
                    frm.Show();
                    frm.Activate();
                }
            }
            else
            {
                    //내 계좌가 아닌 다른 사람의 일반 계좌로 보내는 경우
            
            
                if (MessageBox.Show("입력하신 정보가 맞습니까?", "최종 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //일반 계좌 db들어가서 입금계좌 정보에 해당하는 고객정보가져오라
                    NormalAccountDB db = new NormalAccountDB();
                    DataTable dt2 = db.GetNormalAccountData(InputAcc.Trim().Replace(" ", ""));

                    if (dt2 == null)
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
        }

        private void cbxRecently_SelectedValueChanged(object sender, EventArgs e)   //최근 목록의 값이 변하면 입급계좌 항목은 동일하게 만들어주기
        {
            if (cbxRecently.Text.Length > 0)
            {
                txtInputAcc.Text = cbxRecently.SelectedItem.ToString();
            }
        }

        private void txtInputAcc_TextChanged(object sender, EventArgs e)        //입급계좌 항목의 값이 입력된다면 콤보박스는 비워주기
        {
            InputAcc = txtInputAcc.Text;
            if (cbxSavingAcc.Text.Length < 1 && cbxDepositAcc.Text.Length < 1)
            {
                cbxRecently.Text = cbxDepositAcc.Text = cbxSavingAcc.Text = "";
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            CommonUtil.SetinitGridView(dgvMember);
            CommonUtil.AddGridTextColumn(dgvMember, "이체 번호", "SSerialNum", 80);
            CommonUtil.AddGridTextColumn(dgvMember, "출금 계좌", "NAccountNum", 80);
            CommonUtil.AddGridTextColumn(dgvMember, "출금 고객명", "CustomerNum", 100);
            CommonUtil.AddGridTextColumn(dgvMember, "출금 고객 이름", "CustomerName", 120);
            CommonUtil.AddGridTextColumn(dgvMember, "이체 금액", "AmountOfSending", 100);
            CommonUtil.AddGridTextColumn(dgvMember, "이체 날짜", "date(S.SendingDate)", 100);
            CommonUtil.AddGridTextColumn(dgvMember, "입금 계좌", "RecentlySentTo", 100);
            CommonUtil.AddGridTextColumn(dgvMember, "입금주명", "ReceiverName", 100);





            SendingDB dbS = new SendingDB();
            if (dbS.GetEveryData(CustomerNum) == null)
            {
                MessageBox.Show("이체 내역을 불러오지 못 했습니다. 다시 시도해주세요.");
                return;

            }
            else
            {
                dgvMember.DataSource = dbS.GetEveryData(CustomerNum);
            }

        }       //이체내역 조회

        private void cbxOutAcc_Enter(object sender, EventArgs e)
        {
        }


        private void txtInputAcc_KeyPress(object sender, KeyPressEventArgs e)       //입금 계좌 숫자만 입력받게 체크
        {
            if (!CommonUtil.NumberCheck(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtOutPwd_KeyPress(object sender, KeyPressEventArgs e)     //출금 계좌 비밀번호 숫자만 입력받게 체크
        {
            if (!CommonUtil.NumberCheck(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtAmountOfSending_KeyPress(object sender, KeyPressEventArgs e)        //이체 금액도 숫자만 입력받게 체크
        {
            if (!CommonUtil.NumberCheck(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void cbxSavingAcc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxSavingAcc.Text.Length > 0)
            {
                MyAccountSending = "S";
                txtInputAcc.Text = cbxSavingAcc.Text;
                cbxRecently.Text = cbxDepositAcc.Text = "";
            }
        }

        private void cbxDepositAcc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxDepositAcc.Text.Length > 0)
            {
                MyAccountSending = "D";
                txtInputAcc.Text = cbxDepositAcc.Text;
                cbxRecently.Text = cbxSavingAcc.Text = "";
            }
        }
    }
}
