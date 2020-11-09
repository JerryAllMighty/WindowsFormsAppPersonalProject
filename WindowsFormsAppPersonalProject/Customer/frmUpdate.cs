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
    public partial class frmUpdate : Form
    {
        public string CustomerNum;
        public string ChangedName;
        public string ChangedAddress;
        public string ChangedID;
        public string IsAdmin;
        public string ChangedPw;
        public string ChangedPhone;
        public string CustomerEmail;
        public string CustomerImage;
        public string ChangedEmail;

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
            ChangedID = txtID.Text = cus.CustomerID;
            ChangedPw = txtPwd.Text = cus.CustomerPw;
            txtCheckingPwd.Text = cus.CustomerPw;
            ChangedPhone = txtPhone.Text = cus.Phone;
            IsAdmin = cus.IsAdmin;
            ChangedEmail = txtEmail.Text = cus.CustomerEmail;
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
            try
            {
                CustomerDB db = new CustomerDB();
                db.Update(CustomerInfo);
                db.Dispose();
                MessageBox.Show("변경이 완료되었습니다.");
                this.Close();
            }
            catch(Exception)
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
            ChangedEmail = txtEmail.Text;
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
    }
}
