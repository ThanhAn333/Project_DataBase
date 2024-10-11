using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_project_2.Forms;

namespace win_project_2.UserControls
{
    public partial class UCShowJobcs : UserControl
    {
        string id_post = "";
        public UCShowJobcs(Post post)
        {
            InitializeComponent();
            LoadData(post);
        }

        public async void LoadData(Post post)
        {
            id_post = "p" + post.Id;
            lb_tag.Text = post.Tag;
            lb_location.Text = post.Location;
            lb_price.Text = post.Price.ToString();
            lb_senderid.Text = post.SenderId;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FDetail1 f = new FDetail1(id_post);
            f.ShowDialog();
        }

        private void lb_location_Click(object sender, EventArgs e)
        {

        }
    }
}
