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

        public JobPost GetById(int jobPostID)
        {
            JobPost jobPost = null;
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT * FROM JobPosts WHERE JobPostID = @JobPostID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobPostID", jobPostID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    jobPost = new JobPost(
                        (int)reader["JobPostID"],
                        (int)reader["UserID"],
                        reader["Title"].ToString(),
                        reader["Description"].ToString(),
                        reader["Location"].ToString(),
                        (DateTime)reader["PostedDate"],
                        reader["Status"].ToString()
                    );
                }
            }
            return jobPost;
        }

        public List<JobPost> GetAll()
        {
            List<JobPost> jobPosts = new List<JobPost>();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT * FROM JobPosts";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    JobPost jobPost = new JobPost(
                        (int)reader["JobPostID"],
                        (int)reader["UserID"],
                        reader["Title"].ToString(),
                        reader["Description"].ToString(),
                        reader["Location"].ToString(),
                        (DateTime)reader["PostedDate"],
                        reader["Status"].ToString()
                    );
                    jobPosts.Add(jobPost);
                }
            }
            return jobPosts;
        }

        public void Add(JobPost jobPost)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "INSERT INTO JobPosts (UserID, Title, Description, Location, PostedDate, Status) VALUES (@UserID, @Title, @Description, @Location, @PostedDate, @Status)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", jobPost.UserID);
                cmd.Parameters.AddWithValue("@Title", jobPost.Title);
                cmd.Parameters.AddWithValue("@Description", jobPost.Description);
                cmd.Parameters.AddWithValue("@Location", jobPost.Location);
                cmd.Parameters.AddWithValue("@PostedDate", jobPost.PostedDate);
                cmd.Parameters.AddWithValue("@Status", jobPost.Status);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(JobPost jobPost)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "UPDATE JobPosts SET UserID = @UserID, Title = @Title, Description = @Description, Location = @Location, PostedDate = @PostedDate, Status = @Status WHERE JobPostID = @JobPostID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobPostID", jobPost.JobPostID);
                cmd.Parameters.AddWithValue("@UserID", jobPost.UserID);
                cmd.Parameters.AddWithValue("@Title", jobPost.Title);
                cmd.Parameters.AddWithValue("@Description", jobPost.Description);
                cmd.Parameters.AddWithValue("@Location", jobPost.Location);
                cmd.Parameters.AddWithValue("@PostedDate", jobPost.PostedDate);
                cmd.Parameters.AddWithValue("@Status", jobPost.Status);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int jobPostID)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "DELETE FROM JobPosts WHERE JobPostID = @JobPostID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobPostID", jobPostID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
