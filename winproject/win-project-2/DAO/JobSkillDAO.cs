using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win_project_2.SQLConn;
using win_project_2.Models;

namespace win_project_2.DAO
{
    public class JobSkillDAO
    {
        private DatabaseConnection dbConn;

        public JobSkillDAO()
        {
            dbConn = new DatabaseConnection();
        }

        // Create
        public void AddJobSkill(JobSkill jobSkill)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "INSERT INTO JobSkill (JobID, SkillID) VALUES (@JobID, @SkillID)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@JobID", jobSkill.Job.JobID);
                command.Parameters.AddWithValue("@SkillID", jobSkill.Skill.SkillID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Read
        public JobSkill GetJobSkillByID(int jobSkillId)
        {
            JobSkill jobSkill = null;

            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "SELECT * FROM JobSkill WHERE JobSkillID = @JobSkillID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@JobSkillID", jobSkillId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Job job = new Job(
                        (int)reader["JobID"],
                        reader["Title"].ToString(),
                        reader["Description"].ToString(),
                        reader["Location"].ToString(),
                        reader["SkillRequire"].ToString(),
                        reader["Salary"].ToString(),
                        reader["Type"]?.ToString(),
                        reader["Company"]?.ToString(),
                        (DateTime)reader["PostedDate"],
                        reader["Status"]?.ToString(),
                        (int)reader["Employer"]
                   );
                   Skill    skill = new Skill(
                       (int)reader["SkillID"],
                       reader["Name"].ToString(),
                       reader["Description"].ToString()

                   );
                    jobSkill = new JobSkill(
                        (int)reader["JobSkillID"],
                        job,
                        skill

                    );
                }
            }

            return jobSkill;
        }

        // Update
        public void UpdateJobSkill(JobSkill jobSkill)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "UPDATE JobSkill SET JobID = @JobID, SkillID = @SkillID WHERE JobSkillID = @JobSkillID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@JobID", jobSkill.Job.JobID);
                command.Parameters.AddWithValue("@SkillID", jobSkill.Skill.SkillID);
                command.Parameters.AddWithValue("@JobSkillID", jobSkill.JobSkillID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Delete
        public void DeleteJobSkill(int jobSkillId)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "DELETE FROM JobSkill WHERE JobSkillID = @JobSkillID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@JobSkillID", jobSkillId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
