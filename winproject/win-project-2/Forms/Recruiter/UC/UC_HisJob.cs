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
using win_project_2.Models;
using win_project_2.Service;

namespace win_project_2.Forms.Recruiter.UC
{
    public partial class UC_HisJob : UserControl
    {
        public UC_HisJob()
        {
            InitializeComponent();
        }
        int employerID = UserDangNhap.userId;
        ApplicationDAO application = new ApplicationDAO();
        JobDAO job = new JobDAO();
        public void load()
        {
            fpanelHienThi.Controls.Clear();
            List<Job> jobs = job.GetJobsByEmployer(employerID);
            foreach (Job job in jobs)
            {
                Jobmini jobMini = new Jobmini();

                // Lấy thông tin từ đối tượng Job
                int jobId = job.JobID;
                string title = job.Title;
                string salary = job.Salary;
                string status = job.Status;

                // Thêm thông tin vào Jobmini
                jobMini.themThongTin(jobId, title, salary, status);
                fpanelHienThi.Controls.Add(jobMini);
                jobMini.BringToFront();
            }
        }

        private void UC_HisJob_Load(object sender, EventArgs e)
        {
            load();
        }
    }

}
