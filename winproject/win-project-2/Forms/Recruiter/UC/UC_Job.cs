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

namespace win_project_2.Forms.Recruiter.UC
{
    public partial class UC_Job : UserControl
    {
        public  int jobid;
        public UC_Job()
        {
            InitializeComponent();
        }
        public void thongtin(int id, string namejob, string salary, string location, string company)
        {
            jobid = id;
            lblNameJob.Text = namejob;
            lblSalary.Text = salary;
            lblLocation.Text = location;
            lblCompany.Text = company;
        }
        public int GetJobID()
        {
            return jobid;
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {

            FDetail2 fDetail2 = new FDetail2();

            // Lấy JobID từ biến và truyền sang form FDetail1
            int id = GetJobID();
            Job job = new Job();
            JobDAO jobDao = new JobDAO();
            job = jobDao.GetJobByID(id);


            if (job != null)
            {
                fDetail2.themThongTin(
                    job.JobID,
                    job.Title,
                    job.Description,
                    job.SkillRequire,
                    job.Location,
                    job.Salary,
                    job.Company,
                    job.Type,
                    job.PostedDate.ToString()
                );

                fDetail2.Show();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin công việc.");
            }

        }
        public void SetData(DataRow row)
        {

            jobid = Convert.ToInt32(row["JobID"]);
            lblNameJob.Text = row["Title"].ToString();    // Tên cột trong DataTable
            lblSalary.Text = row["Salary"].ToString();
            lblLocation.Text = row["Location"].ToString();
            lblCompany.Text = row["Company"].ToString();
        }

    }
}
