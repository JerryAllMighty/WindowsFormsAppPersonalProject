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
    public partial class frmDepositExtension : Form
    {
        string Duration;
        string CustomerNum;
        string DAccountNum;
        string DateCreated;
        string CustomerName;
        string KindOfAcc;
        string AmountOfDeposit;
        string OutAccount;
        string OutAccountPw;
        string NewPwd;

        DataTable dt;

        public frmDepositExtension(DataTable dt, Customer cus)
        {
            InitializeComponent();
            this.dt = dt;
            CustomerNum= cus.CustomerNum;
            CustomerName = cus.CustomerName;

        }


        public DepositAccount depositInfoForExtension       //예금 계좌에 넘겨줄 때 사용
        {
            get
            {
                return new DepositAccount(CustomerNum, CustomerName, DAccountNum,
                              txtOutAccount.Text, txtOutPwd.Text, txtNewPwd.Text,
                               cbxduration.SelectedItem.ToString().Substring(0, cbxduration.SelectedItem.ToString().IndexOf('개')));
            }
        }

        private void frmDepositExtension_Load(object sender, EventArgs e)
        {
            dgvMemver.DataSource = dt;
        }

        private void btndepositExtension_Click(object sender, EventArgs e)
        {
            //데이터그리드 뷰에서 연장할 예금을 꼭 클릭하게 하기
            if (dgvMemver.SelectedRows.Count < 1)
            {
                MessageBox.Show("반드시 위의 만기 예정 목록에서 하나를 더블클릭해주세요.");
                return;
            }
            //연장 기간을 꼭 선택하게 체크
            if (cbxduration.Text.Length < 1)
            {
                MessageBox.Show("연장할 기간은 꼭 선택해주셔야합니다.");
                return;
            }
            DepositAccountDB db = new DepositAccountDB();
            if (!db.Update(depositInfoForExtension))
            {
                MessageBox.Show("예금 연장에 실패하였습니다.");
                return;
            }
            MessageBox.Show("성공적으로 예금 기간을 연장하였습니다.");
            db.Dispose();
            this.Close();
        }

        private void dgvMemver_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMemver.CurrentRow.Selected = true;
            DAccountNum = dgvMemver.CurrentRow.Cells[0].Value.ToString();
            txtCurrentMoney.Text = dgvMemver.CurrentRow.Cells[10].Value.ToString();
            txtOutAccount.Text = dgvMemver.CurrentRow.Cells[7].Value.ToString();
            txtOutPwd.Text = dgvMemver.CurrentRow.Cells[8].Value.ToString();
            txtNewPwd.Text = dgvMemver.CurrentRow.Cells[9].Value.ToString();
            txtCheckNewPwd.Text = dgvMemver.CurrentRow.Cells[9].Value.ToString();

        }

        private void txtCheckNewPwd_TextChanged(object sender, EventArgs e)
        {
            //유효성체크
            if (txtNewPwd.Text != txtCheckNewPwd.Text)
            {
                errorProvider1.SetError(txtCheckNewPwd, "비밀번호가 일치하지 않습니다.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
