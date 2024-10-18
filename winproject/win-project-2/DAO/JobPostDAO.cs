using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win_project_2.SQLConn;

namespace win_project_2.DAO
{
    public class JobPostDAO
    {
        private DatabaseConnection dbConn;

        public JobPostDAO()
        {
            dbConn = new DatabaseConnection();
        }


        public List<JobPost> GetAll()
        {
            List<JobPost> jobPosts = new List<JobPost>();

            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = @"
            SELECT jp.JobPostID, jp.UserID, jp.Title, jp.Description, jp.Location, jp.Status,
                   u.Name AS UserName, u.Email AS UserEmail
            FROM JobPosts jp
            JOIN [dbo].[User] u ON jp.UserID = u.UserID"; 

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
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

                    JobPost jobPost = new JobPost(
                        (int)reader["JobPostID"],
                        user, 
                        reader["Title"].ToString(),
                        reader["Description"].ToString(),
                        reader["Location"].ToString(),
                        reader["Status"].ToString(),
                        (DateTime)reader["PostedDate"]
                    );

                    jobPosts.Add(jobPost);
                }
            }

            return jobPosts;
        }

        public void AddJobPost(JobPost jobPost)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "INSERT INTO JobPost (UserID, Title, Description, Location, Status, PostedDate) VALUES (@UserID, @Title, @Description, @Location, @Status, @PostedDate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", jobPost.Recruiter.UserID);
                command.Parameters.AddWithValue("@Title", jobPost.Title);
                command.Parameters.AddWithValue("@Description", jobPost.Description);
                command.Parameters.AddWithValue("@Location", jobPost.Location);
                command.Parameters.AddWithValue("@Status", jobPost.Status);
                command.Parameters.AddWithValue("@PostedDate", jobPost.PostedDate);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Read
        public JobPost GetJobPostByID(int jobPostId)
        {
            JobPost jobPost = null;

            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "SELECT * FROM [dbo].[JobPost] WHERE JobPostID = @JobPostID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@JobPostID", jobPostId);

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

                    jobPost = new JobPost(
                        (int)reader["JobPostID"],
                        user,
                        reader["Title"].ToString(),
                        reader["Description"].ToString(),
                        reader["Location"].ToString(),
                        reader["Status"].ToString(),
                        (DateTime)reader["PostedDate"]
                    );
                }
            }

            return jobPost;
        }

        // Update
        public void UpdateJobPost(JobPost jobPost)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "UPDATE JobPost SET Title = @Title, Description = @Description, Location = @Location, Status = @Status, PostedDate = @PostedDate WHERE JobPostID = @JobPostID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", jobPost.Title);
                command.Parameters.AddWithValue("@Description", jobPost.Description);
                command.Parameters.AddWithValue("@Location", jobPost.Location);
                command.Parameters.AddWithValue("@Status", jobPost.Status);
                command.Parameters.AddWithValue("@PostedDate", jobPost.PostedDate);
                command.Parameters.AddWithValue("@JobPostID", jobPost.JobPostID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Delete
        public void DeleteJobPost(int jobPostId)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "DELETE FROM [dbo].[JobPost] WHERE JobPostID = @JobPostID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@JobPostID", jobPostId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
