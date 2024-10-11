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
    public partial class FDetail : Form
    {
        public FDetail(string id_post)
        {
            InitializeComponent();
            LoadData(id_post);
        }

       public async void LoadData(string id_post)
        {
            var dt = new DB();
            Post post = await dt.GetInfoPost("p" + id_post);
            lb_description.Text = post.Description;
            lb_location.Text = post.Location;
            lb_price.Text = post.Price.ToString();
            lb_request.Text = post.Request;
            lb_tag.Text = post.Tag;
        }
    }
}
