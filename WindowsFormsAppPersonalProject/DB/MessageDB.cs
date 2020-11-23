using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace WindowsFormsAppPersonalProject
{
    public class Message
    {
        public string MessageNum;
        public string SenderName;
        public string ReceiverName;
        public string MsgText;
        public string TimeSent;
        public string SenderNum;
        public string ReceiverNum;

        public string ReceiverInFo;
        public string HasReadOrNot;

        public Message(string sendernum, string receivernum, string sender, string receiver, string msgtext, string timesent)
            :this( sendernum,  receivernum,  sender,  receiver,  msgtext,  timesent,  "N")
        {
           
        }

        public Message(string sendernum, string receivernum,string sender, string receiver, string msgtext , string timesent, string hasreadornot)
        {
            SenderNum = sendernum;
             ReceiverNum= receivernum;
            SenderName = sender;
            ReceiverName = receiver;
            MsgText = msgtext;
            TimeSent = timesent;
            HasReadOrNot = hasreadornot;
        }
    }

    class MessageDB : IDisposable
    {
        MySqlConnection conn;
        public MessageDB()
        {
            string strConn = ConfigurationManager.ConnectionStrings["JerryBank"].ConnectionString;
            conn = new MySqlConnection(strConn);
            conn.Open();

        }

        public bool SendMsg(Message msgInfo)        //메세지를 주고 받는 조건을 PK인 고유 식별번호로 진행
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"insert into message (SenderName, ReceiverName, MsgText, TimeSent, SenderNum, ReceiverNum, HasReadOrNot)
                                values(@sendername, @receivername, @msgText, now(), @sendernum, @receivernum, @hasreadornot)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = trans;

                cmd.Parameters.Add("@sendername", MySqlDbType.VarChar);
                cmd.Parameters["@sendername"].Value = msgInfo.SenderName;

                cmd.Parameters.Add("@receivername", MySqlDbType.VarChar);
                cmd.Parameters["@receivername"].Value = msgInfo.ReceiverName;

                cmd.Parameters.Add("@msgText", MySqlDbType.VarChar);
                cmd.Parameters["@msgText"].Value = msgInfo.MsgText;

                cmd.Parameters.Add("@sendernum", MySqlDbType.Int32);
                cmd.Parameters["@sendernum"].Value = Convert.ToInt32(msgInfo.SenderNum);

                cmd.Parameters.Add("@receivernum", MySqlDbType.Int32);
                cmd.Parameters["@receivernum"].Value = Convert.ToInt32(msgInfo.ReceiverNum);

                cmd.Parameters.Add("@hasreadornot", MySqlDbType.VarChar);
                cmd.Parameters["@hasreadornot"].Value = msgInfo.HasReadOrNot;

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

        public bool UpdateHasRead(string customernum)        //메세지를 주고 받는 조건을 PK인 고유 식별번호로 진행
        {
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"update message
                                        set HasReadOrNot = 'Y'
                                            where ReceiverNum = @customernum";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = trans;

                cmd.Parameters.Add("@customernum", MySqlDbType.VarChar);
                cmd.Parameters["@customernum"].Value = customernum;

                

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

        public DataTable HasReadOrNot(string customernum)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select HasReadOrNot
                                    from message where ReceiverNum = @customernum";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@customernum", MySqlDbType.Int32);
                da.SelectCommand.Parameters["@customernum"].Value = Convert.ToInt32(customernum);

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else { return null; }

            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetMessage(string customernum)
        {
            try
            {
                DataTable dt = new DataTable();
                    string sql = @"select SenderName, ReceiverName, MsgText, TimeSent, SenderNum, ReceiverNum
                                    from message where ReceiverNum = @customernum";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@customernum", MySqlDbType.Int32);
                da.SelectCommand.Parameters["@customernum"].Value = Convert.ToInt32(customernum);

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else { return null; }
                
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetMessage2 (string customernum)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select concat( SenderNum, '.' ,SenderName), SenderNum, ReceiverName, MsgText, TimeSent, ReceiverNum
                                    from message where ReceiverNum = @customernum";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@customernum", MySqlDbType.Int32);
                da.SelectCommand.Parameters["@customernum"].Value = Convert.ToInt32(customernum);

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else { return null; }

            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetMessage3(string sendernum, string receivernum)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select SenderName, ReceiverName, MsgText, TimeSent, SenderNum, ReceiverNum
                                    from message where SenderNum = @sendernum and ReceiverNum = @receivernum";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.Add("@sendernum", MySqlDbType.Int32);
                da.SelectCommand.Parameters["@sendernum"].Value = Convert.ToInt32(sendernum);

                da.SelectCommand.Parameters.Add("@receivernum", MySqlDbType.Int32);
                da.SelectCommand.Parameters["@receivernum"].Value = Convert.ToInt32(receivernum);

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else { return null; }

            }
            catch (Exception)
            {
                return null;
            }
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
