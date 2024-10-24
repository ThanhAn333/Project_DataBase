﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_project_2.DataClass;
using win_project_2.UserControls;

namespace win_project_2.Forms
{
    public partial class FListPost : Form
    {
        public FListPost()
        {
            InitializeComponent();
            Loadlist();
        }

        public async void Loadlist()
        {
            var dt = new DB();
            List<Post> listPost = await dt.GetAllPosts();
            foreach (Post post in listPost)
            {
                var new_uc = new UCShowPost(post);
                flowLayoutPanel1.Controls.Add(new_uc);
            }

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if(guna2TextBox1.Text == "")
            {
                return;
            }
            else
            {
                flowLayoutPanel1.Controls.Clear();
                var dt = new DB();
                List<Post> listPost = await dt.GetAllPosts();
                foreach (Post post in listPost)
                {
                    if(post.Tag == guna2TextBox1.Text)
                    {
                        var new_uc = new UCShowPost(post);
                        flowLayoutPanel1.Controls.Add(new_uc);
                    }
                }
            }
        }
    }
}
