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
        public string Duration;

        public DepositAccount(string customernum,string customername, string kindofacc,
                            string amountofdeposit, string outaccount, string outaccountpw, string newpwd, string duration)
        {
            CustomerNum = customernum;
            CustomerName = customername;
            KindOfAcc = kindofacc;
            AmountOfDeposit = amountofdeposit;
            OutAccount = outaccount;
            OutAccountPw = outaccountpw;
            NewPwd = newpwd;
            Duration = duration;
        }

        public DepositAccount(string customernum, string customername, string daccountnum,
                            string outaccount, string outaccountpw, string newpwd, string duration)
        {
            CustomerNum = customernum;
            CustomerName = customername;
            DAccountNum = daccountnum;
            OutAccount = outaccount;
            OutAccountPw = outaccountpw;
            NewPwd = newpwd;
            Duration = duration;
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

        public DataTable GetExpireData(string customernum)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select DAccountNum,
                        date_format(date_add(DateCreated, interval Duration month), '%Y %c') as expiremonth,
						date_format(date_add(DateCreated, interval Duration month), '%Y %c %d') as expiredate,
						CustomerNum, CustomerName, KindofAcc,
                        AmountOfDeposit, OutAccount, OutAccountPwd, NewPwd, CurrentMoney, Duration
                            from depositaccount
						    where CustomerNum = @customernum";

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

        public DataTable GetEveryData(string customernum)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select DAccountNum, DateCreated, CustomerNum, CustomerName, KindofAcc,
                                        AmountOfDeposit, OutAccount, OutAccountPwd, NewPwd, CurrentMoney, Duration
                                        from depositaccount
                                        where CustomerNum = @customernum";

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



        public bool Insert(DepositAccount deposInfo)        //처음에 예금계좌를 생성할 때만 사용 
                                    //첫 생성의 계좌 금액은 예치금액과 일치 이후에는 업데이트를 활용하여 기존의 돈에 계속 더해줄 것
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"insert into depositaccount (DateCreated, CustomerNum, CustomerName, KindofAcc, 
                                               AmountOfDeposit, OutAccount, OutAccountPwd, NewPwd, CurrentMoney, Duration)
                                    values (now(), @customernum, @customername, @kindofacc,
                                                @amountofdeposit, @outaccount, @outaccountpw, @newpwd, @amountofdeposit, @duration)";
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

                cmd.Parameters.Add("@duration", MySqlDbType.VarChar);
                cmd.Parameters["@duration"].Value = deposInfo.Duration;

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

        public bool Update(DepositAccount deposInfo)        //예금을 연장할 때 부르는 함수
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"update depositaccount
                                  set 
                                        OutAccount = @outaccount,
                                        OutAccountPwd = @outpwd,
                                        NewPwd = @newpd,
                                        Duration = Duration + @duration
                                 where DAccountNum = @daccoutnum";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = trans;

               
                cmd.Parameters.Add("@outaccount", MySqlDbType.VarChar);
                cmd.Parameters["@outaccount"].Value = deposInfo.OutAccount;

                cmd.Parameters.Add("@outpwd", MySqlDbType.VarChar);
                cmd.Parameters["@outpwd"].Value = deposInfo.OutAccountPw;

                cmd.Parameters.Add("@newpd", MySqlDbType.VarChar);
                cmd.Parameters["@newpd"].Value = deposInfo.NewPwd;

                cmd.Parameters.Add("@duration", MySqlDbType.VarChar);
                cmd.Parameters["@duration"].Value = deposInfo.Duration;

                cmd.Parameters.Add("@daccoutnum", MySqlDbType.Int32);
                cmd.Parameters["@daccoutnum"].Value = deposInfo.DAccountNum;

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
            catch (Exception)
            {
                trans.Rollback();
                return false;
            }

        }
        public bool UpdateCurrentMoney(string daccountnum, string amountofsending)        //예금에 추가 입금을 할 때 쓰는 함수
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"update depositaccount
                                  set 
                                  CurrentMoney = CurrentMoney + @amountofsending      
                                 where DAccountNum = @daccountnum";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = trans;


                cmd.Parameters.Add("@amountofsending", MySqlDbType.Int32);
                cmd.Parameters["@amountofsending"].Value = Convert.ToInt32(amountofsending);
                
                cmd.Parameters.Add("@daccountnum", MySqlDbType.Int32);
                cmd.Parameters["@daccountnum"].Value = Convert.ToInt32(daccountnum);

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
            catch (Exception)
            {
                trans.Rollback();
                return false;
            }

        }

        public bool Delete(string customernum, string daccountnum)
        {
            try
            {
                string sql = @"delete from depositaccount where CustomerNum = @customernum and DAccountNum = @daccountnum";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                

                cmd.Parameters.Add("@customernum", MySqlDbType.Int32);
                cmd.Parameters["@customernum"].Value = Convert.ToInt32(customernum);

                cmd.Parameters.Add("@daccountnum", MySqlDbType.Int32);
                cmd.Parameters["@daccountnum"].Value = Convert.ToInt32(daccountnum);




                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                    return false;
                
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
