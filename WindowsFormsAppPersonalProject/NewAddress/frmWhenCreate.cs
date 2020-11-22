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
        string CustomerNum;
        string CustomerName;
        string CustomerAddress;
        string IsAdmin = "N";
        string CustomerID;
        string CustomerPw;
        string Phone;
        string CustomerEmail;
        string CustomerImage;

        bool IDChecked = false;
        

        public frmWhenCreate()
        {
            InitializeComponent();
        }

        public Customer customerInfo
        {
            get
            {
                return new Customer(CustomerNum, txtName.Text, CustomerAddress + "/" +txtAddrDetail.Text, txtID.Text,
                                        IsAdmin, txtPwd.Text, txtPhone.Text, txtEmail.Text + cbxEmail.Text, CustomerImage);
            }
        }


        public string FindAddr { get { return CustomerAddress; }
            set {
                CustomerAddress = value;
                 txtZipNo.Text = CustomerAddress.Substring(0, CustomerAddress.IndexOf('/'));
                txtAddress.Text = CustomerAddress.Substring(CustomerAddress.IndexOf('/')+1);
            } 
        }
        private void WhenCreate_Load(object sender, EventArgs e)
        {
        }

        private void btnInsert_Click(object sender, EventArgs e)        //등록
        {
            if (txtAddrDetail.Text.Trim().Replace(" ","").Length < 1)
            {
                MessageBox.Show("상세 주소를 반드시 작성해주세요.");
                return;
            }

            if (!IDChecked)
            {
                MessageBox.Show("ID 중복 체크를 반드시 실시하여 주세요.");
                return;
            }
            //name. phone addr, Id, pwd, chkpwd
            if (txtName.Text.Trim().Replace(" ", "").Length < 1 || txtPhone.Text.Trim().Replace(" ", "").Length < 1 ||
                txtAddress.Text.Trim().Replace(" ", "").Length < 1 || txtPwd.Text.Trim().Replace(" ", "").Length < 1 ||
                txtID.Text.Trim().Replace(" ", "").Length < 1 || txtCheckingPwd.Text.Trim().Replace(" ", "").Length < 1 ) //필수 입력인 항목들 입력 안 할 시 꼭 하게 만들기
            {
                MessageBox.Show("*표시가 있는 입력 항목들은 필수 입력입니다. 꼭 작성해주세요.");
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
        private void txtCheckingPwd_TextChanged(object sender, EventArgs e)     //비밀번호확인 체크
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

        private void btnAddPic_Click(object sender, EventArgs e)        //사진 추가
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
            frmFindAddr frm = new frmFindAddr(this);
            frm.Show();
            frm.Activate();
        }

        private void btnCheck_Click(object sender, EventArgs e)     //ID 중복체크
        {
            CustomerDB db = new CustomerDB();
            if (db.IdIterated(txtID.Text))
            {
                MessageBox.Show("이미 존재하는 아이디입니다. 다시 입력해주세요.");
                txtID.Text = "";
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
            //영문자나 숫자 이외의 입력 사항들 걸러주기
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                MessageBox.Show("영문자나 숫자만 입력해주세요.");
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)      //숫자만 입력받게 체크
        {
            if (!CommonUtil.NumberCheck(e.KeyChar))
                e.Handled = true;
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)        //입력하지 못하게 하기
        {
            MessageBox.Show("반드시 주소 검색을 해주세요.");
            e.Handled = true;
        }

        private void txtZipNo_KeyPress(object sender, KeyPressEventArgs e)      //입력하지 못하게 하기
        {
            MessageBox.Show("반드시 주소 검색을 해주세요.");
            e.Handled = true;
        }

        private void cbxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("값을 직접 입력하실 수 없습니다. 지정된 값 중에서 선택해주세요.");
            e.Handled = true;
            return;
        }
    }
}
