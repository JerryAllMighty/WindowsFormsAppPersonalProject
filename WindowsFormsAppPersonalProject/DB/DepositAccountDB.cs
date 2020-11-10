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



        public DataTable GetEveryData(string customernum)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = $@"select DAccountNum, DateCreated, CustomerNum, CustomerName, KindofAcc,
                                        AmountOfDeposit, OutAccount, OutAccountPwd, NewPwd, CurrentMoney
                                        from depositaccount
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



        public bool Insert(DepositAccount deposInfo)        //처음에 예금계좌를 생성할 때만 사용 
                                    //첫 생성의 계좌 금액은 예치금액과 일치 이후에는 업데이트를 활용하여 기존의 돈에 계속 더해줄 것
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"insert into depositaccount (DateCreated, CustomerNum, CustomerName, KindofAcc, 
                                               AmountOfDeposit, OutAccount, OutAccountPwd, NewPwd, CurrentMoney)
                                    values (now(), @customernum, @customername, @kindofacc,
                                                @amountofdeposit, @outaccount, @outaccountpw, @newpwd, @amountofdeposit)";
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
