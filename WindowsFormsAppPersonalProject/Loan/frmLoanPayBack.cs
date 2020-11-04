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
    public partial class frmLoanPayBack : Form
    {
        public frmLoanPayBack()
        {
            InitializeComponent();
        }

        private void frmLoanPayBack_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)  //다음 버튼 클릭
        {
            frmLoanPayBack2 frm = new frmLoanPayBack2();
            frm.Show();
            frm.Activate();
        }
    }
}
