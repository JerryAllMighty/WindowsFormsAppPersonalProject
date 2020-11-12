using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsAppPersonalProject
{
    public partial class frmAccountmanagement : Form
    {
        public frmAccountmanagement()
        {
            InitializeComponent();
        }

        private void frmAccountmanagement_Load(object sender, EventArgs e)
        {
            CommonUtil.SetinitGridView(dgvMember);
            CommonUtil.AddGridTextColumn(dgvMember, "일반 계좌 총 개수", "TotalNAccount", 150);
            CommonUtil.AddGridTextColumn(dgvMember, "적금 계좌 총 개수", "TotalSAccount", 150);
            CommonUtil.AddGridTextColumn(dgvMember, "예금 계좌 총 개수", "TotalDAccount", 150);


            CustomerDB db = new CustomerDB();
            System.Data.DataTable dt = db.countAccountSoFar();
            if (dt != null)
                dgvMember.DataSource = dt;
            else
                MessageBox.Show("자료를 로드해오지 못했습니다.");
            db.Dispose();
        }

        private void btnImport_Click(object sender, EventArgs e)        //자료받아오기
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel Files(*.xls)|*.xls|Excel Files(*.xlsx)|*.xlsx";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
                string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";

                string fileName = dlg.FileName;
                string fileExtension = System.IO.Path.GetExtension(fileName);
                string strConn = string.Empty;
                string sheetName = string.Empty;

                switch (fileExtension)
                {
                    case ".xls":
                        strConn = string.Format(Excel03ConString, fileName, "Yes");
                        break;
                    case ".xlsx":
                        strConn = string.Format(Excel07ConString, fileName, "Yes");
                        break;
                }
                //첫번째 Sheet 명을 가져옮

                OleDbConnection conn = new OleDbConnection(strConn);
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                conn.Open();
                DataTable dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                sheetName = dtSchema.Rows[0]["TABLE_NAME"].ToString();
                conn.Close();

                conn.Open();
                // 엑셀파일을 읽었을때 테이블명은 [Sheet$]
                string sql = "select * from [" + sheetName + "]";
                OleDbDataAdapter oda = new OleDbDataAdapter(sql, conn);
               DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();

                dgvMember.DataSource = dt;

            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)        //자료 내보내기
        {
            //저장할 디렉토리를 물어보고, 거기에 저장
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel Files(*.xls)|*.xls";
            dlg.Title = "엑셀 파일로 내보내기";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlworkbook = xlApp.Workbooks.Add();
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlworkbook.Worksheets.get_Item(1);

                //타이틀
                for (int k = 0; k < dgvMember.Columns.Count; k++)
                {
                    xlWorkSheet.Cells[1, k + 1] = dgvMember.Columns[k].Name;
                    //((Excel.Range)xlSheet.Cells[2, i + 1]).Interior.Color = Excel.XlRgbColor.rgbGhostWhite;
                }

                for (int i = 0; i < dgvMember.Rows.Count; i++)
                {
                    for (int k = 0; k < dgvMember.Columns.Count; k++)
                    {
                        xlWorkSheet.Cells[i + 2, k + 1] = dgvMember[k, i].Value.ToString();
                    }
                }

                xlworkbook.SaveAs(dlg.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                xlworkbook.Close(true);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlworkbook);
                releaseObject(xlApp);

                MessageBox.Show("Excel Export가 완료되었습니다.");
            }
        }
    }
}
