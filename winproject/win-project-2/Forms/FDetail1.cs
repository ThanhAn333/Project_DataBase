using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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

        }

        private async void Chat_Click_1(object sender, EventArgs e)
        {

        }
    }
}
