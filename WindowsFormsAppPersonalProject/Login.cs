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
using WindowsFormsAppPersonalProject.DB;

namespace WindowsFormsAppPersonalProject
{
    public partial class Login : Form
    {
        string str = ConfigurationManager.ConnectionStrings["JerryBank"].ConnectionString;
        Form1 main;
        public static string id = null;
       
        public Login()
        {
            InitializeComponent();
        }
        #region 프로퍼티
        public string ID { get { return id; }}
        public string TextID { get {return txtID.Text; } }
        public string TextPwd { get{return txtPwd.Text; } }
#endregion 프로퍼티


        private void Login_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
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

        private void 회원용ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menustrip1를 보이게 해야해
            id = "SCustomerID";
        }

        private void 관리자용ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menustrip3를 보이게 해야해
            id = "ACustomerID";
        }

        private void btnMakingAccount_Click(object sender, EventArgs e)     //회원가입 버튼
        {
            WhenCreate c1 = new WhenCreate();
            c1.Show();
            c1.Activate();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //유효성 체크
            if (id == null)
            {

                MessageBox.Show("회원용과 관리자용 중 하나를 선택해주세요.");
                e.Handled = true;
                return;
            }
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //유효성 체크
            if (id == null)
            {
                MessageBox.Show("회원용과 관리자용 중 하나를 선택해주세요.");
                e.Handled = true;
                return;
            }

            CustomerDB db = new CustomerDB();
            db.GetEveryData();


            if (e.KeyChar == 13)
            {
                //정보 확인

                if (db.GetEveryData() != null)       //계정이 DB에 존재할 때 로그인 성공    
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

            db.Dispose();
        }
    }
}
