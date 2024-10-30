using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win_project_2.SQLConn;
using win_project_2.Models;
using System.Data;

namespace win_project_2.DAO
{
    public class SkillDAO
    {
        private DatabaseConnection dbConn;

        public SkillDAO()
        {
            dbConn = new DatabaseConnection();
        }

        public bool AddSkill(int userId, string name, string description, string proficiencyLevel)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_AddSkill", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số cho stored procedure
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@ProficiencyLevel", proficiencyLevel);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        // Read
        public List<Skill> GetSkillsByUserId(int userId)
        {
            List<Skill> skills = new List<Skill>();

            using (SqlConnection connection = dbConn.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_GetSkillsByUserID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", userId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Skill skill = new Skill(
                                reader.GetInt32(reader.GetOrdinal("SkillID")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader["Description"] as string,
                                reader.GetString(reader.GetOrdinal("ProficiencyLevel"))
                            );
                            skills.Add(skill);
                        }
                    }
                }
            }

            return skills;
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
