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

        public Review GetById(int reviewID)
        {
            Review review = null;
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT * FROM Reviews WHERE ReviewID = @ReviewID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ReviewID", reviewID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    review = new Review(
                        (int)reader["ReviewID"],
                        (int)reader["UserID"],
                        (int)reader["JobID"],
                        (int)reader["Rating"],
                        reader["Comment"].ToString(),
                        (DateTime)reader["ReviewDate"]
                    );
                }
            }
            return review;
        }

        public List<Review> GetAll()
        {
            List<Review> reviews = new List<Review>();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT * FROM Reviews";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Review review = new Review(
                        (int)reader["ReviewID"],
                        (int)reader["UserID"],
                        (int)reader["JobID"],
                        (int)reader["Rating"],
                        reader["Comment"].ToString(),
                        (DateTime)reader["ReviewDate"]
                    );
                    reviews.Add(review);
                }
            }
            return reviews;
        }

        public void Add(Review review)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "INSERT INTO Reviews (UserID, JobID, Rating, Comment, ReviewDate) VALUES (@UserID, @JobID, @Rating, @Comment, @ReviewDate)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", review.UserID);
                cmd.Parameters.AddWithValue("@JobID", review.JobID);
                cmd.Parameters.AddWithValue("@Rating", review.Rating);
                cmd.Parameters.AddWithValue("@Comment", review.Comment);
                cmd.Parameters.AddWithValue("@ReviewDate", review.ReviewDate);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Review review)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "UPDATE Reviews SET UserID = @UserID, JobID = @JobID, Rating = @Rating, Comment = @Comment, ReviewDate = @ReviewDate WHERE ReviewID = @ReviewID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ReviewID", review.ReviewID);
                cmd.Parameters.AddWithValue("@UserID", review.UserID);
                cmd.Parameters.AddWithValue("@JobID", review.JobID);
                cmd.Parameters.AddWithValue("@Rating", review.Rating);
                cmd.Parameters.AddWithValue("@Comment", review.Comment);
                cmd.Parameters.AddWithValue("@ReviewDate", review.ReviewDate);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int reviewID)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "DELETE FROM Reviews WHERE ReviewID = @ReviewID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ReviewID", reviewID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
