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
namespace WindowsFormsAppPersonalProject
{
    public partial class WhenCreate : Form
    {
        string strConn = ConfigurationManager.ConnectionStrings["JerryBank"].ConnectionString;

        bool btnChoice;
        bool haveChosen;
        string kindOfAccount;

        public WhenCreate()
        {
            InitializeComponent();
        }

        private void WhenCreate_Load(object sender, EventArgs e)
        {
        }

        private void btnInsert_Click(object sender, EventArgs e)        //등록
        {
            if (!haveChosen)
            {
                MessageBox.Show("계정의 종류를 반드시 선택해주세요.");
                return;
            }

            if (btnChoice == true)
            {
                kindOfAccount = "ACustomerID";
            }
            else if (btnChoice == false)
            {
                kindOfAccount = "sCustomerID";
            }
            
               
           

            MySqlConnection conn = new MySqlConnection(strConn);
            string sql = $@"insert into customers (CustomerName, CustomerAddress, {kindOfAccount}, CustomerPw, CustomerPhone) 
                            values('{txtName.Text}', '{txtAddress.Text}', '{txtID.Text}', '{txtPwd.Text}', '{txtPhone.Text}') ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("등록이 완료되었습니다.");
            this.Close();
        }

        private void rbtnA_CheckedChanged(object sender, EventArgs e)
        {
            btnChoice = true;
            haveChosen = true;
        }

        private void rbtnS_CheckedChanged(object sender, EventArgs e)
        {
            btnChoice = false;
            haveChosen = true;
        }
    }
}
