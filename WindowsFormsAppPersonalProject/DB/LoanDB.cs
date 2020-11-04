using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPersonalProject
{
    public class Loan
    {
        public string LoanNum;
        public string DAccountNum;
        public string AmountOfLoan;
        public string ReturnWhenExpired;
        public string PayBackMethod;
        public string Purpose;
        public string LoanExpire;
        public string NAccountNum;
        public string Pwd;
        public string LoanDate; //생성자로 대출 날짜는 넘겨주지 못해서 클래스가 생성될 때 값이 멤버변수에 할당되지는 않는다.
        public string InterestRate;
        public string RegularPayBack;
        public string CustomerNum;
        public string CustomerName;

        public Loan(string daccountnum, string amountofloan, string returnwhenexpired,
                                    string paybackmethod, string purpose, string loanperiod, string naccountnum,
                                    string pwd, string interestrate, string regularpayback, string customernum, string customername)
        {
            DAccountNum = daccountnum;
            AmountOfLoan = amountofloan;
            ReturnWhenExpired = returnwhenexpired;
            PayBackMethod = paybackmethod;
            Purpose = purpose;
            LoanExpire = loanperiod;
            NAccountNum = naccountnum;
            Pwd = pwd;
            InterestRate = interestrate;
            RegularPayBack = regularpayback;
            CustomerNum = customernum;
            CustomerName = customername;
        }
    }
    class LoanDB : IDisposable
    {
        MySqlConnection conn;
        public LoanDB()
        {
            string strConn = ConfigurationManager.ConnectionStrings["JerryBank"].ConnectionString;
            conn = new MySqlConnection(strConn);
            conn.Open();
        }

        public bool Insert(Loan loaninfo)
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"insert into loan(DAccountNum, AmountOfLoan, ReturnWhenExpired, 
                                            PayBackMethod, Purpose, LoanExpire, NAccountNum, Pwd, 
                                            LoanStarted, InterestRate, RegularPayBackDate, CustomerNum, CustomerName)
                                      values(@DAccountNum, @AmountOfLoan, @ReturnWhenExpired, @PayBackMethod, 
                                            @Purpose, date_add(now(), interval @LoanExpire month), @NAccountNum, @Pwd, now(), @InterestRate,
                                            @RegularPayBackDate, @CustomerNum, @CustomerName);";
                MySqlCommand cmd = new MySqlCommand(sql ,conn);
                cmd.Transaction =  trans;

                cmd.Parameters.Add("@DAccountNum", MySqlDbType.Int32);
                cmd.Parameters["@DAccountNum"].Value = Convert.ToInt32(loaninfo.DAccountNum);

                cmd.Parameters.Add("@AmountOfLoan", MySqlDbType.Int32);
                cmd.Parameters["@AmountOfLoan"].Value = Convert.ToInt32(loaninfo.AmountOfLoan);

                cmd.Parameters.Add("@ReturnWhenExpired", MySqlDbType.Int32);
                cmd.Parameters["@ReturnWhenExpired"].Value = Convert.ToInt32(loaninfo.ReturnWhenExpired);

                cmd.Parameters.Add("@PayBackMethod", MySqlDbType.VarChar);
                cmd.Parameters["@PayBackMethod"].Value = loaninfo.PayBackMethod;

                cmd.Parameters.Add("@Purpose", MySqlDbType.VarChar);
                cmd.Parameters["@Purpose"].Value = loaninfo.Purpose;

                cmd.Parameters.Add("@LoanExpire", MySqlDbType.Int32);
                cmd.Parameters["@LoanExpire"].Value = Convert.ToInt32((loaninfo.LoanExpire));

                cmd.Parameters.Add("@NAccountNum", MySqlDbType.Int32);
                cmd.Parameters["@NAccountNum"].Value = Convert.ToInt32(loaninfo.NAccountNum);

                cmd.Parameters.Add("@Pwd", MySqlDbType.VarChar);
                cmd.Parameters["@Pwd"].Value = loaninfo.Pwd;

                cmd.Parameters.Add("@InterestRate", MySqlDbType.Double);
                cmd.Parameters["@InterestRate"].Value = Convert.ToDouble(loaninfo.InterestRate);

                cmd.Parameters.Add("@RegularPayBackDate", MySqlDbType.VarChar);
                cmd.Parameters["@RegularPayBackDate"].Value = loaninfo.RegularPayBack;

                cmd.Parameters.Add("@CustomerNum", MySqlDbType.Int32);
                cmd.Parameters["@CustomerNum"].Value = Convert.ToInt32(loaninfo.CustomerNum);

                cmd.Parameters.Add("@CustomerName", MySqlDbType.VarChar);
                cmd.Parameters["@CustomerName"].Value = loaninfo.CustomerName;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    trans.Commit();
                    return true;
                }
                else
                    trans.Rollback();
                    return false;
                
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
