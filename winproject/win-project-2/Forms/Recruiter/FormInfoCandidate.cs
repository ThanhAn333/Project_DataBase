using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_project_2.DAO;
using win_project_2.Models;
using win_project_2.Service;

namespace win_project_2.Forms.Recruiter
{
    public partial class FormInfoCandidate : Form
    {
        private int userID;
        private int jobID;
        private int applicationId;
        private decimal Rating1;
        public FormInfoCandidate()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public void themThongTin(int applicationid,int jobid, int userid, string name, string birthday, string phone, string email, string address, decimal rating)
        {
            applicationId = applicationid;
            jobID = jobid;
            userID = userid;
            lb_YourName.Text = txb_Name.Text = name;
            txb_SDT.Text = phone;
            dtBirthday.Text = birthday;
            txb_Email.Text = email;
            txtaddress.Text = address;
            Rating1 = rating;
            
        
        }
        public decimal getRating()
        {
            return Rating1;
        }
        public int getUserID()
        {
            return userID;
        }
        public int getJobID()
        {
            return jobID;
        }
        public int getApplicationID()
        {
            return applicationId;
        }

        ApplicationDAO application = new ApplicationDAO();
        private void FormInfoCandidate_Load(object sender, EventArgs e)
        {
             
            SkillDAO skillDAO = new SkillDAO();
            List<Skill> skills = skillDAO.GetSkillsByUserId(getUserID());

            if (skills.Count > 0)
            {
                Skill skill = skills[0];
                txb_skill_name.Text = skill.Name;
                txb_skill_descript.Text = skill.Description;
                Level.SelectedItem = skill.ProficiencyLevel;
            }
            ReviewDAO reviewDAO = new ReviewDAO();
            DataTable dt = reviewDAO.DoDuLieuBangReview(getUserID());
            dgreview.DataSource = dt;

            rating1.Value = Convert.ToInt32(getRating());
            lbltrangthai.Text = application.GetApplicationStatus(getApplicationID());
            
        }

        private void btnRecject_Click(object sender, EventArgs e)
        {
           
            string currentStatus = application.GetApplicationStatus(getApplicationID());
            if(currentStatus == "Rejected")
            {
                MessageBox.Show("Đơn ứng tuyển này đã bị từ chối trước đó.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                application.UpdateApplication(getApplicationID(), "Rejected");
                MessageBox.Show("Trạng thái đã được cập nhật thành công thành 'Rejected'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FRating fRating = new FRating();
                fRating.themThongTin(getUserID());
                fRating.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnaccept_Click(object sender, EventArgs e)
        {
            ApplicationDAO application = new ApplicationDAO();
            string currentStatus = application.GetApplicationStatus(getApplicationID());
            if (currentStatus == "Accepted")
            {
                MessageBox.Show("Đơn ứng tuyển này đã được chấp nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                application.UpdateApplication(getApplicationID(), "Accepted");
                MessageBox.Show("Trạng thái đã được cập nhật thành công thành 'Accepted'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FRating fRating = new FRating();
                fRating.themThongTin(getUserID());
                fRating.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
