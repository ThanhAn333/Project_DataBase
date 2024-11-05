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
using win_project_2.UserControls;

namespace win_project_2.Forms.Recruiter.UC
{
    public partial class UCHomeRe : UserControl
    {
        public UCHomeRe()
        {
            InitializeComponent();
        }
        int employerID = UserDangNhap.userId;
        JobDAO jobDao = new JobDAO();
        private DataTable search;
        private void FilterResults(string selectedTitle)
        {
            if (search != null)
            {
                DataView view = new DataView(search);
                if (selectedTitle == "Tất cả" || string.IsNullOrEmpty(selectedTitle))
                {
                    addJob(search);
                }
                else
                {
                    view.RowFilter = $"Title = '{selectedTitle}'";
                    if (view.Count > 0)
                    {
                        addJob(view.ToTable());
                    }
                    else
                    {
                        fpanelJob.Controls.Clear();
                        MessageBox.Show("Không tìm thấy kết quả phù hợp cho vị trí đã chọn.");
                    }
                }
            }
        }
        public void addJob(DataTable dt)
        {
            fpanelJob.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                UC_Job uCJob = new UC_Job();
                int id = (int)row["JobID"];
                string jobname = row["Title"].ToString();
                string company = row["Company"].ToString();
                string salary = row["Salary"].ToString();
                string location = row["Location"].ToString();
                uCJob.thongtin(id, jobname, salary, location, company);
                fpanelJob.Controls.Add(uCJob);
            }
        }
        public void addJob1(List<Job> jobList)
        {
            fpanelJob.Controls.Clear();

            foreach (var job in jobList)
            {
                UC_Job uCJob = new UC_Job();
                uCJob.thongtin(job.JobID, job.Title, job.Salary, job.Location, job.Company);
                fpanelJob.Controls.Add(uCJob);
            }
        }
        public void load()
        {
            fpanelJob.Controls.Clear();
            List<Job> jobList = jobDao.GetJobsByEmployer(employerID);
            addJob1(jobList);

        }
        private void cbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fpanelJob != null)
            {
                fpanelJob.Controls.Clear();
            }

            if (cbTitle.SelectedIndex == 0)
            {
                load();
            }
            else
            {
                string type = cbTitle.SelectedItem.ToString();
                DataTable dt = jobDao.LayDuLieuLocation(type);
                addJob(dt);
            }
        }

        private void UCHomeRe_Load(object sender, EventArgs e)
        {
            load();
            DataTable dt = jobDao.HienThiTitle();
            cbTitle.Items.Clear();
            cbTitle.Items.Add("Tất cả");
            foreach (DataRow dr in dt.Rows)
            {
                string title = dr["Title"].ToString();
                cbTitle.Items.Add(title);
            }
            cbTitle.SelectedIndex = 0;

        }

        public static int indexcbo = 4;

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string selectedTitle = cbTitle.SelectedItem?.ToString() ?? string.Empty;

            // Tìm kiếm tất cả nếu không có từ khóa và vị trí
            if ((selectedTitle == "Tất cả" || string.IsNullOrEmpty(selectedTitle)))
            {
                load();
            }
            else
            {
                // Tìm kiếm công việc
                FilterResults(selectedTitle); // Lọc kết quả theo vị trí đã chọn
            }
        }

        private void cbTitle_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (fpanelJob != null)
            {
                fpanelJob.Controls.Clear();
            }

            if (cbTitle.SelectedIndex == 0)
            {
                load();
            }
            else
            {
                string title = cbTitle.SelectedItem.ToString();
                DataTable dt = jobDao.LayDuLieuTitle(title);
                addJob(dt);
            }
        }
    }
}
