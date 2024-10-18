using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win_project_2.SQLConn;

namespace win_project_2.DAO
{
    public class JobDAO
    {
        private DatabaseConnection dbConn;

        public JobDAO()
        {
            dbConn = new DatabaseConnection();
        }

        public List<Job> GetAll()
        {
            List<Job> jobs = new List<Job>();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT * FROM Job";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Job job = new Job(
                        (int)reader["JobID"],
                        reader["Title"].ToString(),
                        reader["Description"].ToString(),
                        reader["Location"].ToString(),
                        reader["Status"].ToString(),
                        (DateTime)reader["PostedDate"]
                    );
                    jobs.Add(job);
                }
            }
            return jobs;
        }
        public void AddJob(Job job)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "INSERT INTO Job (Title, Description, Location, Status, PostedDate) VALUES (@Title, @Description, @Location, @Status, @PostedDate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", job.Title);
                command.Parameters.AddWithValue("@Description", job.Description);
                command.Parameters.AddWithValue("@Location", job.Location);
                command.Parameters.AddWithValue("@Status", job.Status);
                command.Parameters.AddWithValue("@PostedDate", job.PostedDate);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Read
        public Job GetJobByID(int jobId)
        {
            Job job = null;

            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "SELECT * FROM Job WHERE JobID = @JobID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@JobID", jobId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    job = new Job(
                        (int)reader["JobID"],
                        reader["Title"].ToString(),
                        reader["Description"].ToString(),
                        reader["Location"].ToString(),
                        reader["Status"].ToString(),
                        (DateTime)reader["PostedDate"]
                    );
                }
            }

            return job;
        }

        // Update
        public void UpdateJob(Job job)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "UPDATE Job SET Title = @Title, Description = @Description, Location = @Location, Status = @Status, Application = @Application WHERE JobID = @JobID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", job.Title);
                command.Parameters.AddWithValue("@Description", job.Description);
                command.Parameters.AddWithValue("@Location", job.Location);
                command.Parameters.AddWithValue("@Status", job.Status);
                command.Parameters.AddWithValue("@JobID", job.JobID);
                command.Parameters.AddWithValue("@PostedDate", job.PostedDate);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Delete
        public void DeleteJob(int jobId)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "DELETE FROM Job WHERE JobID = @JobID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@JobID", jobId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
