using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_project_2.DataClass;

namespace win_project_2.Forms
{
    public partial class FDetail1 : Form
    {
        string id_sender = "";
        string id_job = "";
        public FDetail1(string id_post)
        {
            InitializeComponent();
            LoadData(id_post);
            id_job = id_post;
        }

        public async void LoadData(string id_post)
        {
            var dt = new DB();
            Post post = await dt.GetInfoPost(id_post);
            lb_des.Text = post.Description;
            lb_location.Text = post.Location;
            lb_price.Text = post.Price.ToString();
            lb_request.Text = post.Request;
            lb_tag.Text = post.Tag;
            id_sender = post.SenderId;
        }

        private async void Chat_click(object sender, EventArgs e)
        {

        }

        private async void Nopdon_click(object sender, EventArgs e)
        {

        }

        private void lb_request_Click(object sender, EventArgs e)
        {

        }

        private async void Nopdon_Click_1(object sender, EventArgs e)
        {
            var dt = new DB();
            await dt.ApplyforJob(id_job, GlobalVariables.id, id_sender);
            this.Close();
        }

        private async void Chat_Click_1(object sender, EventArgs e)
        {
            var dt = new DB();
            await dt.AddtoContact(id_sender);
            string[] users = new string[] { GlobalVariables.id, id_sender };
            Array.Sort(users);
            string combinedString = String.Join("-", users);
            FChat f = new FChat(id_sender);
            f.ShowDialog();
        }
    }
}
