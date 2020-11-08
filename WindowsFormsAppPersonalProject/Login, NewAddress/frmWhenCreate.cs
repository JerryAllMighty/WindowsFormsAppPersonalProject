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
using System.IO;

namespace WindowsFormsAppPersonalProject
{
    public partial class frmWhenCreate : Form
    {
        public string CustomerNum;
        public string CustomerName;
        public string CustomerAddress;
        public string IsAdmin = "N";
        public string CustomerID;
        public string CustomerPw;
        public string Phone;
        public string CustomerEmail;
        public string CustomerImage;

        bool IDChecked = false;
        public frmWhenCreate()
        {
            InitializeComponent();
        }

        public Customer customerInfo
        {
            get
            {
                return new Customer(CustomerNum, txtName.Text, txtAddress.Text, txtID.Text,
                                        IsAdmin, txtPwd.Text, txtPhone.Text, txtEmail.Text + cbxEmail.Text, CustomerImage);
            }
        }

        private void WhenCreate_Load(object sender, EventArgs e)
        {
        }

        private void btnInsert_Click(object sender, EventArgs e)        //등록
        {
            if (!IDChecked)
            {
                MessageBox.Show("ID 중복 체크를 반드시 실시하여 주세요.");
                return;
            }


            CustomerDB db = new CustomerDB();
            if (db.Insert(customerInfo))
            {
                MessageBox.Show("등록이 완료되었습니다.");
                this.Close();
            }
            else { MessageBox.Show("등록이 비정상적으로 종료되었습니다. 다시 시도하여 주세요."); }
            db.Dispose();


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

        private void btnPwdSearchHint_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.jpeg;*.jpg;*.png;*.gif;*.bmp|*.jpeg;*.jpg;*.png;*.gif;*.bmp)";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlg.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Tag = dlg.FileName;
            }

            try
            {
                string sPath = $"ProfileImage/{CustomerID}";
                string localFile = pictureBox1.Tag.ToString();
                string sExt = localFile.Substring(localFile.LastIndexOf('.'));
                string newFileName = DateTime.Now.ToString("yyyyMMdd") + sExt;
                string destFileName = Path.Combine(sPath, newFileName);

                DirectoryInfo dir = new DirectoryInfo(sPath);
                if (!dir.Exists)
                {
                    dir.Create();
                }

                File.Copy(localFile, destFileName, true);
                CustomerImage = destFileName;

            }
            catch (Exception)
            { }

        }       //사진 추가

        private void btnAddSearch_Click(object sender, EventArgs e)     //주소찾기
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)     //ID 중복체크
        {
            CustomerDB db = new CustomerDB();
            if (db.IdIterated(txtID.Text))
            {
                MessageBox.Show("이미 존재하는 아이디입니다. 다시 입력해주세요.");
                return;
            }
            else
            {
                MessageBox.Show("사용하실 수 있는 아이디입니다.");
                IDChecked = true;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //콤보박스에 이메일 주소들 넣어주기
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                MessageBox.Show("영문자나 숫자만 입력해주세요.");
                txtEmail.Text = "";
            }
        }
    }
}
