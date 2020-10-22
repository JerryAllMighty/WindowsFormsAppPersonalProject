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

        public WhenCreate()
        {
            InitializeComponent();
        }

        private void DataRetrieve()
        {
            MySqlConnection conn = new MySqlConnection(strConn);
            string sql = "select CustomerName, CustomerAddress, CustomerID, CustomerPw, CustomerPhone from customers;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();
            conn.Open();
            da.Fill(ds, "customer");
            conn.Close();

            dgvMember.DataSource = ds.Tables["customer"];

            txtID.Text = txtName.Text = txtPwd.Text = "";
            txtID.Enabled = true;



        }

        private void WhenCreate_Load(object sender, EventArgs e)
        {
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string id;
            Login log = new Login();
            if (log.Flag == 1)
            {
                id = "SCustomerID";
            }
            else
            {
                id = "ACustomerID";
            }

            MySqlConnection conn = new MySqlConnection(strConn);
            string sql = $@"insert into customers (CustomerName, CustomerAddress, {id}, CustomerPw, CustomerPhone) 
                            values('{txtName.Text}', '{txtAddress.Text}', '{txtID.Text}', '{txtPwd.Text}', '{txtPhone.Text}') ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("등록이 완료되었습니다.");
            this.Close();
        }
    }
}
