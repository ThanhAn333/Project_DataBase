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

namespace win_project_2.UserControls
{
    public partial class UCRating : UserControl
    {
        public UCRating(Review review)
        {
            InitializeComponent();
            label2.Text = review.NguoiTimThoId;
            guna2RatingStar1.Value = review.Rating;
            if (review.ImgUrl != "")
            {
                guna2PictureBox1.Image = Image.FromStream(new MemoryStream(new WebClient().DownloadData(review.ImgUrl)));
            }
            guna2TextBox1.Text = review.Comment;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UCRating_Load(object sender, EventArgs e)
        {

        }
    }
}
