using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPersonalProject.Sending
{
    public partial class frmSending2 : Form
    {
        string SSerialNum;
        string NAccountNum;
        string AmountOfSending;
        string SendingDate;
        string RecentlySentTo;
        string CustomerNum;
        string CustomerName;
        string ReceiversName;

        string MyAccountSending;

        public frmSending2()
        {
            InitializeComponent();
        }
        public SendingClass SendingInfo
        {
            get
            {
                return new SendingClass(NAccountNum, AmountOfSending, SendingDate, RecentlySentTo, CustomerNum, CustomerName);
            }
        }
        public frmSending2(SendingClass sendingInfo) : this (sendingInfo, "")
        {
            
        }
        public frmSending2(SendingClass sendingInfo, string myaccountsending)
        {
            InitializeComponent();
            SSerialNum = sendingInfo.SSerialNum;
            NAccountNum = sendingInfo.NAccountNum;
            AmountOfSending = sendingInfo.AmountOfSending;
            SendingDate = sendingInfo.SendingDate;      //현재 넘어온 값은 빈 값. 디비에서 인서트할 때 그 때 현재 시간을 디비에 넣어줄거임
            RecentlySentTo = sendingInfo.RecentlySentTo;    //입금계좌이다
            CustomerNum = sendingInfo.CustomerNum;
            CustomerName = sendingInfo.CustomerName;
            ReceiversName = sendingInfo.ReceiversName;
            MyAccountSending = myaccountsending;
        }

        private void btnSend_Click(object sender, EventArgs e)      //이체버튼 클릭
        {
            SendingDB db = new SendingDB();
            NormalAccountDB db2 = new NormalAccountDB();
            if (MyAccountSending == "D")        //예금 계좌에 이체할 때
            {
                DepositAccountDB d = new DepositAccountDB();
                //      이체내역 테이블에 정보 저장했고, 받는 사람 테이블 금액 올려줬고,               보낸 사람 테이블 금액 차감해줬으면
                if (db.Insert(SendingInfo) && d.UpdateCurrentMoney(RecentlySentTo, AmountOfSending) && db2.UpdateSender(AmountOfSending, NAccountNum))
                {
                    MessageBox.Show("이체가 성공적으로 완료되었습니다.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("이체가 실패하였습니다. 다시 시도해주세요.");
                    return;
                }
            }
            else if (MyAccountSending == "S")       //적금 계좌에 이체할 때
            {
                SavingDB s = new SavingDB();
                //      이체내역 테이블에 정보 저장했고, 받는 사람 테이블 금액 올려줬고,               보낸 사람 테이블 금액 차감해줬으면
                if (db.Insert(SendingInfo) && s.UpdateCurrentMoney(RecentlySentTo, AmountOfSending) && db2.UpdateSender(AmountOfSending, NAccountNum))
                {
                    MessageBox.Show("이체가 성공적으로 완료되었습니다.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("이체가 실패하였습니다. 다시 시도해주세요.");
                    return;
                }
            }
            else
            {

                //      이체내역 테이블에 정보 저장했고, 받는 사람 테이블 금액 올려줬고,               보낸 사람 테이블 금액 차감해줬으면
                if (db.Insert(SendingInfo) && db2.UpdateReceiver(AmountOfSending, RecentlySentTo) && db2.UpdateSender(AmountOfSending, NAccountNum))
                {
                    MessageBox.Show("이체가 성공적으로 완료되었습니다.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("이체가 실패하였습니다. 다시 시도해주세요.");
                    return;
                }
                
            }
            db.Dispose();
        }

        private void frmSending2_Load(object sender, EventArgs e)
        {
            lblAmountOfSending2.Text = AmountOfSending;
            lblInputAcc2.Text = RecentlySentTo;
            lblOutAcc2.Text = NAccountNum;
            lblReceiverName2.Text = ReceiversName;
        }
    }
}
