using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_project_2.Forms.Candidate.UC;
using win_project_2.Forms.Recruiter.UC;
using win_project_2.Forms.UC;
using win_project_2.Forms.UCComponents;

namespace win_project_2.Forms.Recruiter
{
    public partial class HomeRecruiter : Form
    {
        private int _userId;
        public HomeRecruiter(int userid)
        {
            InitializeComponent();
            _userId = userid;
        }

        public void addHienThi(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnHienThi.Controls.Clear();
            pnHienThi.Controls.Add(uc);
            uc.BringToFront();
        }
        private void HomeRecruiter_Load(object sender, EventArgs e)
        {
            panelHienThi.Controls.Clear();
            UCHomeRe uC = new UCHomeRe();
            addHienThi(uC);
            btn_Home.Checked = true;
            btnPostJob.Checked = false;
            btnHisJob.Checked = false;
            btnMessage.Checked = false;
        }
        private void btn_mini_profile_click(object sender, MouseEventArgs e)
        {
            this.Hide();
            FUserInfor fUserInfor = new FUserInfor();
            fUserInfor.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void btn_Home_Click_1(object sender, EventArgs e)
        {
            pnHienThi.Controls.Clear();
            UCHomeRe uC = new UCHomeRe();
            addHienThi(uC);
            btn_Home.Checked = true;
            btnPostJob.Checked = false;
            btnMessenge.Checked = false;
            btnHisJob.Checked = false;
        }
        private void btnPostJob_Click(object sender, EventArgs e)
        {
            pnHienThi.Controls.Clear();
            UCPostJob uCPostJob = new UCPostJob();
            addHienThi(uCPostJob);
            btn_Home.Checked = false;
            btnPostJob.Checked = true;
            btnMessenge.Checked = false;
            btnHisJob.Checked = false;
        }

        private void btnMessenge_Click_1(object sender, EventArgs e)
        {
            pnHienThi.Controls.Clear();

            FormChat formChat = new FormChat(_userId);
            formChat.Show();
        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            pnHienThi.Controls.Clear();
            UC_HisJob uC_HisJob = new UC_HisJob();
            addHienThi(uC_HisJob);
            btnHisJob.Checked = true;
            btn_Home.Checked = false;
            btnPostJob.Checked = false;
            btnMessenge.Checked = false;
        }

        
    }
}
