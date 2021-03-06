﻿using MySql.Data.MySqlClient;
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
    public class NormalAccount
    {
        public string NAccountNum;
        public string DateCreated;
        public string CustomerNum;
        public string CustomerName;
        public string KindOfAcc;
        public string Pwd;
        public string CurrentMoney;

        public NormalAccount(string customernum, string customername, string kindofacc, string pwd) : this ( customernum,  customername,  kindofacc, pwd, "0")
        {

        }
        public NormalAccount(string customernum, string customername, string kindofacc, string pwd, string currentmoney)
        {
            CustomerNum = customernum;
            CustomerName = customername;
            KindOfAcc = kindofacc;
            Pwd = pwd;
            CurrentMoney = currentmoney;
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


        public DataTable WhenYouLoadfrmSending(string customernum)      //이체폼을 로딩할 때, 컨트롤들에 초기값 주기 위한 함수
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select N.NAccountNum, date(N.DateCreated), N.CustomerNum, N.CustomerName,
                                        N.KindOfAcc, N.Pwd, N.CurrentMoney, S.SAccountNum, D.DAccountNum, Sen.RecentlySentTo
                                        from normalaccount N
                                        left outer join depositaccount D
                                        on N.CustomerNum = D.CustomerNum    
                                        left outer join savings S
                                        on N.CustomerNum = S.CustomerNum
                                        left outer join sending Sen
                                        on N.CustomerNum = Sen.CustomerNum
                                        where N.CustomerNum = @customernum
                                        group by S.SAccountNum,D.DAccountNum;";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.Add("@customernum", MySqlDbType.Int32);
                da.SelectCommand.Parameters["@customernum"].Value = Convert.ToInt32(customernum);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                    return dt;
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetCurrentMoney(string naccountnum)       // 일반 계좌의 현재 잔액을 확인하는 함수
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select CurrentMoney
                                        from normalaccount                              
                                        where NAccountNum = @naccountnum";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@naccountnum", MySqlDbType.Int32);
                da.SelectCommand.Parameters["@naccountnum"].Value = Convert.ToInt32(naccountnum);

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetNormalAccountData(string naccountnum)       // 계좌 이체시 입금 계좌 정보가 존재하는지 확인하는 함수
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select NAccountNum, CustomerName
                                        from normalaccount                              
                                        where NAccountNum = @naccountnum";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@naccountnum", MySqlDbType.Int32);
                da.SelectCommand.Parameters["@naccountnum"].Value = naccountnum;

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                    return null;
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
                string sql = @"select NAccountNum, DateCreated, CustomerNum, CustomerName, KindOfAcc, Pwd
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
                string sql = @"select NAccountNum, DateCreated, CustomerNum, CustomerName, KindOfAcc, Pwd, CurrentMoney
                                        from normalaccount                              
                                        where CustomerNum = @customernum";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@customernum", MySqlDbType.Int32);
                da.SelectCommand.Parameters["@customernum"].Value = Convert.ToInt32(customernum);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
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

                string sql = @"insert into normalaccount(DateCreated, CustomerNum, CustomerName, KindOfAcc, Pwd, CurrentMoney)
                                        value(now(), @customernum, @customername, @kindofacc, @pwd, @currentmoney)";
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

                cmd.Parameters.Add("@currentmoney", MySqlDbType.Int32);
                cmd.Parameters["@currentmoney"].Value = accountinfo.CurrentMoney;

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

        public bool UpdateReceiver(string amountofsending, string recentlysentto)      //받는 사람 통장에 잔고 더해주는 함수
        {
            try 
            {

                string sql = @"update normalaccount set CurrentMoney = CurrentMoney + @amountofsending
                                        where NAccountNum = @recentlysentto";
                MySqlCommand cmd = new MySqlCommand(sql,conn);
                cmd.Parameters.Add("@amountofsending", MySqlDbType.Int32);
                cmd.Parameters["@amountofsending"].Value = Convert.ToInt32(amountofsending);


                cmd.Parameters.Add("@recentlysentto", MySqlDbType.VarChar);
                cmd.Parameters["@recentlysentto"].Value = recentlysentto;


                if (cmd.ExecuteNonQuery() > 0)
                { return true; }
                else { return false; }
                
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false; 
            }
        }

        public bool UpdateSender(string amountofsending, string naccountnum)      //보낸 사람 통장에 잔고 빼주는 함수
        {
            try
            {

                string sql = @"update normalaccount set CurrentMoney = CurrentMoney - @amountofsending
                                        where NAccountNum = @naccountnum";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@amountofsending", MySqlDbType.Int32);
                cmd.Parameters["@amountofsending"].Value = Convert.ToInt32(amountofsending);


                cmd.Parameters.Add("@naccountnum", MySqlDbType.Int32);
                cmd.Parameters["@naccountnum"].Value = Convert.ToInt32(naccountnum);

                if (cmd.ExecuteNonQuery() > 0)
                { return true; }
                else { return false; }

            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }



        public void Dispose()
        {
            conn.Close();
        }
    }
}
