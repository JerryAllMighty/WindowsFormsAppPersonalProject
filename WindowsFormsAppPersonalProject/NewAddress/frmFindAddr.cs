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
            txtZipno.Text = ds.Tables[1].Rows[e.RowIndex][5].ToString();
            txtJibun.Text = ds.Tables[1].Rows[e.RowIndex][3].ToString();
            CustomerAddress = txtZipno.Text + "/" +txtJibun.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            mother.FindAddr = CustomerAddress;
            this.Close();
        }
    }
}
