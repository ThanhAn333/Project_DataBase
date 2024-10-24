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
    public class SkillDAO
    {
        private DatabaseConnection dbConn;

        public SkillDAO()
        {
            dbConn = new DatabaseConnection();
        }

        public void AddSkill(Skill skill)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "INSERT INTO Skill (Name, Description) VALUES (@Name, @Description)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", skill.Name);
                command.Parameters.AddWithValue("@Description", skill.Description);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Read
        public Skill GetSkillByID(int skillId)
        {
            Skill skill = null;

            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "SELECT * FROM Skill WHERE SkillID = @SkillID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SkillID", skillId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

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

        // Update
        public void UpdateSkill(Skill skill)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "UPDATE Skill SET Name = @Name, Description = @Description WHERE SkillID = @SkillID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", skill.Name);
                command.Parameters.AddWithValue("@Description", skill.Description);
                command.Parameters.AddWithValue("@SkillID", skill.SkillID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Delete
        public void DeleteSkill(int skillId)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "DELETE FROM Skill WHERE SkillID = @SkillID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SkillID", skillId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
