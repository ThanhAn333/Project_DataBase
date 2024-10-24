using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win_project_2.SQLConn;
using win_project_2.Models;

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
                        "",  
                        reader["Role"]?.ToString(), 
                        reader["Address"]?.ToString(), 
                        (DateTime)reader["DateOfBirth"], 
                        reader["PhoneNumber"]?.ToString(),
                        reader["ProfilePicture"]?.ToString(), 
                        (DateTime)reader["CreatedAt"],
                        (DateTime)reader["UpdatedAt"]  
                   );

                    Job job = new Job(
                        (int)reader["JobID"],
                        reader["JobTitle"].ToString(),
                        reader["JobDescription"].ToString(),
                        reader["Location"].ToString(),
                        reader["SkillRequire"].ToString(),
                        reader["Salary"].ToString(), 
                        reader["Type"]?.ToString(), 
                        reader["Company"]?.ToString(), 
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
