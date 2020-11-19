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

        public Savings(string customernum, string customername, string kindofacc, string duration,
            string paypermonth, string outaccount, string outaccountpwd, string newpwd) 
            :this( customernum,  customername,  kindofacc,  duration,
             paypermonth,  outaccount,  outaccountpwd,  newpwd, "")     //저축 기간 안 넘겨줘도 빈 값으로 받아준다
        {

        }

        public Savings(string customernum, string customername, string kindofacc, string saccountnum, string paypermonth,
            string outaccount, string outaccountpwd, string newpwd, string duration)
        {
            CustomerNum = customernum;
            CustomerName = customername;
            KindOfAcc = kindofacc;
            SAccountNum = saccountnum;
            PayPerMonth = paypermonth;
            OutAccount = outaccount;
            OutAccountPwd = outaccountpwd;
            NewPwd = newpwd;
            Duration = duration;
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
        public DataTable GetEveryData(string customernum)
        {
            try 
            {
                DataTable dt = new DataTable();
                string sql = @"select SAccountNum, DateCreated, CustomerNum,
                                        CustomerName, KindOfAcc, Duration, PayPerMonth,
                                            OutAccount, OutAccountPwd, NewPwd, CurrentMoney 
                                from savings  where CustomerNum = @customernum";
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

        public DataTable GetExpireData(string customernum)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select SAccountNum,
                        date_format(date_add(DateCreated, interval Duration month), '%Y %c') as expiremonth,
						date_format(date_add(DateCreated, interval Duration month), '%Y %c %d') as expiredate,
						CustomerNum, CustomerName, KindofAcc,
                        OutAccount, OutAccountPwd, NewPwd, CurrentMoney, Duration
                            from savings
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

        public bool Update(Savings savinginfo)        //적금을 연장할 때 부르는 함수
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"update savings
                                  set 
                                        OutAccount = @outaccount,
                                        OutAccountPwd = @outpwd,
                                        NewPwd = @newpd,
                                        Duration = Duration + @duration
                                 where SAccountNum = @saccoutnum";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = trans;


                cmd.Parameters.Add("@outaccount", MySqlDbType.VarChar);
                cmd.Parameters["@outaccount"].Value = savinginfo.OutAccount;

                cmd.Parameters.Add("@outpwd", MySqlDbType.VarChar);
                cmd.Parameters["@outpwd"].Value = savinginfo.OutAccountPwd;

                cmd.Parameters.Add("@newpd", MySqlDbType.VarChar);
                cmd.Parameters["@newpd"].Value = savinginfo.NewPwd;

                cmd.Parameters.Add("@duration", MySqlDbType.VarChar);
                cmd.Parameters["@duration"].Value = savinginfo.Duration;

                cmd.Parameters.Add("@saccoutnum", MySqlDbType.Int32);
                cmd.Parameters["@saccoutnum"].Value = savinginfo.SAccountNum;

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

        public bool UpdateCurrentMoney(string saacountnum, string amountofsending)        //적금에 추가 입금을 할 때 쓰는 함수
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"update savings
                                  set 
                                  CurrentMoney = CurrentMoney + @amountofsending      
                                 where SAccountNum = @saacountnum";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = trans;


                cmd.Parameters.Add("@amountofsending", MySqlDbType.Int32);
                cmd.Parameters["@amountofsending"].Value = Convert.ToInt32(amountofsending);

                cmd.Parameters.Add("@saacountnum", MySqlDbType.Int32);
                cmd.Parameters["@saacountnum"].Value = Convert.ToInt32(saacountnum);

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


        public bool Delete(string customernum, string saccountnum)
        {
            try
            {
                string sql = @"delete from savings where CustomerNum = @customernum and SAccountNum = @saccountnum";
                MySqlCommand cmd = new MySqlCommand(sql, conn);


                cmd.Parameters.Add("@customernum", MySqlDbType.Int32);
                cmd.Parameters["@customernum"].Value = Convert.ToInt32(customernum);

                cmd.Parameters.Add("@saccountnum", MySqlDbType.Int32);
                cmd.Parameters["@saccountnum"].Value = Convert.ToInt32(saccountnum);




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
