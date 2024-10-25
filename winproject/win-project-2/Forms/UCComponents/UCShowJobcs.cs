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
using win_project_2.Forms;

namespace win_project_2.UserControls
{
    public partial class UCShowJobcs : UserControl
    {
        private int jobid;
        public UCShowJobcs()
        {
            InitializeComponent();
            
        }
       

        
        
        public void thongtin(int id,string namejob, string salary, string location, string company, string date)
        {
            jobid = id;
            lblNameJob.Text = namejob;
            lblSalary.Text = salary;
            lblLocation.Text = location;
            lblCompany.Text = company;
            lbDate.Text = date;
        }
        public int GetJobID()
        {
            return jobid;
        }
        private void Detail_Click(object sender, EventArgs e)
        {

            FDetail1 fDetail1 = new FDetail1();

            // Lấy JobID từ biến và truyền sang form FDetail1
            int id = GetJobID();
            Job job = new Job();
            JobDAO jobDao = new JobDAO();
            job = jobDao.GetJobByID(id);
            

            if (job != null)
            {
                fDetail1.themThongTin(
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

                fDetail1.Show();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin công việc.");
            }
        }

    
    }
}
