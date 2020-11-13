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
    public partial class ListOfCustomers : Form
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

        frmJerryTalk frm;
        DataTable dt;
        string ReceiverNum;
        string ReceiverName;
        string ReceiverInfO;

        public ListOfCustomers(Customer cusinfo, frmJerryTalk temp)
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

            frm = temp;
        }

        public Customer customerInfo
        {
            get
            {
                return new Customer(CustomerNum, CustomerName, CustomerAddress,
                                            CustomerID, IsAdmin, CustomerPw, Phone, CustomerEmail, CustomerImage);
            }
        }
        public string receiverinfo {
            get { return (ReceiverInfO); } 
        
        }

        private void dgvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("해당 고객에게 메세지를 보내시겠습니까?", "선택확인", MessageBoxButtons
                .YesNo) == DialogResult.Yes)
            {
                ReceiverNum  = dt.Rows[e.RowIndex][0].ToString();
                ReceiverName = dt.Rows[e.RowIndex][1].ToString();
                ReceiverInfO = ReceiverNum + "." +ReceiverName;
                
                frm.receiverinfo = ReceiverInfO;
                this.Close();
            }
        }

        private void ListOfCustomers_Load(object sender, EventArgs e)
        {
            CustomerDB db = new CustomerDB();
            dt = db.GetEveryData();

            if (dt != null)
            {
                dgvMember.DataSource = dt;
            }
            else { MessageBox.Show("고객의 정보를 가져오는데 실패하였습니다."); }
        }
    }
}
