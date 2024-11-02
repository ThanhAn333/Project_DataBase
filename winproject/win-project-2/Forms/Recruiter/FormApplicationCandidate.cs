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

namespace win_project_2.Forms.Recruiter
{
    public partial class FormApplicationCandidate : Form
    {
        private int jobID;
        public FormApplicationCandidate()
        {
            InitializeComponent();
        }
        ApplicationDAO application = new ApplicationDAO();
        public void themThongTin(int jobid)
        {
            jobID = jobid;
        }
        public int getJobID()
        {
            return jobID;
        }

        private void FormApplicationCandidate_Load(object sender, EventArgs e)
        {
            panelHienThi.Controls.Clear();

            DataTable dt = application.DoDuLieuCandidateApplication(getJobID());
            foreach (DataRow row in dt.Rows)
            {
                
                UCCandidate uCCandidate = new UCCandidate();
                int userid = (int)row["UserID"];
                string name = row["CandidateName"].ToString();
                string email = row["CandidateEmail"].ToString();
                string date = row["ApplicationDate"].ToString();

                
                uCCandidate.themThongTin(userid, name, email, date);
                panelHienThi.Controls.Add(uCCandidate);
                uCCandidate.BringToFront();
            }
        }
    }
}
