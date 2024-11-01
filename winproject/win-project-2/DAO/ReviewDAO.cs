using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win_project_2.SQLConn;
using win_project_2.Models;
using System.Data;

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
                SqlCommand command = new SqlCommand("sp_AddNewReview", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số cho thủ tục lưu trữ
                command.Parameters.AddWithValue("@UserID", review.UserID);
                command.Parameters.AddWithValue("@JobID", review.JobID);
                command.Parameters.AddWithValue("@Rating", review.Rating);
                command.Parameters.AddWithValue("@Comment", review.Comment ?? (object)DBNull.Value);

                // Mở kết nối và thực thi thủ tục lưu trữ
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
