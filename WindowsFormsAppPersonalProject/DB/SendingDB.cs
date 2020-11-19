using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPersonalProject
{
    public class SendingClass
    {
        public string SSerialNum;
        public string NAccountNum;
        public string AmountOfSending;
        public string SendingDate;
        public string RecentlySentTo;
        public string CustomerNum;
        public string CustomerName;
        public string ReceiversName;

        public SendingClass(string naccountnum, string amountofsending, string sendingdate, string recentlysentto, string customernum, string customername)
            :this( naccountnum,  amountofsending,  sendingdate,  recentlysentto,  customernum,  customername, "")
        {
            
        }
        public SendingClass(string naccountnum, string amountofsending, string sendingdate, string recentlysentto, string customernum, string customername, string receiversname)
        {
            //SSerialNum = sserialnum;
            NAccountNum = naccountnum;
            AmountOfSending = amountofsending;
            SendingDate = sendingdate;
            RecentlySentTo = recentlysentto;
            CustomerNum = customernum;
            CustomerName = customername;
            ReceiversName = receiversname;
        }
    }
    class SendingDB : IDisposable
    {
        MySqlConnection conn;
        public SendingDB()
        {
            string strConn = ConfigurationManager.ConnectionStrings["JerryBank"].ConnectionString;
            conn = new MySqlConnection(strConn);
            conn.Open();
        }

        public DataTable GetEveryData(string customernum)       //고객번호를 넘겨주면 이체 내역 보여주기
        {
            try 
            {
                DataTable dt = new DataTable();
                string sql = @"select SSerialNum, NAccountNum, AmountOfSending, date(SendingDate), RecentlySentTo, CustomerNum, CustomerName 
                                                from sending
                                                where CustomerNum = @customernum";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.Add("@customernum", MySqlDbType.Int32);
                da.SelectCommand.Parameters["@customernum"].Value = Convert.ToInt32(customernum);

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                    return dt;
                else
                    return null;


            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }
        public bool Insert(SendingClass sendinginfo)
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try 
            {
                
                string sql = @"insert into sending (NAccountNum, AmountOfSending, 
                                                                    SendingDate, RecentlySentTo, CustomerNum, CustomerName)
                                                values (@naccountnum, @amountofsending, now(), @recentlysentto, @customernum, @customername)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = trans;
                cmd.Parameters.Add("@naccountnum", MySqlDbType.Int32);
                cmd.Parameters["@naccountnum"].Value = Convert.ToInt32(sendinginfo.NAccountNum);

                cmd.Parameters.Add("@amountofsending", MySqlDbType.Int32);
                cmd.Parameters["@amountofsending"].Value = Convert.ToInt32(sendinginfo.AmountOfSending);

                cmd.Parameters.Add("@recentlysentto", MySqlDbType.VarChar);
                cmd.Parameters["@recentlysentto"].Value = sendinginfo.RecentlySentTo;

                cmd.Parameters.Add("@customernum", MySqlDbType.Int32);
                cmd.Parameters["@customernum"].Value = Convert.ToInt32( sendinginfo.CustomerNum);

                cmd.Parameters.Add("@customername", MySqlDbType.VarChar);
                cmd.Parameters["@customername"].Value = sendinginfo.CustomerName;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    trans.Commit();
                    return true;
                }
                else
                {
                    trans.Rollback();
                    return false;
                }
                    
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                trans.Rollback();
                return false; 
            }
        }       //이체 실행시 이체 테이블에 저장하는 함수

        public void Dispose()
        {
            conn.Close();
        }
    }
}
