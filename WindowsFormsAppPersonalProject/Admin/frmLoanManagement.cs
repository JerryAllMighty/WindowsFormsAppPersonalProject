using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsAppPersonalProject
{
    public partial class frmLoanManagement : Form
    {
        string dtpTime1;
        string dtpTime2;
        bool selectdtp1, selectdtp2 = false;
        public frmLoanManagement()
        {
            InitializeComponent();
        }

        private void frmLoanManagement_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDay_Click(object sender, EventArgs e)       //연체율
        {
           // dtpCheck();
            LoanDB db = new LoanDB();
            DataTable dt = db.DelayRate();
            
            chart1.Series.Clear();
             chart1.Series.Add(new Series("Series1"));
           
               chart1.Series["Series1"].Points.AddXY("Loan Delayed", dt.Rows[0][0].ToString());
                chart1.Series["Series1"].ToolTip = dt.Rows[0][0].ToString();
           
           
            chart1.Series["Series1"].ChartType = SeriesChartType.Column;
            chart1.Series["Series1"].BorderWidth = 5;
            
            chart1.Series["Series1"].LegendText = "연체율";

        }

        private void btnAvg_Click(object sender, EventArgs e)       //평균 대출액
        {
           // dtpCheck();
            LoanDB db = new LoanDB();
            DataTable dt = db.MonthlyAvgLoan();
            chart1.Series.Clear();
            chart1.Series.Add(new Series("Series2"));
            for(int i =0; i < dt.Rows.Count; i++)
            { 
                chart1.Series["Series2"].Points.AddXY(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString());
                chart1.Series["Series2"].ToolTip = dt.Rows[i][1].ToString();
            }

            chart1.Series["Series2"].ChartType = SeriesChartType.Line;
            chart1.Series["Series2"].BorderWidth = 5;

            //chart1.Series["월별 평균 대출액"].Points.DataBind(dt.DefaultView, "month(LoanStarted)", "AVGloan", "ToolTip=AVGloan ");
            chart1.Series["Series2"].LegendText = "월별 평균 대출액";

        }

        private void btnMonthlyLoan_Click(object sender, EventArgs e)       //기간별 대출 건수
        {
            if (!dtpCheck())
            {
                return;
            }
            LoanDB db = new LoanDB();
            DataTable dt = db.LoanPerPeriod(dtpTime1, dtpTime2);
            
            if (dt == null)
            {
                MessageBox.Show("해당하는 자료가 없습니다.");
                return;
            }
            chart1.Series.Clear();
            chart1.Series.Add(new Series("Series3"));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart1.Series["Series3"].Points.AddXY(dt.Rows[i][0].ToString().Substring(0, 10), dt.Rows[i][1]);
                chart1.Series["Series3"].ToolTip = dt.Rows[i][1].ToString();
            }

            chart1.Series["Series3"].ChartType = SeriesChartType.Line;
            chart1.Series["Series3"].BorderWidth = 5;
            chart1.Series["Series3"].LegendText = "기간별 대출 건수";


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtpTime1 = dtp.Value.ToString("yyyyMMdd");
            selectdtp1 = true;
        }


        private bool dtpCheck()
        {
            if (!selectdtp1)
            {
                MessageBox.Show("검색 기간 시작 지점은 반드시 선택해주셔야합니다.");
                return false; ;
            }
            else if (!selectdtp2)
            {
                MessageBox.Show("검색 기간 도착 지점은 반드시 선택해주셔야합니다.");
                return false;
            }
            //도착 기간은 시작기간보다 길어야함
            if (dtp.Value.CompareTo(dtp2.Value) > 0)

            {
                MessageBox.Show("검색 출발 지점은 도착 지점보다 나중일 수 없습니다.");
                return false;
            }
            else if (dtp.Value.CompareTo(dtp2.Value) == 0)
            {
                MessageBox.Show("검색 출발 지점은 도착 지점과 같을 수 없습니다.");
                return false;
            }
            return true;

        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            dtpTime2 = dtp2.Value.ToString("yyyyMMdd");
            selectdtp2 = true;
        }
    }
}
