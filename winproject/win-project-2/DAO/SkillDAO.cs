using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win_project_2.SQLConn;

namespace win_project_2.DAO
{
    public class SkillDAO
    {
        private DatabaseConnection dbConn;

        public SkillDAO()
        {
            dbConn = new DatabaseConnection();
        }

        public Skill GetById(int skillID)
        {
            Skill skill = null;
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT * FROM Skills WHERE SkillID = @SkillID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SkillID", skillID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    skill = new Skill(
                        (int)reader["SkillID"],
                        reader["Name"].ToString(),
                        reader["Description"].ToString()
                    );
                }
            }
            return skill;
        }

        public List<Skill> GetAll()
        {
            List<Skill> skills = new List<Skill>();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT * FROM Skills";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Skill skill = new Skill(
                        (int)reader["SkillID"],
                        reader["Name"].ToString(),
                        reader["Description"].ToString()
                    );
                    skills.Add(skill);
                }
            }
            return skills;
        }

        public void Add(Skill skill)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "INSERT INTO Skills (Name, Description) VALUES (@Name, @Description)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", skill.Name);
                cmd.Parameters.AddWithValue("@Description", skill.Description);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Skill skill)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "UPDATE Skills SET Name = @Name, Description = @Description WHERE SkillID = @SkillID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SkillID", skill.SkillID);
                cmd.Parameters.AddWithValue("@Name", skill.Name);
                cmd.Parameters.AddWithValue("@Description", skill.Description);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int skillID)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "DELETE FROM Skills WHERE SkillID = @SkillID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SkillID", skillID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
