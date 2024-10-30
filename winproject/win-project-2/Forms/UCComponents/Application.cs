using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_project_2.DAO;
using win_project_2.Forms.Candidate.UC;
using win_project_2.Forms.UC;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using win_project_2.Models;
using System.Security.Cryptography;


namespace win_project_2.Forms.UCComponents
{
    public partial class Application : UserControl
    {
        private int job_id;
        private int applicationID;
        public Application()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void themThongTin(int applicationid, int jobid, string title, string date, string status)
        {
            applicationID = applicationid;
            job_id=jobid;
            lbltitle.Text = title;
            lbdate.Text = date;
            lbstatus.Text = status;
        }
        public int GetJobID()
        {
            return job_id;
        }
        public int GetApplicationID()
        {
            return applicationID;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            FormDetailJob job = new FormDetailJob();
            int id = GetJobID();
            Job job1 = new Job();
            JobDAO jobDao = new JobDAO();
            job1 = jobDao.GetJobByID(id);


            if (job1 != null)
            {
                job.themThongTin(
                    GetApplicationID(),
                    job1.JobID,
                    job1.Title,
                    job1.Description,
                    job1.SkillRequire,
                    job1.Location,
                    job1.Salary,
                    job1.Company,
                    job1.Type,
                    job1.PostedDate.ToString()
                );

                job.Show();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin công việc.");
            }
        }
    }
}
