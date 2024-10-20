using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;


namespace win_project_2
{
    public partial class Form1 : Form
    {
        private HubConnection connection;

        public Form1()
        {
            InitializeComponent();
            connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:7161/queryHub")
                .Build();

            connection.StartAsync().ContinueWith(task =>
            {
                if (task.IsFaulted)
                {
                    MessageBox.Show("Could not connect to the server: " + task.Exception.GetBaseException());
                }
            });
        }



        private async void send_btn_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> messages = await connection.InvokeAsync<List<string>>("GetAllMessages");
                string allMessages = string.Join("\n", messages);
                MessageBox.Show(allMessages, "All Messages");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
