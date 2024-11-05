using Microsoft.AspNet.SignalR.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_project_2.DAO;
using win_project_2.Models;
using win_project_2.Service;


namespace win_project_2.Forms
{
    public partial class FDetail1 : Form
    {
        private int jobID;
        public FDetail1()
        {
            InitializeComponent();

        }

        public void themThongTin(int jobid, string jobname, string description, string skillRequire,string location, string salary, string company, string type, string date)
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
        private void FDetail1_Load(object sender, EventArgs e)
        {

        }

        private void Nopdon_Click(object sender, EventArgs e)
        {
            int userId = UserDangNhap.userId;
            int jobId = jobID;
            string title = lb_jobname.Text;
            string status = "Pending";
            int employer = UserDangNhap.userId;
            DateTime applicationDate = DateTime.Parse(lbdate.Text);  

            User applicant = new User(userId, "UserName", "Email", "", "Role", "Address", DateTime.Now, "Phone", "Profile", DateTime.Now, DateTime.Now);

            Job appliedJob = new Job(jobId, title, "Description", "Location", "SkillRequire", "Salary", "Type", "Company", DateTime.Now, "Status", employer);

            win_project_2.Models.Applications application = new win_project_2.Models.Applications(0, applicant, appliedJob,title, status, applicationDate);

            ApplicationDAO applicationDAO = new ApplicationDAO();
            if (!applicationDAO.checkAgeApplication(userId))
            {
                MessageBox.Show("Bạn không đủ tuổi để nộp đơn ứng tuyển. Vui lòng kiểm tra lại thông tin của bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng lại nếu không đủ tuổi
            }
            if (applicationDAO.CheckApplicationExists(userId, jobId))
            {
                MessageBox.Show("Bạn đã nộp đơn cho công việc này rồi!");
                this.Close();
            }
            else
            {

                try
                {
                    
                    applicationDAO.AddApplication(application);
                    MessageBox.Show("Đã nộp đơn ứng tuyển thành công !");
                    this.Close();
                }
                catch (SqlException ex)
                {
                    // Kiểm tra mã lỗi để xác định nếu đó là lỗi từ trigger
                    if (ex.Number == 50000) // Số lỗi từ RAISERROR
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        // Xử lý lỗi khác nếu cần
                        MessageBox.Show("Đã xảy ra lỗi khi thêm đơn ứng tuyển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
