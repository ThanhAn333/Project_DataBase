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
        int _user_id;
        int _job_id;
        public FRating(int user_id, int job_id)
        {
            InitializeComponent();
            _user_id = user_id;
            _job_id = job_id;
        }

        private async void btn_up_Click(object sender, EventArgs e)
        {
            ReviewDAO reviewDAO = new ReviewDAO();

            Review review = new Review(
                userID: _user_id,
                jobID: _job_id,
                rating: (int)RatingStar.Value,
                comment: txb_cmt.Text,
                reviewDate: DateTime.Now
               );

            // Thêm Review vào cơ sở dữ liệu
            reviewDAO.AddReview(review);
        }
    }
}
