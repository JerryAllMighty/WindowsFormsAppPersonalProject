using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPersonalProject
{
    public partial class frmUpdate : Form
    {
        string CustomerNum;
        string ChangedName;
        string ChangedAddress;
        string CustomerID;
        string ChangedID;
        string IsAdmin;
        string ChangedPw;
        string ChangedPhone;
        //string CustomerEmail;
        string CustomerImage;
        string ChangedEmail;
        bool bFlag = false;


        public frmUpdate()
        {
            InitializeComponent();
        }
        public frmUpdate(Customer cus)
        {
            InitializeComponent();
            CustomerNum = cus.CustomerNum;
            ChangedName = txtName.Text = cus.CustomerName;
            ChangedAddress = txtAddress.Text = cus.CustomerAddress;
            CustomerID = ChangedID = txtID.Text = cus.CustomerID;
            ChangedPw = txtPwd.Text = cus.CustomerPw;
            txtCheckingPwd.Text = cus.CustomerPw;
            ChangedPhone = txtPhone.Text = cus.Phone;
            IsAdmin = cus.IsAdmin;
            txtEmail.Text = cus.CustomerEmail.Substring(0, cus.CustomerEmail.IndexOf('@') + 1);
            cbxEmail.Text = cus.CustomerEmail.Substring(cus.CustomerEmail.IndexOf('@'));
            ChangedEmail = txtEmail.Text + cbxEmail.Text;
            CustomerImage = cus.CustomerImage;


        }

        public Customer CustomerInfo        //변경을 하면 그 값을 생성 파라미터로 넘겨준다
        {
            get
            {
                return new Customer(CustomerNum, ChangedName, ChangedAddress,
                                    ChangedID, IsAdmin, ChangedPw, ChangedPhone, ChangedEmail, CustomerImage);
            }
        }
        private void frmUpdate_Load(object sender, EventArgs e)
        {
            
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //이름, 주소, 연락처, 이메일, 아이디, 비번 입력했는지 필수 요소들 체크
            if (txtName.TextLength < 1 || txtAddress.Text.Length < 1 || txtPhone.Text.Length < 1
                || txtEmail.Text.Length < 1 || txtID.Text.Length < 1 || txtPwd.Text.Length < 1)
            {
                MessageBox.Show("필수 입력 사항들은 반드시 입력해주셔야합니다.");
                return;
            }
            //이메일 유효성 체크 입력칸에 @를 입력했는지
            if (txtEmail.Text.Contains('@'))
            {
                MessageBox.Show("상세 메일 주소는 입력하지 마시고 아래에서 선택해주세요.");
                return;
            }
            //상세 메일 주소를 선택 안 했을 때 체크
            if (cbxEmail.Text.Length < 1)
            {
                MessageBox.Show("상세 메일 주소는 꼭 선택해주세요.");
                return;
            }

                //아이디 중복체크는 했는지 유효성 체크

                if (!bFlag)
            {
                MessageBox.Show("ID 중복체크를 해주세요.");
                return;
            }

            try
            {
                CustomerDB db = new CustomerDB();
                if (db.Update(CustomerInfo))
                {
                    MessageBox.Show("변경이 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("변경에 실패했습니다. 다시 시도해주세요.");
                }
                db.Dispose();
                
                this.Close();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            ChangedName = txtName.Text;
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            ChangedAddress = txtAddress.Text;
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            ChangedID = txtID.Text;
        }

        private void txtPwd_Leave(object sender, EventArgs e)
        {
            ChangedPw = txtPwd.Text;
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            ChangedPhone = txtPhone.Text;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtCheckingPwd_TextChanged_1(object sender, EventArgs e)
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

        private void btnAddPic_Click(object sender, EventArgs e)        //사진 변경
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif|*.jpg;*.jpeg;*.png;*.bmp;*.gif)";
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
                string ext = localFile.Substring(localFile.IndexOf('.'));
                string newFileName = DateTime.Now.ToString("yyyyMMdd") + ext;
                string destFileName = Path.Combine(sPath, newFileName);

                DirectoryInfo info = new DirectoryInfo(sPath);
                if (!info.Exists)
                {
                    info.Create();
                }
                File.Copy(localFile, destFileName, true);
                CustomerImage = destFileName;
            }
            catch (Exception)
            { }

        }

        private void btnCheck_Click(object sender, EventArgs e)     //아이디 중복확인
        {
            if (ChangedID == CustomerID)
            {
                MessageBox.Show("사용하고 계셨던 아이디는 계속 사용하실 수 있습니다.");
                bFlag = true;
            }
            else
            {
                CustomerDB db = new CustomerDB();
                if (db.IdIterated(ChangedID))
                {
                    MessageBox.Show("현재 아이디는 이미 사용중입니다. 다른 아이디를 입력해주세요.");
                }
                else
                {

                    MessageBox.Show("현재 아이디는 사용 가능한 아이디입니다.");
                    bFlag = true;
                }
            }
        }

        private void cbxEmail_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxEmail.Text.Length > 1)        //뭐라도 골랐을 때
            {
                if (txtEmail.Text.Contains('@'))    //콤보박스에서 값을 선택해주면 텍스트는 @뒤를 잘라내주기
                {
                     txtEmail.Text = txtEmail.Text.Remove(txtEmail.Text.IndexOf('@'));
                    ChangedEmail = txtEmail.Text + cbxEmail.Text;
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ChangedEmail = txtEmail.Text + cbxEmail.Text;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e) //숫자만 입력 받게 체크
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("숫자만 입력해주시기 바랍니다.");
            }
        }
    }
}
