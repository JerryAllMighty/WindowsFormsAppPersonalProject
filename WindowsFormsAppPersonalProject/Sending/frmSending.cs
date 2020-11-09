using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPersonalProject
{
    public partial class frmSending : Form
    {
        StringBuilder sb = new StringBuilder();

       string CustomerNum;
       string CustomerName;
       string CustomerAddress;
       string CustomerID;
       string IsAdmin;
       string CustomerPw;
       string Phone;
       string CustomerEmail;
       string CustomerImage;

        DataTable dt;

        public frmSending()
        {
            InitializeComponent();
        }
        public frmSending(Customer cusinfo)
        {
            InitializeComponent();
            CustomerNum = cusinfo.CustomerNum;
            CustomerName = cusinfo.CustomerName;
            CustomerAddress = cusinfo.CustomerAddress;
            CustomerID = cusinfo.CustomerID;
            IsAdmin = cusinfo.IsAdmin;
            CustomerPw = cusinfo.CustomerPw;
            Phone = cusinfo.Phone;
        }

        public Customer CustomerInfo
        {
            get
            {
                return new Customer(CustomerNum, CustomerName, CustomerAddress,
                                        CustomerID, IsAdmin, CustomerPw, Phone, CustomerEmail, CustomerImage);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NumericCheck(object sender, KeyPressEventArgs e)
        {
            bool bChange = char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '\b';
            TextBox temp = (TextBox)sender;
            if (!bChange)       //숫자만 입력하게 체크
            {
                errorProvider1.SetError(temp, "숫자만 입력하세요.");
                e.Handled = true;
            }

            
            switch(e.KeyChar.ToString())
                {
                case "1":
                    sb.Append(e.KeyChar.ToString().Replace('1', '일'));
                    break;
                case "2":
                    sb.Append(e.KeyChar.ToString().Replace('2', '이'));
                    break;
                case "3":
                    sb.Append(e.KeyChar.ToString().Replace('3', '삼'));
                    break;
                case "4":
                    sb.Append(e.KeyChar.ToString().Replace('4', '사'));
                    break;
                case "5":
                    sb.Append(e.KeyChar.ToString().Replace('5', '오'));
                    break;
                case "6":
                    sb.Append(e.KeyChar.ToString().Replace('6', '육'));
                    break;
                case "7":
                    sb.Append(e.KeyChar.ToString().Replace('7', '칠'));
                    break;
                case "8":
                    sb.Append(e.KeyChar.ToString().Replace('8', '팔'));
                    break;
                case "9":
                    sb.Append(e.KeyChar.ToString().Replace('9', '구'));
                    break;
                case "0":
                    sb.Append(e.KeyChar.ToString().Replace('0', '영'));
                    break;

            }       //한글로 숫자를 치환해서 보여주기

            

            lblCurrentOver.Text = $"{sb.ToString()}원";


        }

        

        private void IsNumeric(object sender, KeyPressEventArgs e)
        {
            bool bChange = char.IsNumber(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '\b';
            TextBox temp = (TextBox)sender;
            if (!bChange)
            {
                errorProvider1.SetError(temp, "숫자만 입력하시기 바랍니다.");
                e.Handled = true;
            }
        }

        private void frmSending_Load(object sender, EventArgs e)
        {
            NormalAccountDB db = new NormalAccountDB();
            dt =  db.WhenYouSend();
            db.Dispose();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbxOutAcc.Items.Add(dt.Rows[i]["NAccountNum"]);
                cbxRecently.Items.Add(dt.Rows[i]["RecentlySentTo"].ToString());
            }
        }

        private void cbxOutAcc_SelectedValueChanged(object sender, EventArgs e)
        {
            //고른 일반계좌 번호의 금액
            
            txtCurrentLeftOver.Text = dt.Rows[cbxOutAcc.SelectedIndex]["CurrentMoney"].ToString();
        }

        private void comboBox3_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("입력하신 정보가 맞습니까?", "최종 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { 
            //db들어가서 입금계좌 정보에 해당하는 고객정보가져오라
            }
        }

        private void cbxRecently_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
