using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client;


namespace win_project_2.Forms.Candidate.UC
{
    public partial class UCMessage : UserControl
    {
        public UCMessage()
        {
            InitializeComponent();
        }
        private DataTable messagesTable;
        private IHubProxy hubProxy;
        private HubConnection connection;

        private void btnSend_Click(object sender, EventArgs e)
        {
            var message = txtMessage.Text;
            var sender1 = "User 1"; // Thay đổi theo người gửi
            var receiver = "User 2"; // Thay đổi theo người nhận

            hubProxy.Invoke("Send", sender1, receiver, message);
            txtMessage.Text = string.Empty;
        }

        private void UCMessage_Load(object sender, EventArgs e)
        {
            // Khởi tạo DataTable
            messagesTable = new DataTable();
            messagesTable.Columns.Add("Sender", typeof(string));
            messagesTable.Columns.Add("Message", typeof(string));
            messagesTable.Columns.Add("Timestamp", typeof(DateTime));

            // Gán DataTable cho DataGridView 
            dgviewMessage.DataSource = messagesTable;

            // Khởi tạo SignalR
            connection = new HubConnection("https://localhost:5000"); // Thay đổi với URL của bạn
            hubProxy = connection.CreateHubProxy("ChatHub");

            // Nhận tin nhắn từ server
            hubProxy.On<string, string>("broadcastMessage", (messageSender, message) =>
            {
                // Cập nhật DataGridView với tin nhắn mới
                dgviewMessage.Invoke((Action)(() =>
                {
                    messagesTable.Rows.Add(messageSender, message, DateTime.Now);
                }));
            });

            connection.Start().Wait();
        }
        
    }
}
