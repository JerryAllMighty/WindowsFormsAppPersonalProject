using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPersonalProject.CustomerManagement;

namespace WindowsFormsAppPersonalProject
{
    public partial class frmMain : Form
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
        string IsResting;


        private bool bActivateFlag = false;

        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(Customer cusinfo)
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
            IsResting = cusinfo.IsResting;
        }

        public Customer customerInfo        //다른 폼에 고객관련 정보를 넘겨주기 위한 프로퍼티
        {
            get
            {
                return new Customer(CustomerNum, CustomerName, CustomerAddress,
                                            CustomerID, IsAdmin, CustomerPw, Phone, CustomerEmail, CustomerImage);
            }
        }

        public Customer customerInfo2       //휴면계좌 위해서 고객관리 폼에만 넘겨주는 프로퍼티, 휴면계좌 여부가 추가되었다
        {
            get
            {
                return new Customer(CustomerNum, CustomerName, CustomerAddress,
                                            CustomerID, IsAdmin, CustomerPw, Phone, CustomerEmail, CustomerImage, IsResting);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "JerryBanking";
            

            if (IsAdmin == "N")
            {
                menuStrip1.Visible = true;
            }
            else if (IsAdmin == "Y")
                menuStrip3.Visible = true;


            //적금이나 예금 만기 한 달 전일 떄 안내 메세지가 팝업 되게 하기
            //이 때 선택이 예 이면 각 계좌에서 일반 계좌로 돈을 쏘게 하고, 아니요이면 연장 시키기


            //예금 만기 한달 전일 때
            DepositAccountDB dp = new DepositAccountDB();
             DataTable dt = dp.GetExpireData(CustomerNum);
            

            bool wannaExtend = false;
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //만기 한달 전인 예금을 현재 날짜와 비교하여 알려주기
                    if (dt.Rows[i][1].ToString().Replace(" ", "") == 
                        DateTime.Now.AddMonths(+1).ToString("yyyyMM").Replace(" ", ""))
                    {
                        if (MessageBox.Show("만기 예정인 예금이 있습니다. 연장하시겠습니까? \n 연장하지 않을 시 일반계좌로 금액이 반환됩니다.",
                            "만기 안내", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            //연장하려하는 예금 폼 띄우기
                            wannaExtend = true;
                            frmDepositExtension frm = new frmDepositExtension(dt, customerInfo);
                            frm.Show();
                            frm.Activate();
                        }
                        else    //연장을 원하지 않을 때 
                        {
                            //날짜와 응답을 비교해서 일반계좌로 돈을 보내기
                            wannaExtend = false;
                            MessageBox.Show("만기 날짜가 되면 귀하의 일반 계좌로 만기 예금이 입금됩니다.");
                        }
                    }

                    //만기날짜가 되었을 때, 예금을 응답 여부에 따라서 일반계좌로 송금해주기
                    if (dt.Rows[i][2].ToString().Replace(" ", "") ==
                        DateTime.Now.ToString("yyyyMMdd").Replace(" ", ""))
                    {
                        if (wannaExtend == false)//응답이 예금을 연장하지 않을 때
                        {
                            //디비 열어서 예금에서 일반으로 송금
                            MessageBox.Show("예금이 만기가 되어 귀하의 일반 계좌로 만기 예금이 입금됩니다.");
                            NormalAccountDB n1 = new NormalAccountDB();
                            if (!n1.UpdateReceiver(dt.Rows[i][10].ToString(), dt.Rows[i][7].ToString()))
                            {
                                MessageBox.Show("일반 계좌로 만기 예금을 송금하는데 실패하였습니다.");
                            }

                            //돈을 송금하고 해당 예금은 삭제합니다.
                            DepositAccountDB db = new DepositAccountDB();
                            if (!db.Delete(CustomerNum, dt.Rows[i][0].ToString()))
                            {
                                MessageBox.Show("만기 예금을 삭제하는데 실패하였습니다.");
                            }
                        }
                        else //응답이 예금을 연장할 때
                        { 
                        //그냥 넘어감~ 연장했으니 알림 없이 진행
                        }
                    }

                }
                
            }


            //만료 한달 전 안내
            SavingDB db2 = new SavingDB();
            DataTable dt2 = db2.GetExpireData(CustomerNum);
            

            bool wannaExtendS = false;
            if (dt2 != null)
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    //만기 한달 전인 적금을 현재 날짜와 비교하여 알려주기
                    if (dt2.Rows[i][1].ToString().Replace(" ", "") ==
                        DateTime.Now.AddMonths(+1).ToString("yyyyMM").Replace(" ", ""))
                    {
                        if (MessageBox.Show("만기 예정인 적금이 있습니다. 연장하시겠습니까? \n 연장하지 않을 시 일반계좌로 금액이 반환됩니다.",
                            "만기 안내", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            //연장하려하는 적금 폼 띄우기
                            wannaExtendS = true;
                            frmSavingExtension frm = new frmSavingExtension(dt2, customerInfo);
                            frm.Show();
                            frm.Activate();
                        }
                        else    //연장을 원하지 않을 때 
                        {
                            //날짜와 응답을 비교해서 일반계좌로 돈을 보내기
                            wannaExtendS = false;
                            MessageBox.Show("만기 날짜가 되면 귀하의 일반 계좌로 만기 적금이 입금됩니다.");
                        }
                    }

                    //만기날짜가 되었을 때, 적금을 응답 여부에 따라서 일반계좌로 송금해주기
                    if (dt2.Rows[i][2].ToString().Replace(" ", "") ==
                        DateTime.Now.ToString("yyyyMMdd").Replace(" ", ""))
                    {
                        if (wannaExtendS == false)//응답이 예금을 연장하지 않을 때
                        {
                            //디비 열어서 예금에서 일반으로 송금
                            MessageBox.Show("적금이 만기가 되어 귀하의 일반 계좌로 만기 적금이 입금됩니다.");
                            NormalAccountDB n1 = new NormalAccountDB();
                            if (!n1.UpdateReceiver(dt2.Rows[i][9].ToString(), dt2.Rows[i][6].ToString()))
                            {
                                MessageBox.Show("일반 계좌로 만기 적금을 송금하는데 실패하였습니다.");
                            }

                            //돈을 송금하고 해당 예금은 삭제합니다.
                            SavingDB db = new SavingDB();
                            if (!db.Delete(CustomerNum, dt2.Rows[i][0].ToString()))
                            {
                                MessageBox.Show("만기 적금을 삭제하는데 실패하였습니다.");
                            }
                        }
                        else //응답이 예금을 연장할 때
                        {
                            //그냥 넘어감~ 연장했으니 알림 없이 진행
                        }
                    }

                }

            }

            //적금 기입날 이어서 송금할 것인지 묻는 문자 보내기
            //만약 하루 내에 송금하지 않을 시 적금은 해지되어 일반 계좌로 보내지게 코딩

        }

        private void 고객ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer c1 = new frmCustomer(customerInfo);
            c1.MdiParent = this;
            c1.Show();
            c1.Activate();

        }
        #region 회원용메뉴
        private void 계좌ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountView a1 = new frmAccountView(customerInfo);
            a1.MdiParent = this;
            a1.Show();
            a1.Activate();
        }

        private void 대출ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoan l1 = new frmLoan(customerInfo);
            l1.MdiParent = this;
            l1.Show();
            l1.Activate();
        }
        private void 이체ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSending s1 = new frmSending(customerInfo);
            s1.MdiParent = this;
            s1.Show();
            s1.Activate();
        }

        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();

        }
        #endregion

        #region 관리자용메뉴
        private void toolStripMenuItem1_Click(object sender, EventArgs e)       //고객관리      //기존의 다른 폼들과 달리 휴면계좌 여부도 넘겨준다
        {
            frmCustomerManagement m1 = new frmCustomerManagement(customerInfo2);
            m1.Show();
            m1.Activate();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)       //계좌관리
        {
            frmAccountmanagement frm = new frmAccountmanagement();
            frm.Show();
            frm.Activate();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)       //대출 현황
        {
            frmLoanManagement frm = new frmLoanManagement();
            frm.Show();
            frm.Activate();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)       //로그아웃
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
            login.Activate();
        }
        #endregion

        private void 메세지박스ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJerryTalk frm = new frmJerryTalk(customerInfo);
            frm.Show();
            frm.Activate();
        }

        private void 메세지박스ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmJerryTalk frm = new frmJerryTalk(customerInfo);
            frm.Show();
            frm.Activate();
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (!bActivateFlag)
            {
                //새로온 메세지가 있다면 팝업 띄우기
                List<string> list = new List<string>();
                foreach (string str in frmJerryTalk.HasReadOrNot)
                {
                    list.Add(str.Substring(0, 1));
                }
                if (!list.Contains("Y") && list.Count > 0)
                {
                    MessageBox.Show("새로 온 메세지가 있습니다. 확인하시겠습니까?");
                }

                bActivateFlag = true;
            }
        }
    }
}
