using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win_project_2.SQLConn;
using win_project_2.Models;
using System.Data;
using System.Security.Cryptography;

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
                SqlCommand command = new SqlCommand("sp_AddReview", connection);
                command.CommandType = CommandType.StoredProcedure;

                
                command.Parameters.AddWithValue("@CandidateID", review.CandidateID);
                command.Parameters.AddWithValue("@EmployerID", review.EmployerID);
                command.Parameters.AddWithValue("@Rating", review.Rating);
                command.Parameters.AddWithValue("@Comment", review.Comment ?? (object)DBNull.Value);
                

                
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable DoDuLieuBangReview(int userid)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string sql = "SELECT * FROM vw_Review WHERE CandidateID = @CandidateID";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@CandidateID", userid);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
    }
}
