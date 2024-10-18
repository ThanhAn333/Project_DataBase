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
    public partial class FRating : Form
    {

        public string NguoiThoId = "";
        
        string FileImageName = "";
        public FRating(string nguoithoid)
        {
            InitializeComponent();
            NguoiThoId =nguoithoid;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        void LoadImage(ref string imageName)
        {
            OpenFileDialog fileImageName = new OpenFileDialog();
            if (fileImageName.ShowDialog() == DialogResult.OK)
            {
                imageName = fileImageName.FileName;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LoadImage(ref FileImageName);
            using (var tempImage = new Bitmap(FileImageName))
            {
                guna2PictureBox1.Image = new Bitmap(tempImage);
            }
        }

        private void guna2RatingStar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void btn_up_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
