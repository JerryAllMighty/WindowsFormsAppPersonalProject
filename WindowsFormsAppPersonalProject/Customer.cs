using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppPersonalProject
{
    public partial class Customer : Form
    {
        string strConn = ConfigurationManager.ConnectionStrings["JerryBank"].ConnectionString;

        public Customer()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WhenCreate cr = new WhenCreate();
            cr.Show();
            cr.Activate();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            CommonUtil.SetinitGridView(dgvMember);
            CommonUtil.AddGridTextColumn(dgvMember, "고객번호", "CustomerNum");
            CommonUtil.AddGridTextColumn(dgvMember, "고객명", "CustomerName");
            CommonUtil.AddGridTextColumn(dgvMember, "고객주소", "CustomerAddress");
            CommonUtil.AddGridTextColumn(dgvMember, "연락처", "CustomerPhone");

            MySqlConnection conn = new MySqlConnection(strConn);
            string sql = "select CustomerNum, CustomerName, CustomerAddress, CustomerPhone from customers";

            MySqlDataAdapter da = new MySqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();
            conn.Open();
            da.Fill(ds, "customer");
            conn.Close();

            dgvMember.DataSource = ds.Tables["customer"];
        }

       
    }
}
