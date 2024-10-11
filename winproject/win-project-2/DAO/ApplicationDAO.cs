using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win_project_2.SQLConn;

namespace win_project_2.DAO
{
    public class ApplicationDAO
    {
        private DatabaseConnection dbConn;

        public ApplicationDAO()
        {
            dbConn = new DatabaseConnection();
        }

        public Application GetById(int applicationID)
        {
            Application application = null;
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ApplicationID", applicationID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    application = new Application(
                        (int)reader["ApplicationID"],
                        (int)reader["UserID"],
                        (int)reader["JobID"],
                        (DateTime)reader["ApplicationDate"],
                        reader["Status"].ToString()
                    );
                }
            }
            return application;
        }

        public List<Application> GetAll()
        {
            List<Application> applications = new List<Application>();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT * FROM Applications";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Application application = new Application(
                        (int)reader["ApplicationID"],
                        (int)reader["UserID"],
                        (int)reader["JobID"],
                        (DateTime)reader["ApplicationDate"],
                        reader["Status"].ToString()
                    );
                    applications.Add(application);
                }
            }
            return applications;
        }

        public void Add(Application application)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "INSERT INTO Applications (UserID, JobID, ApplicationDate, Status) VALUES (@UserID, @JobID, @ApplicationDate, @Status)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", application.UserID);
                cmd.Parameters.AddWithValue("@JobID", application.JobID);
                cmd.Parameters.AddWithValue("@ApplicationDate", application.ApplicationDate);
                cmd.Parameters.AddWithValue("@Status", application.Status);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Application application)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "UPDATE Applications SET UserID = @UserID, JobID = @JobID, ApplicationDate = @ApplicationDate, Status = @Status WHERE ApplicationID = @ApplicationID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ApplicationID", application.ApplicationID);
                cmd.Parameters.AddWithValue("@UserID", application.UserID);
                cmd.Parameters.AddWithValue("@JobID", application.JobID);
                cmd.Parameters.AddWithValue("@ApplicationDate", application.ApplicationDate);
                cmd.Parameters.AddWithValue("@Status", application.Status);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int applicationID)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "DELETE FROM Applications WHERE ApplicationID = @ApplicationID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ApplicationID", applicationID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
