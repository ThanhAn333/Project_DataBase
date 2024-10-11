using Firebase.Auth;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_project_2.DataClass;
using win_project_2.UserControls;

namespace win_project_2.Forms
{
    public partial class FChat : Form
    {
        private DB dt;
        public string receiver = "";
        public string combinedString = "";
        public FChat(string id)
        {
            InitializeComponent();
            dt = new DB();
            dt.OnMessageReceived += dt_OnMessageReceived;
            receiver = id;
            string[] users = new string[] { GlobalVariables.id, id };
            Array.Sort(users);
            combinedString = String.Join("-", users);
            dt.ListenForNewMessages(combinedString);
            lb_name.Text = GlobalVariables.other_user;

            if (GlobalVariables.url_avt_other_user != "")
            {
                guna2CirclePictureBox1.Image = Image.FromStream(new MemoryStream(new WebClient().DownloadData(GlobalVariables.url_avt_other_user)));
                GlobalVariables.url_avt_other_user = "";
            }
        }
        public async void dt_OnMessageReceived(string message)
        {
            createMessage(message);
        }

        private void createMessage(string input)
        {
            if (!input.Contains("-"))
            {
                return;
            }

            string[] parts = input.Split('-');
            if (parts.Length < 3)
            {
                return;
            }

            string sender = parts[0];
            string receive = parts[1];
            string content = String.Join("-", parts.Skip(2));


            Console.WriteLine($"sender = {sender}, receive = {receive}, content = {content}");

            UserControl userControl;

            if (GlobalVariables.id == sender)
            {
                UCSendMesage userControl2 = new UCSendMesage();
                userControl2.Title = content;
                userControl = userControl2;
            }
            else
            {
                UCReceive userControl3 = new UCReceive();
                userControl3.Title = content;
                userControl = userControl3;
            }
          
             if (flowLayoutPanel1.InvokeRequired)
            {
                flowLayoutPanel1.Invoke(new Action(() =>
                {
                    flowLayoutPanel1.Controls.Add(userControl);
                    flowLayoutPanel1.ScrollControlIntoView(userControl);
                }));
            }
            else
            {
                flowLayoutPanel1.Controls.Add(userControl);
                flowLayoutPanel1.ScrollControlIntoView(userControl);
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void iconButton1_Click(object sender, EventArgs e)
        {
            var dt = new DB();
            if(guna2TextBox1.Text != "")
            {
                string mess = GlobalVariables.id + "-" + receiver + "-" + guna2TextBox1.Text;
                dt.SendMessage(combinedString ,mess);
                guna2TextBox1.Clear();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
