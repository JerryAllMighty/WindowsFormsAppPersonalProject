using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPersonalProject
{
    public class DepositAccount
    {
        public string CustomerNum;
        public string DAccountNum;
        public string DateCreated;
        public string CustomerName;
        public string KindOfAcc;
        public string AmountOfDeposit;
        public string OutAccount;
        public string OutAccountPw;
        public string NewPwd;

        public DepositAccount(string customernum,string customername, string kindofacc,
                            string amountofdeposit, string outaccount, string outaccountpw, string newpwd)
        {
            CustomerNum = customernum;
            CustomerName = customername;
            KindOfAcc = kindofacc;
            AmountOfDeposit = amountofdeposit;
            OutAccount = outaccount;
            OutAccountPw = outaccountpw;
            NewPwd = newpwd;
        }

    }

    class DepositAccountDB : IDisposable
    {
        MySqlConnection conn;

        public DepositAccountDB()
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
                string sql = $"select count(*) from depositaccount where customernum = '{cus.CustomerNum}' ";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);

                return dt;


            }
            catch (Exception)
            {
                return null;
            }
        }



        public DataTable GetEveryData(DepositAccount depositinfo)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = $@"select DAccountNum, DateCreated, CustomerNum, CustomerName, KindofAcc,
                                        AmountOfDeposit, OutAccount, OutAccountPw, NewPwd
                                        from depositaccount
                                        where CustomerNum = {depositinfo.CustomerNum}";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);
               
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }



        public bool Insert(DepositAccount deposInfo)
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"insert into depositaccount (DateCreated, CustomerNum, CustomerName, KindofAcc, 
                                               AmountOfDeposit, OutAccount, OutAccountPw, NewPwd)
                                    values (now(), @customernum, @customername, @kindofacc, @amountofdeposit, @outaccount, @outaccountpw, @newpwd)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = trans;

                cmd.Parameters.Add("@customernum", MySqlDbType.Int32);
                cmd.Parameters["@customernum"].Value = Convert.ToInt32(deposInfo.CustomerNum);

                cmd.Parameters.Add("@customername", MySqlDbType.VarChar);
                cmd.Parameters["@customername"].Value = deposInfo.CustomerName;

                cmd.Parameters.Add("@kindofacc", MySqlDbType.VarChar);
                cmd.Parameters["@kindofacc"].Value = deposInfo.KindOfAcc;

                cmd.Parameters.Add("@amountofdeposit", MySqlDbType.VarChar);
                cmd.Parameters["@amountofdeposit"].Value = deposInfo.AmountOfDeposit;

                cmd.Parameters.Add("@outaccount", MySqlDbType.VarChar);
                cmd.Parameters["@outaccount"].Value = deposInfo.OutAccount;

                cmd.Parameters.Add("@outaccountpw", MySqlDbType.VarChar);
                cmd.Parameters["@outaccountpw"].Value = deposInfo.OutAccountPw;

                cmd.Parameters.Add("@newpwd", MySqlDbType.VarChar);
                cmd.Parameters["@newpwd"].Value = deposInfo.NewPwd;

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
