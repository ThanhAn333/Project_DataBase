using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using win_project_2.DAO;
using win_project_2.Models;
using win_project_2.Service;


namespace win_project_2.Forms
{
    public partial class FRating : Form
    {
        private int candidateID;
        public FRating()
        {
            InitializeComponent();
        }

        public void themThongTin(int candidateid)
        {
            candidateID = candidateid;
        }

        private async void btn_up_Click(object sender, EventArgs e)
        {
            try
            {
                ReviewDAO reviewDAO = new ReviewDAO();

                Review review = new Review(
                    candidateID,
                    UserDangNhap.userId,
                    rating: (int)RatingStar.Value,
                    comment: txb_cmt.Text,
                    reviewDate: DateTime.Now
                );

                // Thêm Review vào cơ sở dữ liệu
                reviewDAO.AddReview(review);

                // Hiển thị thông báo thành công và đóng form
                MessageBox.Show("Thêm đánh giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm đánh giá: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
