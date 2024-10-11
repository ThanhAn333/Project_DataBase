using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using win_project_2.DataClass;
using win_project_2.UserControls;

namespace win_project_2.Forms
{
    public partial class ThoDetail : Form
    {
        private int favCount,doneJob;
        public string id;
        public ThoDetail(string _id)
        {
            InitializeComponent();
            LoadData(_id);
            id = _id;

        }
        public async Task<int> CountFav(string id)
        {
            int count = 0;
            var dt = new DB();
            List<NguoiTimTho> nguoiTims = await dt.GetAllNguoiTimTho();
            foreach (NguoiTimTho nguoi in nguoiTims)
            {
                if (nguoi.FavThoIds.Contains(id))
                {
                    count++;

                }
            }
            Console.WriteLine(count);
            return count;
        }
        private async void LoadData(string id)
        {
            var dt = new DB();
            NguoiTho nguoitho = await dt.GetInfoNguoiTho(id);
            lb_Name.Text = nguoitho.Name;
            lb_job.Text = nguoitho.JobName;
            lb_Name1.Text = nguoitho.Name;
            lb_Job1.Text = nguoitho.JobName;
            lb_Mail.Text = nguoitho.Email;
            lb_Sdt.Text = nguoitho.PhoneNumber;

            favCount = await CountFav(id);
            lb_FavTho.Text = favCount.ToString();
            doneJob =  CountJobs(nguoitho.DonePostIds);
            lb_DoneJob.Text = doneJob.ToString();

            if (nguoitho.AvatarUrl != "")
            {
                guna2CirclePictureBox1.Image = Image.FromStream(new MemoryStream(new WebClient().DownloadData(nguoitho.AvatarUrl)));

            }
            rating.Value = nguoitho.rate;
            lb_DoneJob.Text = CountJobs(nguoitho.DonePostIds).ToString();
            int c = await CountFav(id);
            lb_FavTho.Text = c.ToString();

            List<Review> listReview = await dt.GetAllReview(id);
            if (listReview == null)
            {
                return;
            }
            foreach (Review review in listReview)
            {
                var new_uc = new UCRating(review);
                flowLayoutPanel1.Controls.Add(new_uc);
            }
        }
        public int CountJobs(string listjob)
        {

            if (listjob == "")
            {
                return 0;
            }
            string[] jobs = listjob.Split(',');


            return jobs.Length;
        }
        private void guna2Shapes2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Shapes4_Click(object sender, EventArgs e)
        {

        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            var dt = new DB();
            await dt.AddUserToFavorites(id);
        }

        private async void bnt_Mess_Click(object sender, EventArgs e)
        {
            var dt = new DB();
            await dt.AddtoContact(id);
            string[] users = new string[] { GlobalVariables.id, id };
            Array.Sort(users);
            string combinedString = String.Join("-", users);
            FChat f = new FChat(id);
            f.ShowDialog();
        }


    }
}