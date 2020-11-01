using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPersonalProject
{
    public class Savings
    {
        public string SAccountNum;
        public string DateCreated;
        public string CustomerName;
        public string KindOfAcc;
        public string Duration;
        public string PayPerMonth;
        public string OutAccount;
        public string OutAccountPwd;
        public string NewPwd;

        public Savings(string customername, string kindofacc, string duration, string paypermonth, string outaccount, string outaccountpwd, string newpwd)
        {
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

       

        public bool Insert(Savings savinginfo)
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"insert into savings (DateCreated, CustomerName, KindOfAcc, Duration, 
                                                    PayPerMonth, OutAccount, OutAccountPwd, NewPwd)
                                            values(now(), @customername, @kindofacc, @duration, @paypermonth, @outaccount, @outaccountpwd, @newpwd)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = trans;

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
