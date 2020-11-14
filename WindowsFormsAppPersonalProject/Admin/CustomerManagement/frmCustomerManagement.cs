using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPersonalProject.CustomerManagement
{
    public partial class frmCustomerManagement : Form
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
        string IsResting;


        CheckBox headercheckbox = new CheckBox();
        DataTable dt;
        public frmCustomerManagement()
        {
            InitializeComponent();
        }

        public frmCustomerManagement(Customer cusinfo)
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
            IsResting = cusinfo.IsResting;
        }

        public Customer customerInfo
        {
            get
            {
                return new Customer(CustomerNum, CustomerName, CustomerAddress,
                                    CustomerID, IsAdmin, CustomerPw, Phone, CustomerEmail, CustomerImage);
            }
        }

        public Customer IscustomerResting
        {
            get
            {
                return new Customer(CustomerNum, CustomerName, CustomerAddress,
                                    CustomerID, IsAdmin, CustomerPw, Phone, CustomerEmail, CustomerImage, IsResting);
            }
        }

        public Message MsgInfo { get {return new Message(CustomerNum, dgvMember.CurrentRow.Cells[1].Value.ToString(), 
                                                    CustomerName, dgvMember.CurrentRow.Cells[2].Value.ToString(),"",""); } }
        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.Name = "chk";
            chk.HeaderText = "";
            chk.Width = 30;
            dgvMember.Columns.Add(chk);         //헤더박스 추가, 여기까지는 맨 뒤쪽에 체크박스가 추가된 상태

            Point headercelllocation = dgvMember.GetCellDisplayRectangle(-1, -1, true).Location;

            headercheckbox.Location = new Point(headercelllocation.X + 8, headercelllocation.Y + 1);
            headercheckbox.BackColor = Color.White;
            headercheckbox.Size = new Size(18, 18);
            headercheckbox.Click += Headercheckbox_Click;
            dgvMember.Controls.Add(headercheckbox);

            CommonUtil.SetinitGridView(dgvMember);

            CommonUtil.AddGridTextColumn(dgvMember, "고객번호", "CustomerNum");
            CommonUtil.AddGridTextColumn(dgvMember, "고객명", "CustomerName");
            CommonUtil.AddGridTextColumn(dgvMember, "고객주소", "CustomerAddress", 150);
            CommonUtil.AddGridTextColumn(dgvMember, "고객ID", "CustomerID");
            CommonUtil.AddGridTextColumn(dgvMember, "관리자여부", "IsAdmin");
            CommonUtil.AddGridTextColumn(dgvMember, "고객비밀번호", "CustomerPw", 120);
            CommonUtil.AddGridTextColumn(dgvMember, "연락처", "CustomerPhone");
            CommonUtil.AddGridTextColumn(dgvMember, "고객이메일", "CustomerEmail", 120);
            CommonUtil.AddGridTextColumn(dgvMember, "고객이미지경로", "CustomerImage", 120);
            CommonUtil.AddGridTextColumn(dgvMember, "휴면계좌여부", "IsResting", 150);

            CustomerDB db = new CustomerDB();
            dt = db.GetEveryData();

            if (dt != null)
            {
                dgvMember.DataSource = dt;
                dgvMember.ClearSelection();
            }


        }

        private void Headercheckbox_Click(object sender, EventArgs e)
        {
            dgvMember.EndEdit();

            foreach (DataGridViewRow row in dgvMember.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                chk.Value = headercheckbox.Checked;
            }

        }

        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //전체 0번째 checkBox가 체크해제된 것이 하나라도 있다면, 헤더체크박스를 false로
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                dgvMember.EndEdit();

                bool ischecked = true;
                foreach (DataGridViewRow row in dgvMember.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["chk"].EditedFormattedValue) == false)
                    {
                        ischecked = false;
                        break;
                    }
                }
                headercheckbox.Checked = ischecked;
            }
        }

        private void dgvMember_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //DataSource를 set했을때, 바인딩이 완료되고, 우리눈에 보이기 전
            //for 반복문으로 loop 돌면서 값체크해서 색상변경

            for (int i = 0; i < dgvMember.Rows.Count; i++)
            {
                if (i == 0 || i % 2 == 0) //짝수마다 색칠해주기^~^
                {
                    dgvMember[1, i].Style = new DataGridViewCellStyle {ForeColor = Color.Red };
                        
                }
            }
        }

        private void dgvMember_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)     //마우스 우클릭 했을 때 컨텍스트 메뉴 스크립을 보여주기!
            {
                dgvMember.Rows[e.RowIndex].Selected = true;
                dgvMember.CurrentCell = dgvMember[1, e.RowIndex];
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void 수정ToolStripMenuItem_Click(object sender, EventArgs e)  //컨텍스트메뉴 스트립 중 수정을 눌렀을 때
        {
            if (MessageBox.Show("해당 고객의 정보를 수정하시겠습니까?", "고객 정보 수정", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string selectedCustomerNum = dgvMember.CurrentRow.Cells[1].Value.ToString();       //선택된 사람의 아이디와 비번
                

                CustomerDB db = new CustomerDB();
                Customer SelectedCustomerInfo =  db.DataSelected(selectedCustomerNum);
                if (SelectedCustomerInfo != null)
                {
                    frmUpdate frm = new frmUpdate(SelectedCustomerInfo);        //위의 정보를 이용해서 customer타입으로 받아오기
                    frm.Show();
                    frm.Activate();
                }
                //수정이 끝나고 나서 수정 창이 닫히면 고객관리 폼에 자동으로 갱신된 데이터가 떴으면 좋겠어
                dgvMember.DataSource = db.GetEveryData();
            }
        }

       

        private void 메세지보내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSendingMessage frm = new frmSendingMessage(MsgInfo);
            frm.Show();
            frm.Activate();
        }

        private void 관리자로임명ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDB db = new CustomerDB();
                bool result = db.UpdateIsAdmin("Y", dgvMember.CurrentRow.Cells[1].Value.ToString());
                if (result)
                {
                    MessageBox.Show("성공적으로 관리자로 임명되었습니다.");
                }
                else 
                {
                    MessageBox.Show("임명 과정에 오류가 있었습니다. 다시 시도해주시기 바랍니다.");
                }
                db.Dispose();
            }
            catch (Exception)
            { }
        }

        private void 일반회원으로변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDB db = new CustomerDB();
                bool result = db.UpdateIsAdmin("N", dgvMember.CurrentRow.Cells[1].Value.ToString());
                if (result)
                {
                    MessageBox.Show("성공적으로 일반 회원으로 변경되었습니다.");
                }
                else
                {
                    MessageBox.Show("변경 과정에 오류가 있었습니다. 다시 시도해주시기 바랍니다.");
                }
                db.Dispose();
            }
            catch (Exception)
            { }
        }

        private void 휴면계좌로전환ToolStripMenuItem_Click(object sender, EventArgs e)     //우클릭해서 펼친 컨텍스트메뉴스트립의 고객 번호를 넘겨주어 정보를 수정한다
        {
            CustomerDB db = new CustomerDB();
            if (db.SetRest(dgvMember.CurrentRow.Cells[1].Value.ToString()))
            {
                db.Dispose();
                MessageBox.Show("휴면 계좌로 전환에 성공하였습니다.");
                return;
            }
            else
            {
                db.Dispose();
                MessageBox.Show("휴면 계좌로 전환에 실패하였습니다. 다시 시도하여주십시오.");
            }
           

        }

        private void 휴면계좌해제ToolStripMenuItem_Click(object sender, EventArgs e)  //우클릭해서 펼친 컨텍스트메뉴스트립의 고객 번호를 넘겨주어 정보를 수정한다
        {
            CustomerDB db = new CustomerDB();
            if (db.UnSetRest(dgvMember.CurrentRow.Cells[1].Value.ToString()))
            {
                db.Dispose();
                MessageBox.Show("휴면 계정이 해제되었습니다.");
                return;
            }
            else
            {
                db.Dispose();
                MessageBox.Show("휴면 계좌 해제에 실패하였습니다. 다시 시도하여주십시오.");
            }
        }
    }
}
