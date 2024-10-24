using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Web.Security;
using win_project_2.DAO;

namespace win_project_2.Forms.Recruiter.UC
{
    public partial class UCPostJob : UserControl
    {
        public UCPostJob()
        {
            InitializeComponent();
        }

        private void btn_PostJob_Click(object sender, EventArgs e)
        {
            string title = lb_namejob.Text;
            string description = lb_des.Text;
            string location = lb_location.Text;
            decimal salary;
            string type = lb_type.Text;
            string company = lb_company.Text;
            string status = lb_status.Text;
            DateTime postedDate = dtPostDay.Value;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(location) || !decimal.TryParse(lb_salary.Text, out salary) || string.IsNullOrEmpty(type) || string.IsNullOrEmpty(company) || string.IsNullOrEmpty(status))
            {
                lbError.Visible = true;
                lbError.Text = "Vui lòng điền đầy đủ thông tin !";
                return;
            }

            try
            {
                JobDAO jobDAO = new JobDAO();
                jobDAO.AddJob(title, description, location, salary, type, company, status, postedDate);
                MessageBox.Show("Thêm công việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lbError.Visible = true;
                lbError.Text = $"Đã xảy ra lỗi: {ex.Message}";
            }
        }
    }
}
