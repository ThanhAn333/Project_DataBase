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
    public partial class UCShowPost : UserControl
    {
        string id_post = "";
        public UCShowPost(Post post)
        {
            InitializeComponent();
            lb_tag.Text = post.Tag;
            lb_nguoigui.Text = post.SenderId;
            lb_location.Text = post.Location;
            lb_price.Text = post.Price.ToString();
            id_post = post.Id;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FDetail f = new FDetail(id_post);
            f.ShowDialog();
        }
    }
}
