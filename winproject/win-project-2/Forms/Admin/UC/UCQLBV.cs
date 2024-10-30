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

namespace win_project_2.UserControls
{
    public partial class UCQLBV : UserControl
    {
        public UCQLBV()
        {
            InitializeComponent();
            AddJobsToPanel();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AddJobsToPanel()
        {
            // Xóa các control cũ trong panelbv
            fpanelbv.Controls.Clear();

            // Tạo một thể hiện của JobDAO và lấy DataTable
            JobDAO jobDao = new JobDAO();
            DataTable jobsDataTable = jobDao.DoDuLieuJob();

            // Duyệt qua từng hàng trong DataTable
            foreach (DataRow row in jobsDataTable.Rows)
            {
                // Khởi tạo UC_Job và thiết lập dữ liệu từ DataRow
                UC_Job ucJob = new UC_Job();
                ucJob.SetData(row);

                // Đặt Margin cho UC_Job
                ucJob.Margin = new Padding(10);

                // Thêm UC_Job vào panelbv
                fpanelbv.Controls.Add(ucJob);
            }
        }

    }
}
