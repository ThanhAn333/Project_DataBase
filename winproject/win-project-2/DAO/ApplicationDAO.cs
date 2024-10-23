using System;
using System.Collections.Generic;
using System.Data;
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

        public List<Application> GetAllApplications()
        {
            List<Application> applications = new List<Application>();

            using (SqlConnection connection = dbConn.GetConnection() )
            {
                string query = @"SELECT a.ApplicationID, a.UserID, a.JobID, a.ApplicationDate, a.Status, u.Name AS UserName, u.Email AS UserEmail, j.Title AS JobTitle, j.Description AS JobDescription FROM Application a JOIN Users u ON a.UserID = u.UserID JOIN Job j ON a.JobID = j.JobID";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
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

                  
                    Application application = new Application(
                        (int)reader["ApplicationID"],
                        user, 
                        job, 
                        reader["Status"].ToString(),
                        (DateTime)reader["ApplicationDate"] 
                    );
                }
            }

            return applications;
        }

        public void AddApplication(Application application)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "INSERT INTO Application (UserID, JobID, Status, ApplicationDate) VALUES (@UserID, @JobID, @Status, @ApplicationDate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", application.Applicant.UserID);
                command.Parameters.AddWithValue("@JobID", application.AppliedJob.JobID);
                command.Parameters.AddWithValue("@Status", application.Status);
                command.Parameters.AddWithValue("@ApplicationDate", application.ApplicationDate);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Read
        public Application GetApplicationByID(int applicationId)
        {
            Application application = null;

            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "SELECT * FROM Application WHERE ApplicationID = @ApplicationID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ApplicationID", applicationId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    UserDAO userDAO = new UserDAO();
                    JobDAO jobDAO = new JobDAO();

                    User user = userDAO.GetUserByID((int)reader["UserID"]);
                    Job job = jobDAO.GetJobByID((int)reader["JobID"]);

                    application = new Application(
                        (int)reader["ApplicationID"],
                        user,
                        job,
                        reader["Status"].ToString(),
                        (DateTime)reader["ApplicationDate"]
                    );
                }
            }

            return application;
        }

        // Update
        public void UpdateApplication(Application application)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "UPDATE Application SET Status = @Status WHERE ApplicationID = @ApplicationID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Status", application.Status);
                command.Parameters.AddWithValue("@ApplicationID", application.ApplicationID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Delete
        public void DeleteApplication(int applicationId)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "DELETE FROM [dbo].[Application] WHERE ApplicationID = @ApplicationID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ApplicationID", applicationId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public DataTable DoDuLieuApplication()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string sql = "SELECT * FROM Application";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dataTable);

            }
            return dataTable;

        }
    }
}
