using Firebase.Auth;
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
using win_project_2.Forms;

namespace win_project_2.UserControls
{

    public partial class UCTho : UserControl
    {
        public FMain ParentFMain { get; set; }
        public NguoiTho Tho { get; private set; }
        public string id = "";
        public UCTho(NguoiTho nguoitho)
        {
            InitializeComponent();
            LoadData(nguoitho);
        }

        public void LoadData(NguoiTho nguoitho)
        {
            lb_job.Text = nguoitho.JobName;
            lb_Name.Text = nguoitho.Name;
            if (nguoitho.AvatarUrl != "")
            {
                guna2CirclePictureBox1.Image = Image.FromStream(new MemoryStream(new WebClient().DownloadData(nguoitho.AvatarUrl)));
            }
            id = nguoitho.Id;
        }

        private void lb_job_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            var dt = new DB();
            await dt.AddtoContact(id);
            GlobalVariables.other_user = id;
            FChat f = new FChat(id);
            f.ShowDialog();
            //this.ParentFMain.openFChat();
        }

        private void bt_detail_Click(object sender, EventArgs e)
        {
            ThoDetail f = new ThoDetail(id);
            f.ShowDialog();
        }

        private void guna2Shapes1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
