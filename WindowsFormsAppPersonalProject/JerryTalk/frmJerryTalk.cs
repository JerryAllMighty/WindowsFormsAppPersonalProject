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
    public partial class frmJerryTalk : Form
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

        string ReceiverNum;     //고객 입장에서는 받는 사람은 관리자뿐.
        string ReceiverName;
        string ReceiverInfO;


        public static bool HasReadOrNot = false;

        frmListOfCustomers list;
        DataTable dt;
        
        public frmJerryTalk()
        {
            InitializeComponent();
        }

        public frmJerryTalk(Customer cusinfo)
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

        public Message msgInfo {
            get
            {
                return new Message(CustomerNum, ReceiverNum, CustomerName, ReceiverName, textBox1.Text, "" );
            }
        }


        public string receiverinfo
        {
            get { return (ReceiverInfO); }
            set { ReceiverInfO = value; }

        }

        private void frmMessageBox_Load(object sender, EventArgs e)
        {
            MessageDB db = new MessageDB();
            dt =  db.GetMessage2(CustomerNum);
            db.Dispose();
            //고객입장에서는 메세지 박스가 처음에 비어있따면 관리자에게 전송할 수 있어야 한다
            //관리자 입장에서는 주고받은 사람 이외에도, 검색해서 쓸수 있어야한다
            if (listBox1.Items.Count == 0)
            {
                if (IsAdmin == "1")
                {
                
                }
                else
                {
                    ReceiverNum = "5";
                    ReceiverName = "The King";
                }
            }

            if (dt != null)
            {
                bool bFlag;
                for (int i = 0; i < dt.Rows.Count;i++)
                {
                    bFlag = true;
                    for (int j = 0; j < i; j++)     //보낸 사람의 고유번호를 비교해서 중복되지 않게 리스트에 이름을 추가
                    {
                        if (dt.Rows[i][1].ToString() == dt.Rows[j][1].ToString())
                        {
                            bFlag = false;
                            break;
                        }
                    }
                    if (bFlag)
                    {
                        listBox1.Items.Add(dt.Rows[i][0].ToString());
                        
                    }
                    
                }
                
            }
            
        }

        private void splitContainer1_Panel2_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            splitContainer2.Panel1.Controls.Clear();        //새로운 대화창이 열리면 기존의 대화창은 비워주기
            
            //더블클릭을 한 사람의 고유번호를 이용해서 검색
            MessageDB db = new MessageDB();
            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString().Length > 0)
            {
                string selected = listBox1.SelectedItem.ToString();
                ReceiverNum = selected.Substring(0, selected.IndexOf('.'));
                ReceiverName = selected.Substring(selected.IndexOf('.') + 1);
                //  HasReadOrNot.Insert(0, "Y" + selected);
                db.UpdateHasRead(CustomerNum);       //여기서 읽은 것으로 업데이트해준다
                DataTable dt3 = db.GetMessage3(selected.Substring(0, selected.IndexOf('.')), CustomerNum);
                if (dt3 != null)
                {
                    for (int i = 0; i < dt3.Rows.Count; i++)
                    {
                        Label lbl = new Label();
                        lbl.Text = $"{dt3.Rows[i][0].ToString()} \n{dt3.Rows[i][2].ToString()} \n{dt3.Rows[i][3].ToString()} ";
                        lbl.Location = new Point(22, 12 + (100 * i));
                        lbl.Size = new Size(300, 100);

                        splitContainer2.Panel1.Controls.Add(lbl);
                        //lblSenderName.Text = dt3.Rows[i][0].ToString();
                        //lblSentDate.Text = dt3.Rows[i][3].ToString();
                        //lblSentMsg.Text = dt3.Rows[i][2].ToString();
                    }

                }
            }
            
        }

        private void btnSend_Click(object sender, EventArgs e)      //전송 버튼 
        {
            //전송하면 보낸 메세지가 전달이되야함
            //만약 검색해서 가져온거면 그 검색 결과대로 전송이 이뤄져야해
            if (listBox1.Text.Length > 0)
            {
                MessageDB db = new MessageDB();
                if (db.SendMsg(msgInfo))
                {
                    MessageBox.Show("메세지가 성공적으로 전달이 되었습니다.");
                }
                else
                {
                    MessageBox.Show("메세지 전송에 실패하였습니다.");
                }

            }
            else
            {
                MessageBox.Show("꼭 보낼 사람을 선택해주세요.");
            }


        }

        private void btnSEarch_Click(object sender, EventArgs e)        //검색 버튼
        {
           
            if (IsAdmin == "N")
            {
                MessageBox.Show("검색은 관리자에게만 유효한 권한입니다.");
            }
            else
            {
                list = new frmListOfCustomers(customerInfo, this);
                list.ShowDialog();
                if (ReceiverInfO != null)
                {
                    listBox1.Items.Add(ReceiverInfO);

                }
            }
        }

        private void frmJerryTalk_Enter(object sender, EventArgs e)
        {

            
        }
    }
}
