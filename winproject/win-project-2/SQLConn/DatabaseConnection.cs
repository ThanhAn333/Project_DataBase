using System;
using System.Data.SqlClient;

namespace win_project_2.SQLConn
{
    public class DatabaseConnection
    {
        private string connectionString;

        public DatabaseConnection()
        {
            connectionString = @"Data Source=LAPTOP-PMSG8QVF;Initial Catalog=JobApplicationDB;Integrated Security=True";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    Console.WriteLine("Kết nối thành công!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kết nối thất bại: " + ex.Message);
                return false;
            }
        }
    }
}
