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
        string CustomerNum;
        string CustomerName;
        string CustomerAddress;
        string CustomerID;
        string IsAdmin;
        string CustomerPw;
        string Phone;
        string CustomerEmail;
        string CustomerImage;

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
            CommonUtil.AddGridTextColumn(dgvMember, "고객이메일", "CustomerEmail", 180);
            CommonUtil.AddGridTextColumn(dgvMember, "고객이미지경로", "CustomerImage", 200        );
            CommonUtil.AddGridTextColumn(dgvMember, "휴면계좌여부", "IsResting", 150);

            //트리뷰 바인딩할 때 데이터 소스 주고 나서 트리뷰1.익스팬드하즈아
            CustomerDB db = new CustomerDB();
             DataTable dt = db.GetEveryData2(CustomerNum);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                TreeNode node = new TreeNode();

                node.Name =dt.Columns[i].ToString() ;
                node.Text = dt.Columns[i].ToString();
                node.Tag = dt.Columns[i].ToString();
                treeView1.Nodes.Add(node);
               
                TreeNode node2 = new TreeNode();
                node2.Name = dt.Rows[0][i].ToString();
                node2.Text = dt.Rows[0][i].ToString();
                node2.Tag = dt.Rows[0][i].ToString();
                node.Nodes.Add(node2);
                
            }
            treeView1.ExpandAll();
            
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
           
            if (db.GetEveryData2(CustomerNum) != null)
            {
                dgvMember.DataSource = db.GetEveryData2(CustomerNum);
            }
            else
            {
                MessageBox.Show("값을 불러오지 못했습니다.");
            }

            
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)     //계정 휴면 전환
        {
            if (MessageBox.Show("정말로 계정을 휴면 계좌로 전환하시겠습니까?", "계정 전환", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CustomerDB db = new CustomerDB();
                db.SetRest(CustomerNum);
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
