using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace WindowsFormsAppPersonalProject
{
    public partial class frmFindAddr : Form
    {
        DataSet ds;
        string CustomerAddress;
        frmWhenCreate mother;
        public frmFindAddr(frmWhenCreate frm)
        {
            InitializeComponent();
            mother = frm;
        }

        private void frmFindAddr_Load(object sender, EventArgs e)
        {
            CommonUtil.SetinitGridView(dgvMember);
            CommonUtil.AddGridTextColumn(dgvMember, "우편 번호", "zipNo");
            CommonUtil.AddGridTextColumn(dgvMember, "지번 주소", "jibunAddr",500);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "http://www.juso.go.kr/addrlink/addrLinkApi.do";
            string apiKey = "devU01TX0FVVEgyMDIwMTEwMzEwMDU0ODExMDM2MTA=";

            string apiUrl = $"{url}?confmKey={apiKey}&currentPage=1&countPerPage=1000&keyword={txtSearch.Text.Trim()}";

            WebClient wc = new WebClient();
            XmlReader reader = new XmlTextReader(wc.OpenRead(apiUrl));
            ds = new DataSet();
            ds.ReadXml(reader);

            if (ds.Tables.Count > 1)
                dgvMember.DataSource = ds.Tables[1];
            else
                MessageBox.Show(ds.Tables[0].Rows[0]["errorMessage"].ToString());
        }

        private void dgvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMember.CurrentRow.Selected = true;
            txtZipno.Text = ds.Tables[1].Rows[e.RowIndex][5].ToString();        //zipNo
            txtJibun.Text = ds.Tables[1].Rows[e.RowIndex][3].ToString();        //jibunAddr
            CustomerAddress = txtZipno.Text + "/" +txtJibun.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtZipno.TextLength < 1 || txtJibun.Text.Length < 1)
            {
                MessageBox.Show("반드시 주소 검색을 하여 해당 주소를 더블클릭하셔야합니다.");
                return;
            }
            mother.FindAddr = CustomerAddress;
            this.Close();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnAddr.PerformClick();
            }
        }
    }
}
