using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void HomeRecruiter_Load(object sender, EventArgs e)
        {

        }

        private void btn_mini_profile_clicl(object sender, MouseEventArgs e)
        {
            this.Hide();
            FUserInfor fUserInfor = new FUserInfor(_userId);
            fUserInfor.Show();
        }
    }
}
