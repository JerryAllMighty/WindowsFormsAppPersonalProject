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
using WindowsFormsAppPersonalProject.DB;

namespace WindowsFormsAppPersonalProject
{
    public partial class WhenCreate : Form
    {
        string strConn = ConfigurationManager.ConnectionStrings["JerryBank"].ConnectionString;
        public static string kindOfAccount = null;
        public static string radioButton = null;

        //public Customer CustomerInfo
        //{
        //    get
        //    {
        //        return new Customer(txtName.Text, txtAddress.Text, txtID.Text, null, txtPwd.Text, txtPhone.Text);
        //    }

        //    set
        //    {
        //        txtName.Text = value.Name;
                



        //         }
        //}


        public WhenCreate()
        {
            InitializeComponent();
        }

        public string RadioButton {
            get {return radioButton; }
        }

        public string KindofAccount {
            get
            {
                if (radioButton == "Administrator")
                {
                    kindOfAccount = "ACustomerID";
                }
                else if (radioButton == "StandardMember")
                {
                    kindOfAccount = "sCustomerID";
                }
                return kindOfAccount; 
            }
        }

       
        private void WhenCreate_Load(object sender, EventArgs e)
        {
        }

        private void btnInsert_Click(object sender, EventArgs e)        //등록
        {
            if (radioButton == null)
            {
                MessageBox.Show("계정의 종류를 반드시 선택해주세요.");
                return;
            }

            CustomerDB db = new CustomerDB();
            //db.Insert(Customer cus);
            db.Dispose();

            MessageBox.Show("등록이 완료되었습니다.");
            this.Close();
        }

        private void rbtnA_CheckedChanged(object sender, EventArgs e)
        {
            radioButton = "Administrator";
        }

        private void rbtnS_CheckedChanged(object sender, EventArgs e)
        {
            radioButton = "StandardMember";
        }

        private void txtCheckingPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //유효성체크
            if (txtPwd.Text != txtCheckingPwd.Text)
            {
                errorProvider1.SetError(txtCheckingPwd, "비밀번호가 일치하지 않습니다.");        //왜 안사라지냐
            }
        }
    }
}
