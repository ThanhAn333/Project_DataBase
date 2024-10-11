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

        public Job GetById(int jobID)
        {
            Job job = null;
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT * FROM Jobs WHERE JobID = @JobID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobID", jobID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    job = new Job(
                        (int)reader["JobID"],
                        reader["Title"].ToString(),
                        reader["Description"].ToString(),
                        reader["Location"].ToString(),
                        (DateTime)reader["PostedDate"],
                        reader["Status"].ToString()
                    );
                }
            }
            return job;
        }

        public List<Job> GetAll()
        {
            List<Job> jobs = new List<Job>();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT * FROM Jobs";
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
                        (DateTime)reader["PostedDate"],
                        reader["Status"].ToString()
                    );
                    jobs.Add(job);
                }
            }
            return jobs;
        }

        public void Add(Job job)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "INSERT INTO Jobs (Title, Description, Location, PostedDate, Status) VALUES (@Title, @Description, @Location, @PostedDate, @Status)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", job.Title);
                cmd.Parameters.AddWithValue("@Description", job.Description);
                cmd.Parameters.AddWithValue("@Location", job.Location);
                cmd.Parameters.AddWithValue("@PostedDate", job.PostedDate);
                cmd.Parameters.AddWithValue("@Status", job.Status);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Job job)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "UPDATE Jobs SET Title = @Title, Description = @Description, Location = @Location, PostedDate = @PostedDate, Status = @Status WHERE JobID = @JobID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobID", job.JobID);
                cmd.Parameters.AddWithValue("@Title", job.Title);
                cmd.Parameters.AddWithValue("@Description", job.Description);
                cmd.Parameters.AddWithValue("@Location", job.Location);
                cmd.Parameters.AddWithValue("@PostedDate", job.PostedDate);
                cmd.Parameters.AddWithValue("@Status", job.Status);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int jobID)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "DELETE FROM Jobs WHERE JobID = @JobID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobID", jobID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
