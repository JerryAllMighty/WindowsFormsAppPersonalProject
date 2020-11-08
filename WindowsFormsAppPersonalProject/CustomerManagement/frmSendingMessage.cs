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
    public partial class frmSendingMessage : Form
    {
        public string SenderName;
        public string ReceiverName;
        public string MsgText;
        public string SenderNum;
        public string ReceiverNum;
        public string Timesent;
        public frmSendingMessage()
        {
            InitializeComponent();
        }
        public frmSendingMessage(Message msgInfo)
        {
            InitializeComponent();
            SenderName = msgInfo.SenderName;
            ReceiverName = msgInfo.ReceiverName;
            SenderNum = msgInfo.SenderNum;
            ReceiverNum = msgInfo.ReceiverNum;
            MsgText = msgInfo.MsgText;
            Timesent = msgInfo.TimeSent;
        }

        public Message MsgInfo 
        
        {
            get { return new Message(SenderNum, ReceiverNum, SenderName, ReceiverName, MsgText, DateTime.Now.ToString()); } 
            
             }

        private void frmSendingMessage_Load(object sender, EventArgs e)     //송수신자 표기는 이름으로
        {
            lblSenderName.Text = SenderName;
            lblReceiverName.Text = ReceiverName;

        }

        private void txtMsg_TextChanged(object sender, EventArgs e)
        {
            MsgText = txtMsg.Text;
        }

        private void btnSend_Click(object sender, EventArgs e)      //메세지를 주고 받는 조건을 PK인 고유 식별번호로 진행
        {
            if (MessageBox.Show($"정말로 {ReceiverName}님에게 메세지를 전송하시겠습니까?", "메세지 전송 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageDB db = new MessageDB();
                if (db.SendMsg(MsgInfo))
                {
                    MessageBox.Show("성공적으로 메세지가 전송되었습니다.");
                    
                }
                else { MessageBox.Show("메세지 전송이 실패하였습니다. 잠시 후에 다시 시도하여 주십시오."); }
                this.Close();
                db.Dispose();
            }
        }
    }
}
