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

        public UserSkill GetById(int userSkillID)
        {
            UserSkill userSkill = null;
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT * FROM UserSkills WHERE UserSkillID = @UserSkillID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserSkillID", userSkillID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userSkill = new UserSkill(
                        (int)reader["UserSkillID"],
                        (int)reader["UserID"],
                        (int)reader["SkillID"],
                        (int)reader["ProficiencyLevel"]
                    );
                }
            }
            return userSkill;
        }

        public List<UserSkill> GetAll()
        {
            List<UserSkill> userSkills = new List<UserSkill>();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT * FROM UserSkills";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserSkill userSkill = new UserSkill(
                        (int)reader["UserSkillID"],
                        (int)reader["UserID"],
                        (int)reader["SkillID"],
                        (int)reader["ProficiencyLevel"]
                    );
                    userSkills.Add(userSkill);
                }
            }
            return userSkills;
        }

        public void Add(UserSkill userSkill)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "INSERT INTO UserSkills (UserID, SkillID, ProficiencyLevel) VALUES (@UserID, @SkillID, @ProficiencyLevel)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userSkill.UserID);
                cmd.Parameters.AddWithValue("@SkillID", userSkill.SkillID);
                cmd.Parameters.AddWithValue("@ProficiencyLevel", userSkill.ProficiencyLevel);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(UserSkill userSkill)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "UPDATE UserSkills SET UserID = @UserID, SkillID = @SkillID, ProficiencyLevel = @ProficiencyLevel WHERE UserSkillID = @UserSkillID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserSkillID", userSkill.UserSkillID);
                cmd.Parameters.AddWithValue("@UserID", userSkill.UserID);
                cmd.Parameters.AddWithValue("@SkillID", userSkill.SkillID);
                cmd.Parameters.AddWithValue("@ProficiencyLevel", userSkill.ProficiencyLevel);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int userSkillID)
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "DELETE FROM UserSkills WHERE UserSkillID = @UserSkillID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserSkillID", userSkillID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
