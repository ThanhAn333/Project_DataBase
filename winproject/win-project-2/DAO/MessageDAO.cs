using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win_project_2.SQLConn;

namespace win_project_2.DAO
{
    public class MessageDAO
    {
        private DatabaseConnection dbConn;

        public MessageDAO()
        {
            dbConn = new DatabaseConnection();
        }

        public Message GetById(int messageID)
        {
            Message message = null;
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT * FROM Messages WHERE MessageID = @MessageID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MessageID", messageID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    message = new Message(
                        (int)reader["MessageID"],
                        (int)reader["SenderID"],
                        (int)reader["ReceiverID"],
                        reader["Content"].ToString(),
                        (DateTime)reader["Timestamp"]
                    );
                }
            }
            return message;
        }

        public List<Message> GetAll()
        {
            List<Message> messages = new List<Message>();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT * FROM Messages";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Message message = new Message(
                        (int)reader["MessageID"],
                        (int)reader["SenderID"],
                        (int)reader["ReceiverID"],
                        reader["Content"].ToString(),
                        (DateTime)reader["Timestamp"]
                    );
                    messages.Add(message);
                }
            }
            return messages;
        }

        public void Add(Message message)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "INSERT INTO Messages (SenderID, ReceiverID, Content, Timestamp) VALUES (@SenderID, @ReceiverID, @Content, @Timestamp)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SenderID", message.SenderID);
                cmd.Parameters.AddWithValue("@ReceiverID", message.ReceiverID);
                cmd.Parameters.AddWithValue("@Content", message.Content);
                cmd.Parameters.AddWithValue("@Timestamp", message.Timestamp);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Message message)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "UPDATE Messages SET SenderID = @SenderID, ReceiverID = @ReceiverID, Content = @Content, Timestamp = @Timestamp WHERE MessageID = @MessageID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MessageID", message.MessageID);
                cmd.Parameters.AddWithValue("@SenderID", message.SenderID);
                cmd.Parameters.AddWithValue("@ReceiverID", message.ReceiverID);
                cmd.Parameters.AddWithValue("@Content", message.Content);
                cmd.Parameters.AddWithValue("@Timestamp", message.Timestamp);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int messageID)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "DELETE FROM Messages WHERE MessageID = @MessageID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MessageID", messageID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
