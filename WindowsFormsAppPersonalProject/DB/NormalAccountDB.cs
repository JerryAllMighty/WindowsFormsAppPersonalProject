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
        public string KindOfAcc;
        public string Pwd;

        public NormalAccount(string customernum, string kindofacc, string pwd)
        {
            CustomerNum = customernum;
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


        public bool Insert(NormalAccount accountinfo)       //파라미터화하기
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {

                string sql = @"insert into normalaccount(DateCreated, CustomerNum, KindOfAcc, Pwd)
                                        value(now(), @customernum, @kindofacc, @pwd)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = trans;

                cmd.Parameters.Add("@customernum", MySqlDbType.Int32);
                cmd.Parameters["@customernum"].Value = Convert.ToInt32(accountinfo.CustomerNum);

                cmd.Parameters.Add("@kindofacc", MySqlDbType.VarChar);
                cmd.Parameters["@kindofacc"].Value = accountinfo.KindOfAcc;

                cmd.Parameters.Add("@pwd", MySqlDbType.Int32);
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
