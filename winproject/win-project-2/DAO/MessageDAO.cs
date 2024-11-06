using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win_project_2.SQLConn;
using win_project_2.Models;
using System.Data;


namespace win_project_2.DAO
{
    public class MessageDAO
    {
        private DatabaseConnection dbConn;

        public MessageDAO()
        {
            dbConn = new DatabaseConnection();
        }

        public void SendMessage(int senderId, int receiverId, string content)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                try
                {
                    conn.Open(); // Mở kết nối

                    using (SqlCommand command = new SqlCommand("SendMessage", conn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SenderID", senderId);
                        command.Parameters.AddWithValue("@ReceiverID", receiverId);
                        command.Parameters.AddWithValue("@Content", content);

                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error while sending message: " + ex.Message);
                    throw;
                }
            }
        }
    }
}
