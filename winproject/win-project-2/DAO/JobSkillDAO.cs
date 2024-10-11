using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win_project_2.SQLConn;

namespace win_project_2.DAO
{
    public class JobSkillDAO
    {
        private DatabaseConnection dbConn;

        public JobSkillDAO()
        {
            dbConn = new DatabaseConnection();
        }

        public JobSkill GetById(int jobSkillID)
        {
            JobSkill jobSkill = null;
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT * FROM JobSkills WHERE JobSkillID = @JobSkillID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobSkillID", jobSkillID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    jobSkill = new JobSkill(
                        (int)reader["JobSkillID"],
                        (int)reader["JobID"],
                        (int)reader["SkillID"]
                    );
                }
            }
            return jobSkill;
        }

        public List<JobSkill> GetAll()
        {
            List<JobSkill> jobSkills = new List<JobSkill>();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT * FROM JobSkills";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    JobSkill jobSkill = new JobSkill(
                        (int)reader["JobSkillID"],
                        (int)reader["JobID"],
                        (int)reader["SkillID"]
                    );
                    jobSkills.Add(jobSkill);
                }
            }
            return jobSkills;
        }

        public void Add(JobSkill jobSkill)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "INSERT INTO JobSkills (JobID, SkillID) VALUES (@JobID, @SkillID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobID", jobSkill.JobID);
                cmd.Parameters.AddWithValue("@SkillID", jobSkill.SkillID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(JobSkill jobSkill)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "UPDATE JobSkills SET JobID = @JobID, SkillID = @SkillID WHERE JobSkillID = @JobSkillID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobSkillID", jobSkill.JobSkillID);
                cmd.Parameters.AddWithValue("@JobID", jobSkill.JobID);
                cmd.Parameters.AddWithValue("@SkillID", jobSkill.SkillID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int jobSkillID)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "DELETE FROM JobSkills WHERE JobSkillID = @JobSkillID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobSkillID", jobSkillID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
