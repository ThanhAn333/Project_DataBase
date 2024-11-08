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

        public List<Message> LoadMessages(int user1ID, int user2ID)
        {
            List<Message> messages = new List<Message>();

            using (SqlConnection conn = dbConn.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetMessagesBetweenUsers", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@User1ID", user1ID);
                    cmd.Parameters.AddWithValue("@User2ID", user2ID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int messageId = reader.GetInt32(reader.GetOrdinal("MessageID"));
                            int senderId = reader.GetInt32(reader.GetOrdinal("SenderID"));
                            int receiverId = reader.GetInt32(reader.GetOrdinal("ReceiverID"));
                            string content = reader.GetString(reader.GetOrdinal("Content"));
                            DateTime timestamp = reader.GetDateTime(reader.GetOrdinal("Timestamp"));

                            Message message = new Message(messageId, senderId, receiverId, content, timestamp);
                            messages.Add(message);
                        }
                    }
                }
            }

            return messages;
        }

        public List<int> GetDistinctUserIDsBySenderOrReceiver(int userId)
        {
            List<int> userIDs = new List<int>();

            using (SqlConnection conn = dbConn.GetConnection())
            {
                conn.Open();

                // Tạo SqlCommand gọi thủ tục lưu trữ
                SqlCommand command = new SqlCommand("GetDistinctReceiversBySender", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", userId);

                // Thực hiện SqlDataReader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Thêm UserID vào danh sách
                        userIDs.Add(reader.GetInt32(0));
                    }
                }
            }

            return userIDs;
        }



    }
}
