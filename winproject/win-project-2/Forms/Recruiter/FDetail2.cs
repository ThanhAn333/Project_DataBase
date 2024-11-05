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
using win_project_2.Forms.Recruiter.UC;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using win_project_2.Models;

namespace win_project_2.Forms.Recruiter
{
    public partial class FDetail2 : Form
    {
        private int jobID;
        public FDetail2()
        {
            InitializeComponent();
        }

        public void themThongTin(int jobid, string jobname, string description, string skillRequire, string location, string salary, string company, string type, string date)
        {
            jobID = jobid;
            lb_jobname.Text = jobname;
            lbDescrip.Text = description;
            lbRequest.Text = skillRequire;
            lbLocation.Text = location;
            lbSalary.Text = salary;
            lbCompany.Text = company;
            lbType.Text = type;
            lbdate.Text = date;

        }
        public int GetJobID()
        {
            return jobID;
        }
        private void btnXemUngVien_Click(object sender, EventArgs e)
        {
            FormApplicationCandidate formApplicationCandidate = new FormApplicationCandidate();

            int id = GetJobID();
            Job job = new Job();
            JobDAO jobDao = new JobDAO();
            job = jobDao.GetJobByID(id);


            if (job != null)
            {
               formApplicationCandidate.themThongTin(
                    job.JobID
                );

                formApplicationCandidate.Show();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin công việc.");
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
