using System;
using System.Data.SqlClient;

namespace win_project_2.SQLConn
{
    public class DatabaseConnection
    {
        private string connectionString;

        public DatabaseConnection()
        {
            connectionString = @"Data Source=.;Initial Catalog=JobApp;User ID=sa;Password=***********;Encrypt=False";
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
