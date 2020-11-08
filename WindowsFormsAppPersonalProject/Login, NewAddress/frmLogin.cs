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
using WindowsFormsAppPersonalProject;

namespace WindowsFormsAppPersonalProject
{
    public partial class frmLogin : Form
    {
        frmMain main;
        public string CustomerNum;
        public string CustomerName;
        public string CustomerAddress;
        public string CustomerID;
        public string IsAdmin;
        public string CustomerPw;
        public string Phone;
        public string CustomerEmail;
        public string CustomerImage;

        public frmLogin()
        {
            InitializeComponent();
        }
        #region 프로퍼티
        
        public Customer cusinfo 
        { 
            get 
            {
                return new Customer(CustomerNum, CustomerName, CustomerAddress, 
                                    CustomerID, IsAdmin, CustomerPw, Phone, CustomerEmail, CustomerImage);
            }
        }
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

       

        private void btnMakingAccount_Click(object sender, EventArgs e)     //회원가입 버튼
        {
            frmWhenCreate c1 = new frmWhenCreate();
            c1.Show();
            c1.Activate();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //엔터를 누르면 로그인 버튼을 누른 것과 동일한 효과
                btnLogin.PerformClick();
            }
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //유효성 체크
            
            if (e.KeyChar == 13)
            {
                //엔터를 누르면  로그인 버튼을 누른 것과 동일한 효과
                btnLogin.PerformClick();
            }

            
        }


        private void btnLogin_Click(object sender, EventArgs e)     //로그인 버튼 클릭
        {
            this.UseWaitCursor = true;
            if (string.IsNullOrEmpty(txtID.Text.Trim().Replace(" ", "")) || txtPwd.Text.Trim().Replace(" ", "").Length == 0)
            {
                MessageBox.Show("ID나 비밀번호는 입력해주십시오.");
                return;
            }

            CustomerDB db = new CustomerDB();
            DataTable dt = db.GetEveryData(txtID.Text, txtPwd.Text);

           

            if (FromDtToMember(dt))       //계정이 DB에 존재할 때 로그인 성공    
            {

                //timer1.Enabled = true;            //디자인 끝내고 나서 다시 주석 풀어주자 
                timer1.Interval = 1000;
                progressBar1.Value = 50;
                main = new frmMain(cusinfo);        //아이디와 비밀번호로 db에서 가져온 고객정보를 생성자로 전달
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("ID나 비밀번호를 다시 한 번 확인해주십시오.");
            }

            db.Dispose();
        }


        private bool FromDtToMember(DataTable dt)       //데이터 테이블을 로그인 폼의 멤버변수로 전해주기
        {
            try
            {
                CustomerNum = dt.Rows[0]["CustomerNum"].ToString();
                CustomerName = dt.Rows[0]["CustomerName"].ToString();
                CustomerAddress = dt.Rows[0]["CustomerAddress"].ToString();
                CustomerID = dt.Rows[0]["CustomerID"].ToString();
                IsAdmin = dt.Rows[0]["IsAdmin"].ToString();
                CustomerPw = dt.Rows[0]["CustomerPw"].ToString();
                Phone = dt.Rows[0]["CustomerPhone"].ToString();
                CustomerEmail = dt.Rows[0]["CustomerEmail"].ToString();
                CustomerImage = dt.Rows[0]["CustomerImage"].ToString();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
        }
    }
}
