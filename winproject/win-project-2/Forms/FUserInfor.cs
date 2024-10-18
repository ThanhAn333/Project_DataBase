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
           
            
        }

        private void FThoInfor_Load(object sender, EventArgs e)
        {
           
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
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private async void btn_Luu_Click(object sender, EventArgs e)
        {

            
        }

        private void guna2Shapes2_Click(object sender, EventArgs e)
        {

        }
    }
}
