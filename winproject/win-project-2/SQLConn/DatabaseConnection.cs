using System;
using System.Data;
using System.Data.SqlClient;

namespace win_project_2.SQLConn
{
    public class DatabaseConnection
    {
        public static string strconn = @"Data Source=LAPTOP-PMSG8QVF;Initial Catalog=APPJOB;Integrated Security=True;Encrypt=False";



        private SqlConnection con = new SqlConnection(strconn);


        public SqlConnection GetConnection()
        {
            return new SqlConnection(strconn);
        }

        // Phương thức mở kết nối
        public void myConnect(SqlConnection con)
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
        public void myClose(SqlConnection con)
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

        // Phương thức thực thi stored procedure
        public void ExecuteProcedure(string procedureName, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = GetConnection())
            {
                myConnect(con);

                using (SqlCommand cmd = new SqlCommand(procedureName, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số nếu có
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Stored Procedure thực thi thành công.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi khi thực thi Stored Procedure: " + ex.Message);
                    }
                    finally
                    {
                        myClose(con);
                    }
                }
            }
        }

        // Phương thức thực thi truy vấn lấy dữ liệu (cho View)
        public DataTable ExecuteView(string query)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = GetConnection())
            {
                myConnect(con);

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        Console.WriteLine("Dữ liệu từ view được lấy thành công.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi khi lấy dữ liệu từ View: " + ex.Message);
                    }
                    finally
                    {
                        myClose(con);
                    }
                }
            }

            return dt;
        }

        // Phương thức thực thi truy vấn (cho trigger và các hoạt động khác)
        public void ExecuteQuery(string query)
        {
            using (SqlConnection con = GetConnection())
            {
                myConnect(con);

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Truy vấn thực thi thành công.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi khi thực thi truy vấn: " + ex.Message);
                    }
                    finally
                    {
                        myClose(con);
                    }
                }
            }
        }
    }
}
