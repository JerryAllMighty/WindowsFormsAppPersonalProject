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
    public partial class Login : Form
    {
        string str = ConfigurationManager.ConnectionStrings["JerryBank"].ConnectionString;
        Form1 main;
        static bool bFlag;
        bool haveChosen;
        

        public Login()
        {
            InitializeComponent();
        }

        public int Flag {       //회원용으로 로그인시 1을, 관리자용일 때 2를 반환하는 프로퍼티
            get 
            {
                return bFlag == true? 1:2; 
            } 
        }
        private void Login_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            bFlag = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 10)
            {
                progressBar1.Value = progressBar1.Value - 10;
            }

            else if (progressBar1.Value < 10)
            {
                timer1.Stop();
                MessageBox.Show("로그인 세션이 만료되었습니다. 다시 로그인해주세요.");
                txtPwd.Clear();
                txtID.Clear();
                txtID.Focus();
                
                if (main != null)
                    main.Close();
                this.Show();
                this.Activate();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!haveChosen)
            {
                  
                MessageBox.Show("회원용과 관리자용 중 하나를 선택해주세요.");
                e.Handled = true;
                return;
            }

        }


        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!haveChosen)
            {
                
                MessageBox.Show("회원용과 관리자용 중 하나를 선택해주세요.");
                e.Handled = true;
                return;
            }
            
            string id;
            if (bFlag)
            {
                id = "SCustomerID";
            }
            else { id = "ACustomerID"; }
            
            string sql = $"select {id}, CustomerPw from customers where {id} = '{txtID.Text}' and CustomerPw = '{txtPwd.Text}' ;";
            MySqlConnection conn = new MySqlConnection(str);
            MySqlCommand cmd = new MySqlCommand(sql,conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            

            if (e.KeyChar == 13)
            {
                //정보 확인
               
                if (reader.HasRows)       //계정이 DB에 존재할 때 로그인 성공    
                {
                   //timer1.Enabled = true;            //디자인 끝내고 나서 다시 주석 풀어주자 
                    timer1.Interval = 1000;
                    progressBar1.Value = 50;
                    main = new Form1(this);
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("ID나 비밀번호를 다시 한 번 확인해주십시오.");
                }
            }

            conn.Close();
        }

        private void 회원용ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menustrip1를 보이게 해야해
           bFlag = true;
            haveChosen = true;
        }

        private void 관리자용ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menustrip3를 보이게 해야해
            bFlag = false;
            haveChosen = true;
        }

        private void btnMakingAccount_Click(object sender, EventArgs e)
        {
            WhenCreate c1 = new WhenCreate();
            c1.Show();
            c1.Activate();
        }
    }
}
