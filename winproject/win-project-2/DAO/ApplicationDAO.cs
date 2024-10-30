using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win_project_2.SQLConn;
using win_project_2.Models;
using System.Windows.Forms;

namespace win_project_2.DAO
{
    public class ApplicationDAO
    {
        private DatabaseConnection dbConn;

        public ApplicationDAO()
        {
            dbConn = new DatabaseConnection();
        }

        public void AddApplication(Applications application)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_AddApplication", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", application.Applicant.UserID);
                command.Parameters.AddWithValue("@JobID", application.AppliedJob.JobID);
                command.Parameters.AddWithValue("@Title", application.AppliedJob.Title);
                command.Parameters.AddWithValue("@Status", application.Status);
                command.Parameters.AddWithValue("@ApplicationDate", application.ApplicationDate);

                    connection.Open();
                    command.ExecuteNonQuery();
               
            }
        }

        // Read
        public Applications GetApplicationByID(int applicationId)
        {
            Applications application = null;

            using (SqlConnection connection = dbConn.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_GetApplicationByID", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ApplicationID", applicationId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    UserDAO userDAO = new UserDAO();
                    JobDAO jobDAO = new JobDAO();

                    User user = userDAO.GetUserByID((int)reader["UserID"]);
                    Job job = jobDAO.GetJobByID((int)reader["JobID"]);

                    application = new Applications(
                        (int)reader["ApplicationID"],
                        user,
                        job,
                        reader["Title"].ToString(),
                        reader["Status"].ToString(),
                        (DateTime)reader["ApplicationDate"]
                    );
                }
            }

            return application;
        }

        // Delete
        public void DeleteApplication(int applicationId)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_DeleteApplication", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ApplicationID", applicationId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public bool CheckApplicationExists(int userId, int jobId)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_CheckApplicationExists", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", userId);
                command.Parameters.AddWithValue("@JobID", jobId);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        public DataTable DoDuLieuApplication()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string sql = "SELECT * FROM vw_AllApplications";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dataTable);

            }
            return dataTable;

        }
    }
}
