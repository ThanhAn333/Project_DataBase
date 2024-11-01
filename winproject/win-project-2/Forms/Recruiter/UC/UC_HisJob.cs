using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_project_2.DAO;

namespace win_project_2.Forms.Recruiter.UC
{
    public partial class UC_HisJob : UserControl
    {
        public UC_HisJob()
        {
            InitializeComponent();
        }
        ApplicationDAO application = new ApplicationDAO();
        JobDAO job = new JobDAO();
        public void load()
        {
            fpanelHienThi.Controls.Clear();

            DataTable dt = job.DoDuLieuJob();
            foreach (DataRow row in dt.Rows)
            {
                Jobmini job = new Jobmini();
                int jobid = (int)row["JobID"];
                string title = row["Title"].ToString();
                string salary = row["Salary"].ToString();
                string status = row["status"].ToString();

                job.themThongTin(jobid, title, salary, status);
                fpanelHienThi.Controls.Add(job);
                job.BringToFront();
            }
        }

        private void UC_HisJob_Load(object sender, EventArgs e)
        {
            load();
        }
    }

}
