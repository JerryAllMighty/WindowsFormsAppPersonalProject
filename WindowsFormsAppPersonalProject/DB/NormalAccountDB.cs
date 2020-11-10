using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WindowsFormsAppPersonalProject
{
    public class NormalAccount
    {
        public string NAccountNum;
        public string DateCreated;
        public string CustomerNum;
        public string CustomerName;
        public string KindOfAcc;
        public string Pwd;

        public NormalAccount(string customernum, string customername, string kindofacc, string pwd)
        {
            CustomerNum = customernum;
            CustomerName = customername;
            KindOfAcc = kindofacc;
            Pwd = pwd;
        }
    }

    class NormalAccountDB : IDisposable
    {
        MySqlConnection conn;

        public NormalAccountDB()
        {
            string strConn = ConfigurationManager.ConnectionStrings["JerryBank"].ConnectionString;
            conn = new MySqlConnection(strConn);
            conn.Open();
        }


        public DataTable WhenYouSend(string customernum)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT N.NAccountNum, N.CurrentMoney, S.RecentlySentTo FROM normalaccount N 
                                        join sending S on N.CustomerNum = S.CustomerNum
                                        where N.NAccountNum = S.NAccountNum and N.CustomerNum = @customernum";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.Add("@customernum", MySqlDbType.Int32);
                da.SelectCommand.Parameters["@customernum"].Value = Convert.ToInt32(customernum);

                da.Fill(dt);


                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public DataTable GetEveryData(string accountid, string accountpw)       //출금계좌와 비번이 맞는지 체크하는 함수
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = $@"select NAccountNum, DateCreated, CustomerNum, CustomerName, KindOfAcc, Pwd
                                        from normalaccount                              
                                        where NAccountNum = @accountid and Pwd = @accountpw";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.Add("@accountid", MySqlDbType.Int32);
                da.SelectCommand.Parameters["@accountid"].Value = Convert.ToInt32(accountid);

                da.SelectCommand.Parameters.Add("@accountpw", MySqlDbType.VarChar);
                da.SelectCommand.Parameters["@accountpw"].Value = accountpw;

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                { return dt; }
                else
                    return null;
                
            }
            catch (Exception)
            {
                return null;
            }
        }


        public DataTable GetEveryData(string customernum)       // 고객번호로 일반계좌 정보 가지고 오기
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = $@"select NAccountNum, DateCreated, CustomerNum, CustomerName, KindOfAcc, Pwd
                                        from normalaccount                              
                                        where CustomerNum = '{customernum}'";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public bool Insert(NormalAccount accountinfo)       //파라미터화하기
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {

                string sql = @"insert into normalaccount(DateCreated, CustomerNum, CustomerName, KindOfAcc, Pwd)
                                        value(now(), @customernum, @customername, @kindofacc, @pwd)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = trans;

                cmd.Parameters.Add("@customernum", MySqlDbType.Int32);
                cmd.Parameters["@customernum"].Value = Convert.ToInt32(accountinfo.CustomerNum);

                cmd.Parameters.Add("@customername", MySqlDbType.VarChar);
                cmd.Parameters["@customername"].Value = accountinfo.CustomerName;

                cmd.Parameters.Add("@kindofacc", MySqlDbType.VarChar);
                cmd.Parameters["@kindofacc"].Value = accountinfo.KindOfAcc;

                cmd.Parameters.Add("@pwd", MySqlDbType.VarChar);
                cmd.Parameters["@pwd"].Value = accountinfo.Pwd;

                cmd.ExecuteNonQuery();

                trans.Commit();
                return true;
            }
            catch (Exception)
            {
                trans.Rollback();
                return false;
            }
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
