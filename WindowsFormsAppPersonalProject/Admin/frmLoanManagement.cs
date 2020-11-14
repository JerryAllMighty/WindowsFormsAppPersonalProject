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
        public frmLoanManagement()
        {
            InitializeComponent();
        }

        private void frmLoanManagement_Load(object sender, EventArgs e)
        {



            chart1.Series["Series1"].Points.AddXY(10, 200);
            chart1.Series[0].Points.AddXY(20, 300);
            chart1.Series[0].Points.AddXY(30, 100);
            chart1.Series[0].Points.AddXY(40, 500);
            chart1.Series[0].Points.AddXY(50, 400);
        }

        private void btnDay_Click(object sender, EventArgs e)       //날짜별 많이 빌린 날 검색
        {
            LoanDB db = new LoanDB();
            DataTable dt = db.CountDays();

            if (chart1.Series.Count == 1)
            {
                chart1.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series("날짜별 많이 빌린 날 검색"));
            }
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series["날짜별 많이 빌린 날 검색"].BorderWidth = 5;

            //DataView dv = new DataView(dt);
            //dv.RowFilter = "count(day(LoanStarted)) = 3";
            //DataView dv2 = new DataView(dt);

            //chart1.Series[1].Points.DataBind(dv, "date(LoanStarted)", "count(day(LoanStarted))", "ToolTip=date(LoanStarted) ");
            //chart1.Series[1].LegendText = "날짜별 많이 빌린 날 검색";
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //Convert.ToInt32(dt.Rows[i][0].ToString())


            chart1.Series[1].Points.DataBind(dt.DefaultView, "date(LoanStarted)", "count(day(LoanStarted))", "ToolTip=date(LoanStarted)");
            //}

        }

        private void btnAvg_Click(object sender, EventArgs e)       //평균 대출액
        {
            LoanDB db = new LoanDB();
            System.Data.DataTable dt = db.MonthlyAvgLoan();

            chart1.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series("월별 평균 대출액"));
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series["월별 평균 대출액"].BorderWidth = 5;
            DataView dv = new DataView(dt);
            DataView dv2 = new DataView(dt);

            chart1.Series[2].Points.DataBind(dv, "AVGloan", "month(LoanStarted)", "ToolTip=AVGloan ");
            chart1.Series[2].LegendText = "월별 평균 대출액";

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    chart1.Series[2].Points.AddXY(Convert.ToInt32(dt.Rows[i][0].ToString()), Convert.ToInt32(dt.Rows[i][1].ToString()));
            //}
        }
    }
}
