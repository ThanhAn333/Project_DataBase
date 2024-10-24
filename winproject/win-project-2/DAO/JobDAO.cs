using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using win_project_2.SQLConn;
using win_project_2.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows;

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
                    jobs.Add(job);
                }
            }
            return jobs;
        }
        public void AddJob(string title, string description, string location, decimal salary, string type, string company, string status, DateTime postedDate)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "INSERT INTO Job (Title, Description, Location, Salary, Type, Company, Status, PostedDate) VALUES (@Title, @Description, @Location, @Salary, @Type, @Company, @Status, @PostedDate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Location", location);
                command.Parameters.AddWithValue("@Salary", salary);
                command.Parameters.AddWithValue("@Type", type);
                command.Parameters.AddWithValue("@Company", company);
                command.Parameters.AddWithValue("@Status", status);
                command.Parameters.AddWithValue("@PostedDate", postedDate);

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
                        reader["SkillRequire"].ToString(),
                        reader["Salary"].ToString(), 
                        reader["Type"]?.ToString(), 
                        reader["Company"]?.ToString(), 
                        (DateTime)reader["PostedDate"],
                        reader["Status"]?.ToString()
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
                string query = "UPDATE Job SET Title = @Title, Description = @Description, Location = @Location, Salary = @Salary, Type= @Type, Company = @Company, Status = @Status, PostedDate = @PostedDate WHERE JobID = @JobID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", job.Title);
                command.Parameters.AddWithValue("@Description", job.Description);
                command.Parameters.AddWithValue("@Location", job.Location);
                //command.Parameters.AddWithValue("@JobID", job.JobID);
                command.Parameters.AddWithValue("@Salary", job.Salary);
                command.Parameters.AddWithValue("@Type", job.Type);
                command.Parameters.AddWithValue("@Company", job.Company);
                command.Parameters.AddWithValue("@Status", job.Status);
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

        public DataTable TimKiemJob(string timKiem)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                DataTable dt = new DataTable();
                    string query = "SELECT * FROM Job WHERE Title LIKE '%' + @TimKiem + '%'";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TimKiem", timKiem);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    return dt;
                
            }
        }
        public DataTable HienThiLocation()
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                DataTable dt = new DataTable();
                try
                {
                    string query = "SELECT Location FROM Job WHERE Location IS NOT NULL";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                return dt;
            }
        }
        public DataTable LayDuLieuLocation(string location)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                DataTable dt = new DataTable();
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Job WHERE Location = @Location";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Location", location); 

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                return dt; 
            }
        }
       
        public DataTable DoDuLieuJob()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string sql = "SELECT * FROM Job";
                SqlCommand cmd = new SqlCommand(sql,connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dataTable);
            
            }
            return dataTable;

        }
    }
}
