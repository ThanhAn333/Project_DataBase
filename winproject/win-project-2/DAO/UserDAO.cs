using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win_project_2.Forms;
using win_project_2.SQLConn;

namespace win_project_2.DAO
{
    public class UserDAO
    {
        private DatabaseConnection dbConn;

        public UserDAO()
        {
            dbConn = new DatabaseConnection();
        }

        public void AddUser(User user)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "INSERT INTO Users (Name, Email, Password, Role) VALUES (@Name, @Email, @Password, @Role)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", user.Name);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Role", user.Role);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Read
        public User GetUserByID(int userId)
        {
            User user = null;

            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "SELECT * FROM Users WHERE UserID = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    user = new User(
                        (int)reader["UserID"],
                        reader["Name"].ToString(),
                        reader["Email"].ToString(),
                        reader["Password"].ToString(),
                        reader["Role"].ToString()
                    );
                }
            }

            return user;
        }

        // Update
        public void UpdateUser(User user)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "UPDATE Users SET Name = @Name, Email = @Email, Password = @Password, Role = @Role WHERE UserID = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", user.Name);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Role", user.Role);
                command.Parameters.AddWithValue("@UserID", user.UserID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Delete
        public void DeleteUser(int userId)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "DELETE FROM Users WHERE UserID = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        //login
        public void Login(String email, String password)
        {
            string sql = "select Role from User  where Email= @Email and Password= @Password";
            SqlCommand command = new SqlCommand(sql, dbConn.GetConnection());
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", password);
            object result = command.ExecuteScalar();
            if (result != null)
            {

                string PhanQuyen = result.ToString();
                if (PhanQuyen == "Employer")
                {
                    FHome fHome = new FHome();
                    fHome.ShowDialog();


                }
                else if (PhanQuyen == "Recuiter")
                {
                   
                }
            }
        }

        public void Register(String name, String email, String password)
        {
            string sql = "insert into Users (Name, Email, Password) Values (@Name, @Email, @Password)";
            SqlCommand command = new SqlCommand(sql, dbConn.GetConnection());
            command.Parameters.AddWithValue("@Name", email);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", password);
            
        }
        


    }
}
