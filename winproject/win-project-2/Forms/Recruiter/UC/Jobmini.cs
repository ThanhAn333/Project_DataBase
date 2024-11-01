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
using win_project_2.Models;
using win_project_2.Service;

namespace win_project_2.Forms.Recruiter.UC
{
    public partial class Jobmini : UserControl
    {
        private int jobID;
        UserDangNhap us = new UserDangNhap();
        int employer = UserDangNhap.userId;
        public Jobmini()
        {
            InitializeComponent();
        }
        public void themThongTin(int jobid, string title, string salary, string status)
        {
            jobID = jobid;
            lbltitle.Text = title;
            lbsalary.Text = salary;
            lbstatus.Text = status;
        }
        public int GetJobID()
        {
            return jobID;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            JobDetail job = new JobDetail();
            int id_job = GetJobID();
            Job job1 = new Job();
            JobDAO jobDao1 = new JobDAO();
            job1 = jobDao1.GetJobByID(id_job);

            if (job1 != null)
            {
                job.themThongTin(
                    GetJobID(),
                    job1.Title,
                    job1.Description,
                    job1.SkillRequire,
                    job1.Location,
                    job1.Salary,
                    job1.Company,
                    job1.Type,
                    job1.PostedDate,
                    job1.Status
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
