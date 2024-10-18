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

using win_project_2.UserControls;

namespace win_project_2.Forms
{
    public partial class FChat : Form
    {
        
        public string receiver = "";
        public string combinedString = "";
        public FChat(string id)
        {
            InitializeComponent();
            
        }
        public async void dt_OnMessageReceived(string message)
        {
            createMessage(message);
        }

        private void createMessage(string input)
        {
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void iconButton1_Click(object sender, EventArgs e)
        {
           

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
