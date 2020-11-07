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
    public partial class frmCustomer : Form
    {
        public string CustomerNum;
        public string CustomerName;
        public string CustomerAddress;
        public string CustomerID;
        public string IsAdmin;
        public string CustomerPw;
        public string Phone;
        public string CustomerEmail;
        public string CustomerImage;

        frmMain main; 


        public frmCustomer()
        {
            InitializeComponent();
        }
        public frmCustomer(Customer cusinfo)
        {
            InitializeComponent();
            CustomerNum = cusinfo.CustomerNum;
            CustomerName = cusinfo.CustomerName;
            CustomerAddress = cusinfo.CustomerAddress;
            CustomerID = cusinfo.CustomerID;
            IsAdmin = cusinfo.IsAdmin;
            CustomerPw = cusinfo.CustomerPw;
            Phone = cusinfo.Phone;
            CustomerEmail = cusinfo.CustomerEmail;
            CustomerImage = cusinfo.CustomerImage;
        }
         
        public Customer CustomerInfo 
        {
            get
            {
                return new Customer(CustomerNum, CustomerName, CustomerAddress,
                                        CustomerID, IsAdmin, CustomerPw, Phone, CustomerEmail, CustomerImage);
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            main = (frmMain)this.MdiParent;

            CommonUtil.SetinitGridView(dgvMember);
            CommonUtil.AddGridTextColumn(dgvMember, "고객번호", "CustomerNum");
            CommonUtil.AddGridTextColumn(dgvMember, "고객명", "CustomerName");
            CommonUtil.AddGridTextColumn(dgvMember, "고객주소", "CustomerAddress", 150);
            CommonUtil.AddGridTextColumn(dgvMember, "고객ID", "CustomerID");
            CommonUtil.AddGridTextColumn(dgvMember, "관리자여부", "IsAdmin");
            CommonUtil.AddGridTextColumn(dgvMember, "고객비밀번호", "CustomerPw");
            CommonUtil.AddGridTextColumn(dgvMember, "연락처", "CustomerPhone");
            CommonUtil.AddGridTextColumn(dgvMember, "고객이메일", "CustomerEmail");
            CommonUtil.AddGridTextColumn(dgvMember, "고객이미지경로", "CustomerImage");
        }

        private void button3_Click(object sender, EventArgs e) //계좌생성 클릭
        {
            frmNewAccount na = new frmNewAccount(CustomerInfo);
            na.Show();
            na.Activate();

        }
          
        private void btnSelect_Click(object sender, EventArgs e)        //조회
        {
            CustomerDB db = new CustomerDB();
           
            if (db.GetEveryData(CustomerInfo.CustomerID, CustomerInfo.CustomerPw) != null)
            {
                dgvMember.DataSource = db.GetEveryData(CustomerInfo.CustomerID, CustomerInfo.CustomerPw);
            }
            else
            {
                MessageBox.Show("값을 불러오지 못했습니다.");
            }

            
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)     //계정 삭제
        {
            if (MessageBox.Show("정말로 계정을 삭제하시겠습니까?", "계정 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CustomerDB db = new CustomerDB();
                db.Delete(CustomerInfo);
                db.Dispose();
                this.Close();
                main.Close();
                frmLogin login = new frmLogin();        //새로운 계정으로 로그인하게 만들기
                login.Show();
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)        //수정
        {
            //DB에서 고객 정보를 가져와서 업데이트 생성자로 넘겨주기

            frmUpdate frm = new frmUpdate(CustomerInfo);
            frm.Show();
            frm.Activate();
        }
    }
}
