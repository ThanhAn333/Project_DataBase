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

namespace win_project_2.Forms.Recruiter.UC
{
    public partial class UCCandidate : UserControl
    {
        private int userID;
        private int jobID;
        public UCCandidate()
        {
            InitializeComponent();
        }
        public void themThongTin(int jobid, int userid, string name, string email, string date)
        {
            jobID = jobid;
            userID = userid;
            lblname.Text = name;
            lblemail.Text = email;
            lbldate.Text = date;
        }
        public int getUserID()
        {
            return userID;
        }

        public int getJobID()
        {
            return jobID;
        }
        private void UCCandidate_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();

            DataTable dt = userDAO.doDuLieuThongTinNguoidung(getUserID(),getJobID());
            foreach (DataRow row in dt.Rows)
            {

                FormInfoCandidate formInfoCandidate = new FormInfoCandidate();
                int applicationid = (int)row["ApplicationID"];
                int jobid = (int)row["JobID"];
                int userid = (int)row["UserID"];
                string name = row["CandidateName"].ToString();
                string email = row["CandidateEmail"].ToString();
                string address = row["Address"].ToString();
                string date = row["DateOfBirth"].ToString();
                string phone = row["PhoneNumber"].ToString();
                decimal rating = (decimal)row["Rating"];
                formInfoCandidate.themThongTin(applicationid,jobid,userid, name, date, phone, email, address, rating);
               
                formInfoCandidate.Show();

            }
        }
    }
}
