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
    public partial class FPostEmloyee : Form
    {
        public FPostEmloyee()
        {
            InitializeComponent();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            var dt = new DB();
            Post newPost = new Post("", lb_namejob.Text, lb_des.Text, lb_loca.Text, "", lb_skill.Text, lb_price.Text, GlobalVariables.id);
            string temp = await dt.PostArticle(newPost);
            await dt.AddPostToPosted(temp);
        }

        private void lb_loca_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }
    }
}
