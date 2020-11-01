using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using WindowsFormsAppPersonalProject;

namespace WindowsFormsAppPersonalProject
{
    public partial class frmWhenCreate : Form
    {
        public string CustomerNum;
        public string CustomerName;
        public string CustomerAddress;
        public string IsAdmin = null;
        public string CustomerID;
        public string CustomerPw;
        public string Phone;

        public frmWhenCreate()
        {
            InitializeComponent();
        }

        public Customer customerInfo 
        {
            get
            {
                return new Customer(CustomerNum,txtName.Text, txtAddress.Text, txtID.Text, IsAdmin, txtPwd.Text,txtPhone.Text);
            }
        }

        private void WhenCreate_Load(object sender, EventArgs e)
        {
        }

        private void btnInsert_Click(object sender, EventArgs e)        //등록
        {
            if (IsAdmin == null)
            {
                MessageBox.Show("계정의 종류를 반드시 선택해주세요.");
                return;
            }

            CustomerDB db = new CustomerDB();
            db.Insert(customerInfo);
            db.Dispose();

            MessageBox.Show("등록이 완료되었습니다.");
            this.Close();
        }
        private void txtCheckingPwd_TextChanged(object sender, EventArgs e)
        {
            //유효성체크
            if (txtPwd.Text != txtCheckingPwd.Text)
            {
                errorProvider1.SetError(txtCheckingPwd, "비밀번호가 일치하지 않습니다.");       
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void rbtnS_Click(object sender, EventArgs e)
        {
            IsAdmin = "0";
        }

        private void rbtnA_Clicked(object sender, EventArgs e)
        {
            IsAdmin = "1";
        }
    }
}
