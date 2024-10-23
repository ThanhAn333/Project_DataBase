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
using win_project_2.Forms.UC;

namespace win_project_2.Forms.Employer
{
    public partial class HomeEmployee : Form
    {
        private int _userId;
        public HomeEmployee(int userid)
        {
            InitializeComponent();
            _userId = userid;
        }
        public void addHienThi(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelHienThi.Controls.Clear();
            panelHienThi.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UCHome uC = new UCHome();
            panelHienThi.Controls.Add(uC);
            btnHome.Checked = true;
            btnApplication.Checked = false;
            btnMessage.Checked = false;
        }

        private void HomeEmployee_Load(object sender, EventArgs e)
        {
            panelHienThi.Controls.Clear();
            UCHome uC = new UCHome();
            panelHienThi.Controls.Add(uC);
            uC.Dock = DockStyle.Fill;
            uC.BringToFront();
            btnHome.Checked = true;
            btnApplication.Checked = false;
            btnMessage.Checked = false;
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            panelHienThi.Controls.Clear();
            UCApplication uCApplication = new UCApplication();
            addHienThi(uCApplication);
            btnHome.Checked = false;
            btnApplication.Checked = true;
            btnMessage.Checked = false;
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            panelHienThi.Controls.Clear();
            UCMessage uCMessage = new UCMessage();
            addHienThi(uCMessage);
            btnHome.Checked = false;
            btnApplication.Checked = false;
            btnMessage.Checked = true;
        }

        private void lb_mini_profile_click(object sender, MouseEventArgs e)
        {
            this.Hide();
            FUserInfor fUserInfor = new FUserInfor(_userId);
            fUserInfor.Show();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {

        }
    }
}
