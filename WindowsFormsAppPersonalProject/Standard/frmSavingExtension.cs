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
    public partial class frmSavingExtension : Form
    {
        string Duration;
        string CustomerNum;
        string SAccountNum;
        string DateCreated;
        string CustomerName;
        string KindOfAcc;
        string OutAccount;
        string OutAccountPw;
        string NewPwd;

        DataTable dt2;

        public frmSavingExtension(DataTable dt2, Customer cus)
        {
            InitializeComponent();
            this.dt2 = dt2;
            CustomerNum = cus.CustomerNum;
            CustomerName = cus.CustomerName;
        }

        public Savings savingInfoForExtension       //적금 계좌에 넘겨줄 때 사용
        {
            get
            {
                return new Savings(CustomerNum, CustomerName, "적금 계좌",SAccountNum, txtpayPerMonth.Text,
                              txtOutAccount.Text, txtOutPwd.Text, txtNewPwd.Text,
                               cbxduration.SelectedItem.ToString().Substring(0, cbxduration.SelectedItem.ToString().IndexOf('개')));
            }
        }

        private void frmSavingExtension_Load(object sender, EventArgs e)
        {
            dgvMemver.DataSource = dt2;
        }

        private void btnSavingsExtension_Click(object sender, EventArgs e)
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
            SavingDB db = new SavingDB();
            if (!db.Update(savingInfoForExtension))
            {
                MessageBox.Show("적금 연장에 실패하였습니다.");
                return;
            }
            MessageBox.Show("성공적으로 적금 기간을 연장하였습니다.");
            db.Dispose();
            this.Close();
        }

        private void dgvMemver_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMemver.CurrentRow.Selected = true;
            SAccountNum = dgvMemver.CurrentRow.Cells[0].Value.ToString();
            txtCurrentMoney.Text = dgvMemver.CurrentRow.Cells[9].Value.ToString();
            txtOutAccount.Text = dgvMemver.CurrentRow.Cells[6].Value.ToString();
            txtOutPwd.Text = dgvMemver.CurrentRow.Cells[7].Value.ToString();
            txtNewPwd.Text = dgvMemver.CurrentRow.Cells[8].Value.ToString();
            txtCheckNewPwd.Text = dgvMemver.CurrentRow.Cells[8].Value.ToString();
        }

        private void txtOutAccount_KeyPress(object sender, KeyPressEventArgs e)     //출금 계좌 변경시 숫자만 입력받게 하기
        {
            CommonUtil.NumberCheck(e.KeyChar);
        }

        private void txtOutPwd_KeyPress(object sender, KeyPressEventArgs e)      //출금 계좌 비밀번호 변경시 숫자만 입력받게 하기
        {
            CommonUtil.NumberCheck(e.KeyChar);
        }

        private void txtNewPwd_KeyPress(object sender, KeyPressEventArgs e)     //적금 계좌 비밀번호 변경시 숫자만 입력받게 하기
        {
            CommonUtil.NumberCheck(e.KeyChar);
        }

        private void txtCheckNewPwd_KeyPress(object sender, KeyPressEventArgs e)        //적금 계좌 비밀번호 변경 확인시 숫자만 입력받게 하기
        {
            CommonUtil.NumberCheck(e.KeyChar);
        }

        private void txtpayPerMonth_KeyPress(object sender, KeyPressEventArgs e)        //매회 납입 금액 숫자만 입력받게 하기
        {
            CommonUtil.NumberCheck(e.KeyChar);
        }
    }
}
