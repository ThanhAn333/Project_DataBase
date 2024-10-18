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
                        reader["Role"]?.ToString(), // Sử dụng toán tử null-conditional để tránh lỗi null
                        reader["Address"]?.ToString(), // Giả sử bạn đã thêm Address trong User
                        (DateTime)reader["DateOfBirth"], // Ngày sinh
                        reader["PhoneNumber"]?.ToString(), // Số điện thoại
                        reader["ProfilePicture"]?.ToString(), // Hình đại diện
                        (DateTime)reader["CreatedAt"], // Ngày tạo
                        (DateTime)reader["UpdatedAt"]  // Ngày cập nhật
                    );

                    // Tạo đối tượng Job từ dữ liệu đọc được
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

                    // Tạo đối tượng Application từ dữ liệu đọc được
                    Application application = new Application(
                        (int)reader["ApplicationID"],
                        user, // Đối tượng User đã tạo
                        job, // Đối tượng Job đã tạo
                        reader["Status"].ToString(), // Trạng thái ứng tuyển
                        (DateTime)reader["ApplicationDate"] // Ngày ứng tuyển
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
                command.Parameters.AddWithValue("@Status", application.ApplicationDate);

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
    }
}
