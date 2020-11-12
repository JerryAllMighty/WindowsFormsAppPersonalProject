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

        public static List<string> HasReadOrNot = new List<string>();


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

        public List<string> hasreadornot { get { return HasReadOrNot; }}

        private void frmMessageBox_Load(object sender, EventArgs e)
        {
            MessageDB db = new MessageDB();
            dt =  db.GetMessage2(CustomerNum);
            db.Dispose();

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
            string selected = listBox1.SelectedItem.ToString();
            HasReadOrNot.Insert(0, "Y" + selected);       
            DataTable dt3 = db.GetMessage3(selected.Substring(0, selected.IndexOf('.')), CustomerNum);

            for(int i = 0; i < dt3.Rows.Count; i++)
            {
                Label lbl = new Label();
                lbl.Text = $"{dt3.Rows[i][0].ToString()} \n{dt3.Rows[i][2].ToString()} \n{dt3.Rows[i][3].ToString()} ";
                lbl.Location = new Point(22,12 + (100*i));
                lbl.Size = new Size(300, 100);

                splitContainer2.Panel1.Controls.Add(lbl);
                //lblSenderName.Text = dt3.Rows[i][0].ToString();
                //lblSentDate.Text = dt3.Rows[i][3].ToString();
                //lblSentMsg.Text = dt3.Rows[i][2].ToString();
            }
            
        }
    }
}
