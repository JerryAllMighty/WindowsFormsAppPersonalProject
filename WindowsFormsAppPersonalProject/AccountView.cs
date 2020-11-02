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
    public partial class AccountView : Form
    {
        public string CustomerNum;
        public string CustomerName;
        public string CustomerAddress;
        public string CustomerID;
        public string IsAdmin;
        public string CustomerPw;
        public string Phone;
        

        public AccountView()
        {
            InitializeComponent();
        }

        public AccountView(Customer customerInfo)
        {
            InitializeComponent();
            CustomerNum = customerInfo.CustomerNum;
            CustomerName = customerInfo.CustomerName;
            CustomerAddress = customerInfo.CustomerAddress;
            CustomerID = customerInfo.CustomerID;
            IsAdmin = customerInfo.IsAdmin;
            CustomerPw = customerInfo.CustomerPw;
            Phone = customerInfo.Phone;
        }

        public Customer customerinfo 
        {
            get 
            {
                return new Customer(CustomerNum, CustomerName, CustomerAddress, CustomerID, IsAdmin, CustomerPw, Phone);
            }
            }
        private void AccountView_Load(object sender, EventArgs e)
        {
            CommonUtil.SetinitGridView(dgvMember);
            CommonUtil.AddGridTextColumn(dgvMember, "고객 번호", "CustomerNum");
            CommonUtil.AddGridTextColumn(dgvMember, "고객 이름", "CustomerName");
            CommonUtil.AddGridTextColumn(dgvMember, "고객  주소", "CustomerAddress", 130);
            CommonUtil.AddGridTextColumn(dgvMember, "일반계좌 보유", "NAsoFar",120);
            CommonUtil.AddGridTextColumn(dgvMember, "적금계좌 보유", "SAsoFar",120);
            CommonUtil.AddGridTextColumn(dgvMember, "예금계좌 보유", "DAsoFar",120);

            try
            {
                CustomerDB db = new CustomerDB();
                DataTable dt = db.GetEveryData(CustomerID, CustomerPw);
                //db.Dispose();
                if (dt != null)
                {
                    dgvMember.DataSource = dt;
                }
                string customernum = dgvMember.Rows[0].Cells[0].Value.ToString();
                string customername = dgvMember.Rows[0].Cells[1].Value.ToString();
                string customeraddress = dgvMember.Rows[0].Cells[2].Value.ToString();
                customernum = dt.Rows[0]["CustomerNum"].ToString();
                customername = dt.Rows[0]["CustomerName"].ToString();
                customeraddress = dt.Rows[0]["CustomerAddress"].ToString();

                string naccountsofar = dgvMember.Rows[0].Cells[3].Value.ToString();
                NormalAccountDB n1 = new NormalAccountDB();
               DataTable dt2 = n1.countAccountSoFar(customerinfo);
                db.Dispose();
                if (dt2 != null)
                {
                    naccountsofar = dt2.Rows[0]["count(*)"].ToString();
                }

                string Daccountsofar = dgvMember.Rows[0].Cells[4].Value.ToString();
                DepositAccountDB d1 = new DepositAccountDB();
                DataTable dt3 = d1.countAccountSoFar(customerinfo);
                db.Dispose();
                if (dt3 != null)
                {
                    Daccountsofar = dt3.Rows[0]["count(*)"].ToString();
                }

                string Saccountsofar = dgvMember.Rows[0].Cells[5].Value.ToString();
                SavingDB s1 = new SavingDB();
                DataTable dt4 = s1.countAccountSoFar(customerinfo);
                db.Dispose();
                if (dt4 != null)
                {
                    Saccountsofar = dt4.Rows[0]["count(*)"].ToString();
                }







                db.Dispose();
            }
            catch (Exception)
            { 
            
            }

        }
    }
}
