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

        public frmWhenCreate()
        {
            InitializeComponent();
        }

        public Customer customerInfo 
        {
            get
            {
                return new Customer(CustomerNum,txtName.Text, txtAddress.Text, txtID.Text,
                                        IsAdmin, txtPwd.Text,txtPhone.Text, CustomerEmail, CustomerImage);
            }
        }

        private void WhenCreate_Load(object sender, EventArgs e)
        {
        }

        private void btnInsert_Click(object sender, EventArgs e)        //등록
        {
            
            CustomerDB db = new CustomerDB();
            db.Insert(customerInfo);
            db.Dispose();

            MessageBox.Show("등록이 완료되었습니다.");
            this.Close();
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

        private void txtEmail_TextChanged(object sender, EventArgs e)       //이메일 
        {
            //콤보박스에 이메일 주소들 넣어주기

            //유효성체크
            if (cbxEmail.SelectedItem.ToString() == "직접 작성")
            {
                if (!txtEmail.Text.Contains('@'))
                {
                    lblCheckEmail.Visible = true;
                    lblCheckEmail.Text = "직접 작성은 반드시 이메일 형식으로 표기하셔야 합니다.";
                    CustomerEmail=  txtEmail.Text;
                }
            }
            else 
            {
                if (true)  //영문이나 숫자 아닐시
                {
                    lblCheckEmail.Text = ("영문이나 숫자만 입력가능합니다.");
                    CustomerEmail = txtEmail.Text + cbxEmail.SelectedItem.ToString();
                }
            }
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


            }
            catch (Exception)
            { }

        }       //사진 추가

        private void btnAddSearch_Click(object sender, EventArgs e)     //주소찾기
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)     //ID 중복체크
        {

        }
    }
}
