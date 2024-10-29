using Microsoft.AspNet.SignalR;
using System.Data.SqlClient;

public class ChatHub : Hub
{
    private string connectionString = "Data Source=LAPTOP-IGR3NG0G\\THANHAN;Initial Catalog=APPJOB;Integrated Security=True;Encrypt=False"; // Thay đổi với chuỗi kết nối của bạn

    public void Send(string sender, string receiver, string message)
    {
        // Lưu tin nhắn vào cơ sở dữ liệu
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Message (SenderID, ReceiverID, Content) VALUES (@SenderID, @ReceiverID, @Content)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SenderID", sender);
                command.Parameters.AddWithValue("@ReceiverID", receiver);
                command.Parameters.AddWithValue("@Content", message);
                command.ExecuteNonQuery();
            }
        }

        // Gửi tin nhắn đến tất cả client
        Clients.All.broadcastMessage(sender, message);
    }
}