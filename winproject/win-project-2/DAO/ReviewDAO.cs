using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win_project_2.SQLConn;

namespace win_project_2.DAO
{
    public class ReviewDAO
    {
        private DatabaseConnection dbConn;

        public ReviewDAO()
        {
            dbConn = new DatabaseConnection();
        }

        // Create
        public void AddReview(Review review)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "INSERT INTO Review (UserID, JobID, Rating, Comment, ReviewDate) VALUES (@UserID, @JobID, @Rating, @Comment, @ReviewDate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", review.Reviewer.UserID);
                command.Parameters.AddWithValue("@JobID", review.Job.JobID);
                command.Parameters.AddWithValue("@Rating", review.Rating);
                command.Parameters.AddWithValue("@Comment", review.Comment);
                command.Parameters.AddWithValue("@ReviewDate", review.ReviewDate);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Read
        public Review GetReviewByID(int reviewId)
        {
            Review review = null;

            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "SELECT * FROM [dbo].[Review] WHERE ReviewID = @ReviewID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ReviewID", reviewId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    User user = new User(
                         (int)reader["UserID"],
                        reader["UserName"].ToString(),
                        reader["UserEmail"].ToString(),
                        "",  // Chưa có mật khẩu, có thể bỏ qua hoặc xử lý sau
                        reader["Role"]?.ToString(), // Sử dụng toán tử null-conditional để tránh lỗi null
                        reader["Address"]?.ToString(), // Giả sử bạn đã thêm Address trong User
                        (DateTime)reader["DateOfBirth"], // Ngày sinh
                        reader["PhoneNumber"]?.ToString(), // Số điện thoại
                        reader["ProfilePicture"]?.ToString(), // Hình đại diện
                        (DateTime)reader["CreatedAt"], // Ngày tạo
                        (DateTime)reader["UpdatedAt"]  // Ngày cập nhật
                   );

                    Job job = new Job(
                        (int)reader["JobID"],
                        reader["JobTitle"].ToString(),
                        reader["JobDescription"].ToString(),
                        reader["Location"].ToString(),
                        reader["Salary"].ToString(), // Giả sử bạn đã thêm Salary trong Job
                        reader["Type"]?.ToString(), // Loại công việc
                        reader["Company"]?.ToString(), // Tên công ty
                        (DateTime)reader["PostedDate"],
                        reader["Status"]?.ToString()
                    );
                    review = new Review(
                        (int)reader["ReviewID"],
                        user,
                        job,
                        (int)reader["Rating"],
                        reader["Comment"].ToString(),
                        (DateTime)reader["ReviewDate"]
                    );
                }
            }

            return review;
        }

        // Update
        public void UpdateReview(Review review)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "UPDATE Review SET Rating = @Rating, Comment = @Comment, ReviewDate = @ReviewDate WHERE ReviewID = @ReviewID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Rating", review.Rating);
                command.Parameters.AddWithValue("@Comment", review.Comment);
                command.Parameters.AddWithValue("@ReviewID", review.ReviewID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Delete
        public void DeleteReview(int reviewId)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "DELETE FROM Review WHERE ReviewID = @ReviewID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ReviewID", reviewId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
