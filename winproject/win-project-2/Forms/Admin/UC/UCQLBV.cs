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
using win_project_2.Models;

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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu đầu vào là số nguyên hợp lệ
            if (int.TryParse(tbtimkiemid.Text, out int jobId))
            {
                JobDAO jobDAO = new JobDAO();
                Job job = jobDAO.GetJobByID(jobId);

                if (job != null)
                {
                    // Đặt tất cả UC_Job trong FlowLayoutPanel về màu nền trong suốt
                    foreach (Control control in fpanelbv.Controls)
                    {
                        if (control is UC_Job ucJob)
                        {
                            ucJob.BackColor = Color.Transparent;
                        }
                    }

                    // Tìm kiếm UC_Job với JobID khớp và đặt màu đỏ
                    foreach (Control control in fpanelbv.Controls)
                    {
                        if (control is UC_Job ucJob && ucJob.jobid == jobId)
                        {
                            ucJob.BackColor = Color.Red;

                            // Cuộn đến UC_Job tìm thấy
                            fpanelbv.ScrollControlIntoView(ucJob);

                            return; // Dừng vòng lặp sau khi tìm thấy
                        }
                    }

                    // Thông báo nếu không tìm thấy UC_Job tương ứng với JobID đã nhập
                    MessageBox.Show("Không tìm thấy UserControl tương ứng với JobID đã nhập.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy công việc với JobID đã nhập.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập JobID hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                JobDAO jobDAO = new JobDAO(); // Tạo đối tượng JobDAO
                int jobId = Convert.ToInt32(tbtimkiemid.Text); // TextBox để nhập JobID
                jobDAO.DeleteJob1(jobId); // Gọi hàm DeleteJob thông qua đối tượng jobDAO
                AddJobsToPanel();
                MessageBox.Show("Xóa công việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
