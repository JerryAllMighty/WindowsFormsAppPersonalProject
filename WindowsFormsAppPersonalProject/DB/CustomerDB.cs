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

namespace WindowsFormsAppPersonalProject.DB
{
    public struct Customer
    {
        public string CustomerName;
        public string CustomerAddress;
        public string SCustomerID;
        public string ACustomerID;
        public string CustomerPw;
        public string Phone;

        
        public Customer(string customername, string customeraddress, string scustomerid, string acustomerid, string customerpw, string phone)
        {                        
            CustomerName = customername;                      
            CustomerAddress = customeraddress;
            SCustomerID = scustomerid;
            ACustomerID = acustomerid;
            CustomerPw = customerpw;
            Phone = phone;
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

        public DataTable GetEveryData()
        {
            try {
                DataTable dt = new DataTable();
                Login login = new Login();
                string sql = $@"select '{login.ID}', CustomerPw from customers 
                                where '{login.ID}' = '{login.TextID}' and CustomerPw = '{login.TextPwd}'";

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


        public bool Insert(Customer cus)  //값이 아니라 컬럼이 변수일떄는??ㅠㅠ
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try 
            {
                WhenCreate c1 = new WhenCreate();
                string sql = $@"insert into customers(CustomerName, CustomerAddress, @{c1.KindofAccount}, CustomerPw, CustomerPhone)        
                                values(@CustomerName, @CustomerAddress, @SCustomerID, @CustomerPw, @CustomerPhone)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = trans;
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@CustomerName", MySqlDbType.VarChar);
                cmd.Parameters["@CustomerName"].Value = cus.CustomerName;

                cmd.Parameters.Add("@CustomerAddress", MySqlDbType.VarChar);
                cmd.Parameters["@CustomerAddress"].Value = cus.CustomerAddress;

                
                if (c1.KindofAccount == "SCustomerID")
                {
                    cmd.Parameters.Add("@SCustomerID", MySqlDbType.VarChar);
                    cmd.Parameters["@SCustomerID"].Value = cus.SCustomerID;
                }
                else
                    cmd.Parameters.Add("@ACustomerID", MySqlDbType.VarChar);
                    cmd.Parameters["@ACustomerID"].Value = cus.ACustomerID;


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

    }
}
