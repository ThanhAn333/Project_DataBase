using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win_project_2.SQLConn;
using win_project_2.Models;
using System.Windows.Forms;
using System.Security.Cryptography;
using Firebase.Auth;

namespace win_project_2.DAO
{
    public class ApplicationDAO
    {
        private DatabaseConnection dbConn;

        public ApplicationDAO()
        {
            dbConn = new DatabaseConnection();
        }

        public void AddApplication(Applications application)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_AddApplication", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", application.Applicant.UserID);
                command.Parameters.AddWithValue("@JobID", application.AppliedJob.JobID);
                command.Parameters.AddWithValue("@Title", application.AppliedJob.Title);
                command.Parameters.AddWithValue("@Status", application.Status);
                command.Parameters.AddWithValue("@ApplicationDate", application.ApplicationDate);

                    connection.Open();
                    command.ExecuteNonQuery();
               
            }
        }

        public int? GetApplicationID(int jobId, int userId)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_GetApplicationID", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@JobID", jobId);
                command.Parameters.AddWithValue("@UserID", userId);

                // Thêm tham số đầu ra để nhận ApplicationID
                SqlParameter outputParam = new SqlParameter("@ApplicationID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputParam);

                connection.Open();

                try
                {
                    // Thực thi lệnh
                    command.ExecuteNonQuery();

                    // Kiểm tra giá trị của outputParam, nếu không phải DBNull thì trả về ApplicationID
                    if (outputParam.Value != DBNull.Value)
                    {
                        return (int)outputParam.Value;
                    }
                    else
                    {
                        // Trường hợp không tìm thấy ApplicationID
                    
                        return null;
                    }
                }
                catch (SqlException ex)
                {
                    // Xử lý ngoại lệ SQL nếu có lỗi
                    
                    return null;
                }
            }
        }


        public void UpdateApplication(int applicationId, string newstatus)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_UpdateApplicationStatus", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ApplicationID", applicationId);
                command.Parameters.AddWithValue("@NewStatus", newstatus);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        // Delete
        public void DeleteApplication(int applicationId)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_DeleteApplication", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ApplicationID", applicationId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public bool CheckApplicationExists(int userId, int jobId)
        {
            using (SqlConnection connection = dbConn.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_CheckApplicationExists", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", userId);
                command.Parameters.AddWithValue("@JobID", jobId);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        public DataTable DoDuLieuApplication(int userid)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = dbConn.GetConnection())
            {
                // Mở kết nối
                connection.Open();

                // Đặt câu lệnh SQL
                string sql = "SELECT * FROM vw_AllApplications WHERE UserID = @UserID";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    // Thêm tham số vào câu lệnh SQL
                    cmd.Parameters.Add(new SqlParameter("@UserID", userid));

                    // Tạo SqlDataAdapter và điền dữ liệu vào DataTable
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                }
            }
            return dataTable;
        }
        public string GetApplicationStatus(int applicationid)
        {
            string status = string.Empty;
            using (SqlConnection connection = dbConn.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_GetApplicationStatus", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ApplicationID", applicationid);

                    connection.Open(); 
                    status = command.ExecuteScalar()?.ToString();
                }
            }
            return status;

        }
        public DataTable DoDuLieuCandidateApplication(int jobid)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = dbConn.GetConnection())
            {
                string sql = "SELECT * FROM vw_CandidateApplicationsByJob WHERE JobID = @JobID";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@JobID", jobid);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public bool checkAgeApplication(int userid)
        {
            bool isEligible = false;

            using (SqlConnection connection = dbConn.GetConnection())
            {
                connection.Open(); // Mở kết nối

                // Sử dụng cú pháp gọi hàm đúng với một SELECT
                SqlCommand command = new SqlCommand("SELECT dbo.fn_CheckAgeCandidate(@UserID)", connection);
                command.Parameters.Add(new SqlParameter("@UserID", userid));

                // Thực hiện câu lệnh và lấy kết quả
                var result = command.ExecuteScalar();

                if (result != null && result is bool)
                {
                    isEligible = (bool)result; // Kiểm tra nếu giá trị trả về là true
                }
            }

            return isEligible;
        }
    }
}
