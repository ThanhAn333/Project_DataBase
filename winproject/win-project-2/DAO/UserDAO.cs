using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using win_project_2.SQLConn;
using win_project_2.Models;

namespace win_project_2.DAO
{
    public class UserDAO
    {
        private DatabaseConnection dbConn;

        public UserDAO()
        {
            dbConn = new DatabaseConnection();
        }

        // Add User using stored procedure
        public void AddUser1(User user)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_AddUser1", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@Name", user.Name);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Role", user.Role);
                command.Parameters.AddWithValue("@Address", user.Address ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@DateOfBirth", user.birthDate == DateTime.MinValue ? (object)DBNull.Value : user.birthDate);
                command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ProfilePicture", user.image ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                command.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        // Get User by ID using view
        public User GetUserByID(int userId)
        {
            User user = null;

            using (SqlConnection connection = dbConn.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM vw_User WHERE UserID = @UserID", connection);
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
                        reader["Role"].ToString(),
                        reader["Address"] != DBNull.Value ? reader["Address"].ToString() : null,
                        reader["DateOfBirth"] != DBNull.Value ? (DateTime)reader["DateOfBirth"] : DateTime.MinValue,
                        reader["PhoneNumber"] != DBNull.Value ? reader["PhoneNumber"].ToString() : null,
                        reader["ProfilePicture"] != DBNull.Value ? reader["ProfilePicture"].ToString() : null,
                        reader["CreatedAt"] != DBNull.Value ? (DateTime)reader["CreatedAt"] : DateTime.MinValue,
                        reader["UpdatedAt"] != DBNull.Value ? (DateTime)reader["UpdatedAt"] : DateTime.MinValue
                    );
                }
            }

            return user;
        }

        // Update User using stored procedure
        public void UpdateUser(User user)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                SqlCommand command = new SqlCommand("UpdateUserProfile", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@UserID", user.UserID);
                command.Parameters.AddWithValue("@Name", user.Name);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Password", user.Password);
                
                command.Parameters.AddWithValue("@Address", user.Address ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@DateOfBirth", user.birthDate == DateTime.MinValue ? (object)DBNull.Value : user.birthDate);
                command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ProfilePicture", user.image ?? (object)DBNull.Value);
                

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Delete User using stored procedure
        public void DeleteUser(int userId)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_DeleteUser", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@UserID", userId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Login using stored procedure
        public (int? UserID, string Role) Login(string email, string password)
        {
            int? userId = null;
            string role = null;

            using (SqlConnection connection = dbConn.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_Login", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userId = reader.GetInt32(reader.GetOrdinal("UserID"));
                        role = reader.GetString(reader.GetOrdinal("Role"));
                    }
                }
            }

            return (userId, role);
        }

        // Register user
        public void Register(string name, string email, string password, string role, string address, DateTime dateofbirth, string phonenumber)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_RegisterUser", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Role", role);
                command.Parameters.AddWithValue("@Address", address ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@DateOfBirth", dateofbirth);
                command.Parameters.AddWithValue("@PhoneNumber", phonenumber);
                command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Load all users using view
        public DataTable LoadAllUsers()
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "SELECT * FROM vw_User";  // Use view
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable userTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(userTable);
                    return userTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        // Get max UserID using stored procedure
        public int GetMaxUserID()
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_GetMaxUserID", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy UserID lớn nhất: " + ex.Message);
                    return 0;
                }
            }
        }

        // Get account information using view
        public DataTable layThongTinTK(string taikhoan, string matkhau)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string sql = "SELECT * FROM vw_User WHERE Email = @Email AND Password = @Password";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Email", taikhoan);
                command.Parameters.AddWithValue("@Password", matkhau);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;  
            }
        }
        public DataTable GetUserList()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("GetUserList", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

    }
}
