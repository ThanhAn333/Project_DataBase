using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win_project_2.SQLConn;

namespace win_project_2.DAO
{
    public class UserSkillDAO
    {
        private DatabaseConnection dbConn;

        public UserSkillDAO()
        {
            dbConn = new DatabaseConnection();
        }

        public void AddUserSkill(UserSkill userSkill)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "INSERT INTO UserSkill (UserID, SkillID, ProficiencyLevel) VALUES (@UserID, @SkillID, @ProficiencyLevel)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userSkill.User.UserID);
                command.Parameters.AddWithValue("@SkillID", userSkill.Skill.SkillID);
                command.Parameters.AddWithValue("@ProficiencyLevel", userSkill.ProficiencyLevel);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Read
        public UserSkill GetUserSkillByID(int userSkillId)
        {
            UserSkill userSkill = null;

            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "SELECT * FROM UserSkill WHERE UserSkillID = @UserSkillID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserSkillID", userSkillId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
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
                    Skill skill = new Skill(
                       (int)reader["SkillID"],
                       reader["Name"].ToString(),
                       reader["Description"].ToString()

                   );
                    userSkill = new UserSkill(
                        (int)reader["UserSkillID"],
                        user,
                        skill,
                        reader["ProficiencyLevel"].ToString()
                    );
                }
            }

            return userSkill;
        }

        // Update
        public void UpdateUserSkill(UserSkill userSkill)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "UPDATE UserSkill SET ProficiencyLevel = @ProficiencyLevel WHERE UserSkillID = @UserSkillID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProficiencyLevel", userSkill.ProficiencyLevel);
                command.Parameters.AddWithValue("@UserSkillID", userSkill.UserSkillID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Delete
        public void DeleteUserSkill(int userSkillId)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "DELETE FROM UserSkill WHERE UserSkillID = @UserSkillID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserSkillID", userSkillId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
