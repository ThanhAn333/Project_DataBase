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
       
        private async void LoadData(string id)
        {
            
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
            
        }

        private async void bnt_Mess_Click(object sender, EventArgs e)
        {
           
        }


    }
}