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
using win_project_2.Forms.Candidate.UC;
using win_project_2.Service;

namespace win_project_2.Forms.Recruiter
{
    public partial class JobDetail : Form
    {
        private int jobID;
        public JobDetail()
        {
            InitializeComponent();
        }
        public void themThongTin(int jobid, string jobname, string description, string skillRequire, string location, string salary, string company, string type, string date, string status)
        {
            jobID = jobid;
            txt_title.Text = jobname;
            txt_des.Text = description;
            txt_skill.Text = skillRequire;
            txt_locaton.Text = location;
            txt_salary.Text = salary;
            txt_company.Text = company;
            txt_Type.Text = type;
            dtPostday.Text = date;
            txt_Status.Text = status;
        }
        int employer = UserDangNhap.userId;
        public int getJobID() { return jobID; }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa đơn công việc này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ApplicationDAO applicationDAO = new ApplicationDAO();
                JobDAO jobDAO = new JobDAO();
                jobDAO.DeleteJob(getJobID(), employer);
                MessageBox.Show("Đơn ứng tuyển đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                JobDetail_Load(sender, e);

            }
        }

        private void JobDetail_Load(object sender, EventArgs e)
        {
            JobDetail jobDetail = new JobDetail();
            jobDetail.Refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }
    }
}
