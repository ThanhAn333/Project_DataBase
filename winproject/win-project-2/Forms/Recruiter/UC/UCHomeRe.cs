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
    public partial class UCHomeRe : UserControl
    {
        public UCHomeRe()
        {
            InitializeComponent();
            LoadAllJob();
        }

        void LoadAllJob()
        {
            JobDAO jobDAO = new JobDAO();
            List<Job> jobs = jobDAO.GetJobsByEmployer(UserDangNhap.userId);

            fpanelJob.Controls.Clear();

            foreach (Job job in jobs)
            {
                UC_Job uc_Job = new UC_Job();
                uc_Job.thongtin(
                    job.Title,
                    job.Salary,
                    job.Location,
                    job.Company
                );

                fpanelJob.Controls.Add(uc_Job);
            }
        }
    }
}
