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

        public Customer(string customernum, string customername, string customeraddress, 
                            string customerid,string isadmin, string customerpw, string phone,
                            string customeremail, string customerimage)
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

        public DataTable WhenYouApplyForLoan(int customernum)
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

        public DataTable countAccountSoFar(string customernum)
        {
            try 
            {
                DataTable dt = new DataTable();
                string sql = $@"select CustomerNum, CustomerName, CustomerAddress, 
                                    (select count(*) from normalaccount where CustomerNum = '{customernum}') as NAccountSoFar,
                                    (select count(*) from  savings where CustomerNum = '{customernum}') as SAccountSoFar,
                                    (select count(*) from depositaccount where CustomerNum = '{customernum}') as DAccountSoFar
                                    from customers where CustomerNum = '{customernum}'";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Customer DataSelected(string selectedCustomerNum)
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


        public DataTable GetEveryData()   //인자 없이 데이터 조회 
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select CustomerNum, CustomerName, CustomerAddress," +
                                        "CustomerID, IsAdmin, CustomerPw, CustomerPhone" +
                                        "CustomerEmail, CustomerImage from customers";

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
                string sql = $@"select CustomerNum, CustomerName, CustomerAddress,
                                    CustomerID, IsAdmin, CustomerPw, CustomerPhone, CustomerEmail, CustomerImage
                                        from customers 
                                        where CustomerID = @uid and CustomerPw = @pwd ";

                MySqlDataAdapter da = new MySqlDataAdapter(sql,conn);
                da.SelectCommand.Parameters.Add("@uid", MySqlDbType.Int32);
                da.SelectCommand.Parameters["@uid"].Value = Convert.ToInt32(uid);

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


        public bool Insert(Customer cus)  
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try 
            {
                string sql = $@"insert into customers(CustomerName, CustomerAddress, CustomerID, 
                                                        IsAdmin, CustomerPw, CustomerPhone, CustomerEmail, CustomerImage)        
                                values(@CustomerName, @CustomerAddress, @CustomerID, @IsAdmin, @CustomerPw, @CustomerPhone)";

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


        public bool UpdateIsAdmin(string isadmin, string customernum)
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


        public bool Update(Customer cus)
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {   //isadmin은 설정할 수 없게, 고객 일련번호는 자동생성이니 제외
                string sql = @"update customers            
                                        set CustomerName = @name, 
                                        CustomerAddress = @address, 
                                        CustomerID = @id, 
                                        CustomerPw = @pw, 
                                        CustomerPhone = @phone
                                        where CustomerNum = @customernum" ;
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

                updateCmd.Parameters.Add("@customernum", MySqlDbType.VarChar);
                updateCmd.Parameters["@customernum"].Value = cus.CustomerNum;

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

        public bool Delete(Customer cus)
        {
            try
            {
                string sql = @"delete from customers where CustomerNum = @customernum";
                MySqlCommand delcmd = new MySqlCommand(sql, conn);
                delcmd.Parameters.Add("@customernum", MySqlDbType.VarChar);
                delcmd.Parameters["@customernum"].Value = cus.CustomerNum;

                delcmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
