using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win_project_2.SQLConn;
using win_project_2.Models;

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
                    User user1 = new User(
                          (int)reader["UserID"],
                        reader["UserName"].ToString(),
                        reader["UserEmail"].ToString(),
                        "", 
                        reader["Role"]?.ToString(), 
                        reader["Address"]?.ToString(), 
                        (DateTime)reader["DateOfBirth"], 
                        reader["PhoneNumber"]?.ToString(), 
                        reader["ProfilePicture"]?.ToString(), 
                        (DateTime)reader["CreatedAt"], 
                        (DateTime)reader["UpdatedAt"]  
                    );
                    User user2 = new User(
                          (int)reader["UserID"],
                        reader["UserName"].ToString(),
                        reader["UserEmail"].ToString(),
                        "", 
                        reader["Role"]?.ToString(), 
                        reader["Address"]?.ToString(), 
                        (DateTime)reader["DateOfBirth"], 
                        reader["PhoneNumber"]?.ToString(),
                        reader["ProfilePicture"]?.ToString(),
                        (DateTime)reader["CreatedAt"], 
                        (DateTime)reader["UpdatedAt"]  
                   );
                    message = new Message(
                        (int)reader["MessageID"],
                        user1,
                        user2,
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
                    User user1 = new User(
                        (int)reader["UserID"],
                        reader["UserName"].ToString(),
                        reader["UserEmail"].ToString(),
                        "",  
                        reader["Role"]?.ToString(), 
                        reader["Address"]?.ToString(), 
                        (DateTime)reader["DateOfBirth"], 
                        reader["PhoneNumber"]?.ToString(), 
                        reader["ProfilePicture"]?.ToString(),
                        (DateTime)reader["CreatedAt"], 
                        (DateTime)reader["UpdatedAt"] 
                    );
                    User user2 = new User(
                         (int)reader["UserID"],
                        reader["UserName"].ToString(),
                        reader["UserEmail"].ToString(),
                        "", 
                        reader["Role"]?.ToString(), 
                        reader["Address"]?.ToString(),
                        (DateTime)reader["DateOfBirth"], 
                        reader["PhoneNumber"]?.ToString(),
                        reader["ProfilePicture"]?.ToString(), 
                        (DateTime)reader["CreatedAt"], 
                        (DateTime)reader["UpdatedAt"]  
                   );
                    Message message = new Message(
                        (int)reader["MessageID"],
                        user1,
                        user2,
                        reader["Content"].ToString(),
                        (DateTime)reader["Timestamp"]
                    ) ;
                    messages.Add(message);
                }
            }
            return messages;
        }
        public void AddMessage(Message message)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "INSERT INTO Message (SenderID, ReceiverID, Content, Timestamp) VALUES (@SenderID, @ReceiverID, @Content, @Timestamp)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SenderID", message.Sender.UserID);
                command.Parameters.AddWithValue("@ReceiverID", message.Receiver.UserID);
                command.Parameters.AddWithValue("@Content", message.Content);
                command.Parameters.AddWithValue("@Timestamp", message.Timestamp);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }



        // Update
        public void UpdateMessage(Message message)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "UPDATE Message SET Content = @Content WHERE MessageID = @MessageID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Content", message.Content);
                command.Parameters.AddWithValue("@MessageID", message.MessageID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Delete
        public void DeleteMessage(int messageId)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "DELETE FROM Message WHERE MessageID = @MessageID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MessageID", messageId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
