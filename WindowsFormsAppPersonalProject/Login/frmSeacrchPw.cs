using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPersonalProject
{
    public partial class frmSeacrchPw : Form
    {

        public frmSeacrchPw()
        {
            InitializeComponent();
        }


        private void SeacrchPw_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchPw_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDB db = new CustomerDB();

                //3가지 항목 비워두지 않게 체크
                if (txtID.Text.Trim().Replace(" ", "").Length < 1 || txtName.Text.Trim().Replace(" ", "").Length < 1 ||
                    txtEmail.Text.Trim().Replace(" ", "").Length < 1)
                {
                    MessageBox.Show("위의 3가지는 반드시 입력해주셔야합니다.");
                    return;
                }
                
                else
                {
                    if (!db.IdIterated(txtID.Text))     //입력한 아이디가 없는 경우
                    {
                        MessageBox.Show("입력하신 아이디와 일치하는 정보가 없습니다. 다시 확인하여 주세요.");
                        return;
                    }
                    else
                    {
                        //새로운 비밀번호를 난수로 생성해서
                        string newPwd = CreatePwd();

                        //새로운 비밀번호로 업데이트하고, 
                        if (db.UpdateNewPw(newPwd, txtID.Text))
                        { }
                        else { 
                            MessageBox.Show("비밀번호 초기화에 실패하였습니다.");
                            return;
                        }

                        //새로운 비밀번호를 이메일로 보내주는 것

                        if (SendMail(txtName.Text, txtEmail.Text, txtID.Text, newPwd))
                        {
                            MessageBox.Show("초기화된 비밀번호를  메일을 전송하였습니다.");

                        }
                        else 
                        { 
                            MessageBox.Show("메일 발송이 실패하였습니다.");
                            return;
                        }
                    }
                }
                this.Close();
               
            }
            catch (Exception)
            { }
        }


        private string CreatePwd()
        {
            Random rnd = new Random();
            

            StringBuilder sb = new StringBuilder();

            for (int  i = 0; i < 8; i++)
            {
                int var = rnd.Next(0, 36);
                if (var < 10)
                {
                    sb.Append(var.ToString());
                }
                else { sb.Append((char)(var + 55)); }
            
            }
            return sb.ToString();


        }       //새로운 8자리의 임의의 비밀번호를 메일로 발송


        private bool SendMail(string name, string email, string id, string newpwd)      //메일 전송 메서드
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new NetworkCredential("kimyoonmin@gmail.com", "wmf1535461");

                MailAddress To = new MailAddress(email);
                MailAddress from = new MailAddress("kimyoonmin@gmail.com");

                MailMessage msg = new MailMessage(from, To);
                msg.Subject = $"{name}님의 비밀번호 초기화 안내 메일입니다.";
                msg.Body = $"{name}님의 비밀번호는 {newpwd}로 초기화되었습니다.";
                msg.SubjectEncoding = Encoding.UTF8;
                msg.BodyEncoding = Encoding.UTF8;

                client.Send(msg);
                msg.Dispose();

                return true;
            }
            catch (Exception)
            { return false; }
        }
    }
}
