using System;
using System.Data;
using System.Data.SqlClient;

namespace win_project_2.SQLConn
{
    public class DatabaseConnection
    {

        public static string strconn = @"Data Source=LAPTOP-163UHFS2\SQLEXPRESS;Initial Catalog=APPJOB;Integrated Security=True;Encrypt=False";

        private SqlConnection con = new SqlConnection(strconn);

        // Phương thức mở kết nối
        public SqlConnection GetConnection()
        {
            return new SqlConnection(strconn);
        }
        public void myConnect()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    Console.WriteLine("Kết nối thành công.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi kết nối: " + ex.Message);
            }
        }

        // Phương thức đóng kết nối
        public void myClose()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    Console.WriteLine("Đóng kết nối thành công.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đóng kết nối: " + ex.Message);
            }
        }


        
    }
}
