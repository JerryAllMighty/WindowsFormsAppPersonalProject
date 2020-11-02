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
    public class Savings
    {
        public string SAccountNum;
        public string DateCreated;
        public string CustomerNum;
        public string CustomerName;
        public string KindOfAcc;
        public string Duration;
        public string PayPerMonth;
        public string OutAccount;
        public string OutAccountPwd;
        public string NewPwd;

        public Savings(string customernum, string customername, string kindofacc, string duration, string paypermonth, string outaccount, string outaccountpwd, string newpwd)
        {
            CustomerNum = customernum;
            CustomerName = customername;
            KindOfAcc = kindofacc;
            Duration = duration;
            PayPerMonth = paypermonth;
            OutAccount = outaccount;
            OutAccountPwd = outaccountpwd;
            NewPwd = newpwd;
        }


    }

    class SavingDB : IDisposable
    {
        MySqlConnection conn;

        public SavingDB()
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
                string sql = $"select count(*) from savings where customernum = '{cus.CustomerNum}' ";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);

                return dt;


            }
            catch (Exception)
            {
                return null;
            }
        }



        public bool Insert(Savings savinginfo)
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"insert into savings (DateCreated, CustomerNum, CustomerName, KindOfAcc, Duration, 
                                                    PayPerMonth, OutAccount, OutAccountPwd, NewPwd)
                                            values(now(), @customernum, @customername, @kindofacc, @duration, @paypermonth, @outaccount, @outaccountpwd, @newpwd)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = trans;

                cmd.Parameters.Add("@customernum", MySqlDbType.Int32);
                cmd.Parameters["@customernum"].Value = Convert.ToInt32(savinginfo.CustomerNum);

                cmd.Parameters.Add("@customername", MySqlDbType.VarChar);
                cmd.Parameters["@customername"].Value = savinginfo.CustomerName;

                cmd.Parameters.Add("@kindofacc", MySqlDbType.VarChar);
                cmd.Parameters["@kindofacc"].Value = savinginfo.KindOfAcc;

                cmd.Parameters.Add("@duration", MySqlDbType.VarChar);
                cmd.Parameters["@duration"].Value = savinginfo.Duration;

                cmd.Parameters.Add("@paypermonth", MySqlDbType.VarChar);
                cmd.Parameters["@paypermonth"].Value = savinginfo.PayPerMonth;

                cmd.Parameters.Add("@outaccount", MySqlDbType.VarChar);
                cmd.Parameters["@outaccount"].Value = savinginfo.OutAccount;

                cmd.Parameters.Add("@outaccountpwd", MySqlDbType.VarChar);
                cmd.Parameters["@outaccountpwd"].Value = savinginfo.OutAccountPwd;

                cmd.Parameters.Add("@newpwd", MySqlDbType.VarChar);
                cmd.Parameters["@newpwd"].Value = savinginfo.NewPwd;

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
