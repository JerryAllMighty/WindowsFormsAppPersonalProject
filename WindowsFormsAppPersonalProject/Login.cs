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
    public partial class Login : Form
    {
        Form1 main;

        public Login()
        {
            InitializeComponent();
        }

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
                textBox3.Clear();
                textBox2.Clear();
                textBox2.Focus();
                
                if (main != null)
                    main.Close();
                this.Show();
                this.Activate();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }


        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //정보 확인

                if (true)       //로그인 성공
                {
                   // timer1.Enabled = true;            //디자인 끝내고 나서 다시 주석 풀어주자 
                    timer1.Interval = 1000;
                    progressBar1.Value = 50;
                    main = new Form1(this);
                    this.Hide();
                    main.Show();

                }
                else
                {
                    MessageBox.Show("입력값이 올바르지 않습니다. 다시 시도해주십시오.");
                }
            }
        }
    }
}
