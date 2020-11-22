using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPersonalProject
{
    public class Customer
    {
        public string CustomerNum;
        public string CustomerName;
        public string CustomerAddress;
        public string CustomerID;
        public string IsAdmin;
        public string CustomerPw;
        public string Phone;
        public string CustomerEmail;
        public string CustomerImage;
        public string IsResting;

        public Customer(string customernum, string customername, string customeraddress, 
                            string customerid,string isadmin, string customerpw, string phone,
                            string customeremail, string customerimage)
                            : this(customernum, customername,  customeraddress,
                             customerid,  isadmin,  customerpw,  phone,
                             customeremail,  customerimage, "N")        //휴면 계좌 여부를 넘겨주지 않아도 알아서 기본값 "N"을 주어서 생성해준다~
        {
           
        }

        //관리자가 고객을 관리하기 위해서 휴면 계정 여부도 정보가 필요하고, 이 때 쓰기 위한 생성자를 따로 만들었다. 기존 생성자에 휴면 계정 여부만 추가되었다.
        public Customer(string customernum, string customername, string customeraddress,
                           string customerid, string isadmin, string customerpw, string phone,
                           string customeremail, string customerimage, string isresting)
        {
            CustomerNum = customernum;
            CustomerName = customername;
            CustomerAddress = customeraddress;
            CustomerID = customerid;
            IsAdmin = isadmin;
            CustomerPw = customerpw;
            Phone = phone;
            CustomerEmail = customeremail;
            CustomerImage = customerimage;
            IsResting = isresting;
        }
    }

    class CustomerDB : IDisposable
    {
        MySqlConnection conn;
        public CustomerDB()
        {
            string strConn = ConfigurationManager.ConnectionStrings["JerryBank"].ConnectionString;
            conn = new MySqlConnection(strConn);

            conn.Open();
        }
        public void Dispose()
        {
            conn.Close();
        }

        public bool IdIterated(string newID)        //ID 중복체크, 중복이면 true반환
        {
            try {
                DataTable dt = new DataTable();
                string sql = @"select CustomerID from customers where CustomerID = @newID;";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@newID", MySqlDbType.VarChar);
                da.SelectCommand.Parameters["@newID"].Value = newID;

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                { return true; }
                else { return false; }
                
            }
            catch (Exception) { return false; }
        
        }

        public DataTable WhenYouApplyForLoan(int customernum)       //대출 신청시
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select D.DAccountNum, N.NAccountNum,  D. CustomerName 
                                from depositaccount D inner join normalaccount N on D.CustomerNum = N.CustomerNum
                                where N.CustomerNum = @customernum";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@customernum", MySqlDbType.Int32);
                da.SelectCommand.Parameters["@customernum"].Value = customernum;

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

        public DataTable countAccountSoFar()      //현재까지의 모든 고객의 계좌 개수(관리용)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select
                                    (select sum(if(NAccountNum > 0, 1, 0)) from normalaccount ) as TotalNAccount,
                                    (select sum(if(SAccountNum > 0, 1, 0)) from  savings ) as TotalSAccount,
                                    (select sum(if(DAccountNum > 0, 1, 0))from depositaccount ) as TotalDAccount
                                    from customers group by TotalNAccount ";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable countAccountSoFar(string customernum)      //현재까지의 계좌 개수(접속한 고객 전용)
        {
            try 
            {
                DataTable dt = new DataTable();
                string sql = @"select CustomerNum, CustomerName, CustomerAddress, 
                                    (select count(*) from normalaccount where CustomerNum = @customernum) as NAccountSoFar,
                                    (select count(*) from  savings where CustomerNum = @customernum) as SAccountSoFar,
                                    (select count(*) from depositaccount where CustomerNum = @customernum) as DAccountSoFar
                                    from customers where CustomerNum = @customernum";
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

        public Customer DataSelected(string selectedCustomerNum)        //그리드 뷰에서 선택된 정보를 검색
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select CustomerNum, CustomerName, CustomerAddress,
                                CustomerID, IsAdmin, CustomerPw, CustomerPhone, CustomerEmail, CustomerImage
                                from customers 
                                where CustomerNum = @customernum";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@customernum", MySqlDbType.Int32);
                da.SelectCommand.Parameters["@customernum"].Value = Convert.ToInt32(selectedCustomerNum);


                da.Fill(dt);
                Customer cus = new Customer
                    (dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(),
                        dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString(),
                        dt.Rows[0][7].ToString(), dt.Rows[0][8].ToString());
                
                return cus;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }       //선택한 데이터의 정보만 조회

        public DataTable GetEveryData2(string customernum)   //인자 없이 데이터 조회 
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select CustomerNum, CustomerName, CustomerAddress,
                                        CustomerID, IsAdmin, CustomerPw, CustomerPhone,
                                        CustomerEmail, CustomerImage, IsResting from customers where CustomerNum = @customernum";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                
                da.SelectCommand.Parameters.Add("@customernum", MySqlDbType.Int32);
                da.SelectCommand.Parameters["@customernum"].Value = Convert.ToInt32(customernum);

                da.Fill(dt);
                return dt;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }


        public DataTable GetEveryData()   //인자 없이 데이터 조회 
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select CustomerNum, CustomerName, CustomerAddress,
                                        CustomerID, IsAdmin, CustomerPw, CustomerPhone,
                                        CustomerEmail, CustomerImage, IsResting from customers";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);
                return dt;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }


        public DataTable GetEveryData(string uid,string pwd)   //로그인시 데이터 조회 
        {
            try {
                DataTable dt = new DataTable();
                string sql = @"select CustomerNum, CustomerName, CustomerAddress,
                                    CustomerID, IsAdmin, CustomerPw, CustomerPhone, CustomerEmail, CustomerImage, IsResting
                                        from customers 
                                        where CustomerID = @uid and CustomerPw = @pwd";

                MySqlDataAdapter da = new MySqlDataAdapter(sql,conn);
                da.SelectCommand.Parameters.Add("@uid", MySqlDbType.VarChar);
                da.SelectCommand.Parameters["@uid"].Value = uid;

                da.SelectCommand.Parameters.Add("@pwd", MySqlDbType.VarChar);
                da.SelectCommand.Parameters["@pwd"].Value = pwd;


                da.Fill(dt);
                return dt;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }


        public bool Insert(Customer cus)  //회원가입시 정보 생성
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try 
            {
                string sql = @"insert into customers(CustomerName, CustomerAddress, CustomerID, 
                                                        IsAdmin, CustomerPw, CustomerPhone, 
                                                        CustomerEmail, CustomerImage, IsResting)        
                                values(@CustomerName, @CustomerAddress, @CustomerID, @IsAdmin,
                                                        @CustomerPw, @CustomerPhone, @customeremail,
                                                        @customerimage, @isresting)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = trans;
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@CustomerName", MySqlDbType.VarChar);
                cmd.Parameters["@CustomerName"].Value = cus.CustomerName;

                cmd.Parameters.Add("@CustomerAddress", MySqlDbType.VarChar);
                cmd.Parameters["@CustomerAddress"].Value = cus.CustomerAddress;

                cmd.Parameters.Add("@CustomerID", MySqlDbType.VarChar);
                cmd.Parameters["@CustomerID"].Value = cus.CustomerID;

                cmd.Parameters.Add("@IsAdmin", MySqlDbType.VarChar);
                cmd.Parameters["@IsAdmin"].Value = cus.IsAdmin;

                cmd.Parameters.Add("@CustomerPw", MySqlDbType.VarChar);
                cmd.Parameters["@CustomerPw"].Value = cus.CustomerPw;

                cmd.Parameters.Add("@CustomerPhone", MySqlDbType.VarChar);
                cmd.Parameters["@CustomerPhone"].Value = cus.Phone;

                cmd.Parameters.Add("@customeremail", MySqlDbType.VarChar);
                cmd.Parameters["@customeremail"].Value = cus.CustomerEmail;

                cmd.Parameters.Add("@customerimage", MySqlDbType.VarChar);
                cmd.Parameters["@customerimage"].Value = cus.CustomerImage;

                cmd.Parameters.Add("@isresting", MySqlDbType.VarChar);
                cmd.Parameters["@isresting"].Value = cus.IsResting;

                cmd.ExecuteNonQuery();
                trans.Commit();
                return true; 
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                trans.Rollback();
                return false;
            }
        }


        public bool UpdateNewPw(string newPwd, string customerid)       //비밀번호 찾기 할 때 임의로 8자리 생성하는 메서드
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"update customers            
                                        set CustomerPw = @customerpw
                                        where CustomerID = @customerid";

                MySqlCommand updateCmd = new MySqlCommand(sql, conn);
                updateCmd.Transaction = trans;


                updateCmd.Parameters.Add("@customerpw", MySqlDbType.VarChar);
                updateCmd.Parameters["@customerpw"].Value = newPwd;

                updateCmd.Parameters.Add("@customerid", MySqlDbType.VarChar);
                updateCmd.Parameters["@customerid"].Value = customerid;

                updateCmd.ExecuteNonQuery();
                trans.Commit();
                return true;

            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                trans.Rollback();
                return false;
            }
        }


        public bool UpdateIsAdmin(string isadmin, string customernum)       //관리자나 일반회원으로 변경
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"update customers            
                                        set IsAdmin = @isadmin
                                        where CustomerNum = @customernum";

                MySqlCommand updateCmd = new MySqlCommand(sql, conn);
                updateCmd.Transaction = trans;


                updateCmd.Parameters.Add("@isadmin", MySqlDbType.VarChar);
                updateCmd.Parameters["@isadmin"].Value = isadmin;

                updateCmd.Parameters.Add("@customernum", MySqlDbType.Int32);
                updateCmd.Parameters["@customernum"].Value = Convert.ToString(customernum);

                updateCmd.ExecuteNonQuery();
                trans.Commit();
                return true;

            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                trans.Rollback();
                return false;
            }
        }


        public bool Update(Customer cus)        //수정
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {   //관리자여부와 휴면여부는 수정할 수 없게 코딩. 고객 일련번호는 자동생성이니 제외
                string sql = @"update customers            
                                        set CustomerName = @name, 
                                        CustomerAddress = @address, 
                                        CustomerID = @id, 
                                        CustomerPw = @pw, 
                                        CustomerPhone = @phone,
                                        CustomerEmail = @customeremail,
                                        CustomerImage = @customerimage,
                                        IsResting = 'N'                     
                                        where CustomerNum = @customernum";
                MySqlCommand updateCmd = new MySqlCommand(sql, conn);
                updateCmd.Transaction = trans;

                updateCmd.Parameters.Add("@name", MySqlDbType.VarChar);
                updateCmd.Parameters["@name"].Value = cus.CustomerName;

                updateCmd.Parameters.Add("@address", MySqlDbType.VarChar);
                updateCmd.Parameters["@address"].Value = cus.CustomerAddress;

                updateCmd.Parameters.Add("@id", MySqlDbType.VarChar);
                updateCmd.Parameters["@id"].Value = cus.CustomerID;

                updateCmd.Parameters.Add("@pw", MySqlDbType.VarChar);
                updateCmd.Parameters["@pw"].Value = cus.CustomerPw;

                updateCmd.Parameters.Add("@phone", MySqlDbType.VarChar);
                updateCmd.Parameters["@phone"].Value = cus.Phone;

                updateCmd.Parameters.Add("@customernum", MySqlDbType.Int32);
                updateCmd.Parameters["@customernum"].Value = Convert.ToInt32(cus.CustomerNum);

                updateCmd.Parameters.Add("@customeremail", MySqlDbType.VarChar);
                updateCmd.Parameters["@customeremail"].Value = cus.CustomerEmail;


                updateCmd.Parameters.Add("@customerimage", MySqlDbType.VarChar);
                updateCmd.Parameters["@customerimage"].Value = cus.CustomerImage;

                updateCmd.ExecuteNonQuery();
                trans.Commit();
                return true;
               
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                trans.Rollback();
                return false;
            }
        }

        public bool SetRest(string customernum)        //휴면계좌로 전환
        {
            try
            {
                string sql = @"update customers
                                            set IsResting = 'Y'
                                            where customernum = @customernum";
                MySqlCommand delcmd = new MySqlCommand(sql, conn);
                delcmd.Parameters.Add("@customernum", MySqlDbType.Int32);
                delcmd.Parameters["@customernum"].Value = Convert.ToInt32(customernum);

                if (delcmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UnSetRest(string customernum)        //휴면계좌 해제
        {
            try
            {
                string sql = @"update customers
                                            set IsResting = 'N'
                                            where customernum = @customernum";
                MySqlCommand delcmd = new MySqlCommand(sql, conn);

                delcmd.Parameters.Add("@customernum", MySqlDbType.Int32);
                delcmd.Parameters["@customernum"].Value = Convert.ToInt32(customernum);

                if (delcmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
