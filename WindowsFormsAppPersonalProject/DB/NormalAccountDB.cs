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

        public DataTable countAccountSoFar(Customer cus)     //고객 번호(PK)로 검색하는 것이니까 커스터머 타입을 인자로 넘겨받습니다. 
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = $"select count(*) from normalaccount where customernum = '{cus.CustomerNum}' ";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);

                return dt;
               
                
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetEveryData(NormalAccount naccountinfo)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = $@"select NAccountNum, DateCreated, CustomerNum, CustomerName, KindOfAcc, Pwd
                                        from normalaccount                              
                                        where CustomerNum = {naccountinfo.CustomerNum}";

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
