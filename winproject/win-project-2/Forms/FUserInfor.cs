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

namespace win_project_2.Forms
{
    public partial class FUserInfor : Form
    {
        string FileImageName = "";
        bool Istho;

        public FUserInfor()
        {
            InitializeComponent();
            LoadData();
        }
        public int CountJobs(string listjob)
        {
            
            if(listjob == "")
            {
                return 0;
            }
            string[] jobs = listjob.Split(',');

            
            return jobs.Length;
        }

        private async void LoadData()
        {
            var dt = new DB();
            NguoiTho nguoitho = await dt.GetInfoNguoiTho(GlobalVariables.id);
            if (nguoitho == null)
            {
                NguoiTimTho nguoitimtho = await dt.GetInfoNguoiTimTho(GlobalVariables.id);
                Istho = nguoitimtho.IsTho;
                lb_YourName.Text = nguoitimtho.Name;
                txb_Name.Text = nguoitimtho.Name;
                txb_SDT.Text = nguoitimtho.PhoneNumber;
                txb_Email.Text = nguoitimtho.Email;
                lb_FavTho.Text = CountJobs(nguoitimtho.FavThoIds).ToString();
                if (nguoitimtho.AvatarUrl != "")
                {
                    guna2CirclePictureBox1.Image = Image.FromStream(new MemoryStream(new WebClient().DownloadData(nguoitimtho.AvatarUrl)));

                }
                lb_YourJob.Text = "";
                txb_JobName.Enabled = false;
                txb_Study.Enabled = false;
                txb_exp.Enabled = false;
                txb_Skill.Enabled = false;
            }
            else
            {
                Istho = nguoitho.IsTho;
                lb_YourName.Text = nguoitho.Name;
                txb_Name.Text = nguoitho.Name;
                txb_JobName.Text = nguoitho.JobName;
                lb_YourJob.Text = nguoitho.JobName;
                txb_Email.Text = nguoitho.Email;
                txb_SDT.Text = nguoitho.PhoneNumber;
                guna2RatingStar1.Value = nguoitho.rate;
                lb_DoneJob.Text = CountJobs(nguoitho.DonePostIds).ToString();
                txb_Study.Text = nguoitho.Study;
                txb_Skill.Text = nguoitho.Skills;
                if (nguoitho.AvatarUrl != "")
                {
                    guna2CirclePictureBox1.Image = Image.FromStream(new MemoryStream(new WebClient().DownloadData(nguoitho.AvatarUrl)));

                }
            }
        }

        private void FThoInfor_Load(object sender, EventArgs e)
        {
            var dt = new DB();
        }

        private void lb_YourJob_Click(object sender, EventArgs e)
        {

        }

        private void guna2RatingStar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Shapes7_Click(object sender, EventArgs e)
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadImage(ref FileImageName);

            // Sử dụng using để đảm bảo tài nguyên được giải phóng
            using (var tempImage = new Bitmap(FileImageName))
            {
                guna2CirclePictureBox1.Image = new Bitmap(tempImage);
                
            }
        }

        private async void btn_Luu_Click(object sender, EventArgs e)
        {

            var dt = new DB();
            var path = "";
            if (FileImageName != "")
            {
                path = await dt.uploadFile(FileImageName);
            }
            if (Istho)
            {
                NguoiTho temp = await dt.GetInfoNguoiTho(GlobalVariables.id);
                NguoiTho nguoitho = new NguoiTho(temp.DonePostIds, txb_Name.Text, "", txb_SDT.Text, path, txb_Email.Text, "", true, GlobalVariables.id, txb_JobName.Text, "", 1000, txb_Skill.Text
                    , "", txb_Study.Text, guna2RatingStar1.Value);
                await dt.UploadInfoNguoiTho(nguoitho);
            }
            else
            {
                NguoiTimTho temp = await dt.GetInfoNguoiTimTho(GlobalVariables.id);
                NguoiTimTho nguoitimtho = new NguoiTimTho(temp.FavThoIds, temp.FavThoIds, txb_Name.Text, "", txb_SDT.Text, path, txb_Email.Text, "", false, GlobalVariables.id);
                await dt.UploadInfoNguoiTimTho(nguoitimtho);
            }
        }

        private void guna2Shapes2_Click(object sender, EventArgs e)
        {

        }
    }
}
