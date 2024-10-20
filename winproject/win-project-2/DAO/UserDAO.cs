﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                string query = "INSERT INTO User (Name, Email, Password, Role, Address, DateOfBirth, PhoneNumber, ProfilePicture, CreatedAt, UpdatedAt) " +
                               "VALUES (@Name, @Email, @Password, @Role, @Address, @DateOfBirth, @PhoneNumber, @ProfilePicture, @CreatedAt, @UpdatedAt)";
                SqlCommand command = new SqlCommand(query, connection);
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

        // Read
        public User GetUserByID(int userId)
        {
            User user = null;

            using (SqlConnection connection = dbConn.GetConnection())
            {
                string query = "SELECT * FROM [User] WHERE UserID = @UserID";
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
                        reader["Role"].ToString(),
                        reader["Address"]?.ToString(),
                        reader["DateOfBirth"] != DBNull.Value ? (DateTime)reader["DateOfBirth"] : DateTime.MinValue,
                        reader["PhoneNumber"]?.ToString(),
                        reader["ProfilePicture"]?.ToString(),
                        DateTime.Now, // or assign a value from the database if available
                        DateTime.Now  // or assign a value from the database if available
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
                string query = "UPDATE [User] SET Name = @Name, Email = @Email, Password = @Password, Role = @Role, " +
                               "Address = @Address, DateOfBirth = @DateOfBirth, PhoneNumber = @PhoneNumber, ProfilePicture = @ProfilePicture, " +
                               "UpdatedAt = @UpdatedAt WHERE UserID = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", user.Name);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Role", user.Role);
                command.Parameters.AddWithValue("@Address", user.Address ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@DateOfBirth", user.birthDate == DateTime.MinValue ? (object)DBNull.Value : user.birthDate);
                command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ProfilePicture", user.image ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
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
                string query = "DELETE FROM [User] WHERE UserID = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Login
        public string Login(string email, string password)
        {
            string role = null;

            using (SqlConnection connection = dbConn.GetConnection())
            {
                string sql = "SELECT Role FROM [User] WHERE Email = @Email AND Password = @Password";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    role = result.ToString();
                }
            }

            return role;
        }

        public void Register(string name, string email, string password, string role, string address, DateTime dateofbirth, string phonenumber, DateTime createdat)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                
                string sql = "INSERT INTO [User] (Name, Email, Password, Role, Address, DateOfBirth, PhoneNumber, CreatedAt) " +
                             "VALUES (@Name, @Email, @Password, @Role, @Address, @DateOfBirth, @PhoneNumber, @CreatedAt)";

                SqlCommand command = new SqlCommand(sql, connection);

                
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Role", role);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@DateOfBirth", dateofbirth);
                command.Parameters.AddWithValue("@PhoneNumber", phonenumber);
                command.Parameters.AddWithValue("@CreatedAt", createdat);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
