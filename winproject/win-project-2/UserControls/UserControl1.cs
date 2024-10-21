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
using win_project_2.Forms;

namespace win_project_2.UserControls
{

    public partial class UCTho : UserControl
    {
        //public FMain ParentFMain { get; set; }
        
        public string id = "";
        public UCTho()
        {
            InitializeComponent();
            
        }

        public void LoadData()
        {
            
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
