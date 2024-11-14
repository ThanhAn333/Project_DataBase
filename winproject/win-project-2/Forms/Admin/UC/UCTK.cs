using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using win_project_2.DAO;

namespace win_project_2.Forms.Admin.UC
{
    public partial class UCTK : UserControl
    {
        public UCTK()
        {
            InitializeComponent();
        }
        UserDAO userDAO = new UserDAO();
        private void LoadUserChart()
        {
            userchart.Series.Clear();
            Series series = userchart.Series.Add("Số tài khoản");
            series.ChartType = SeriesChartType.Column;

            // Lấy dữ liệu từ UserDAO
            DataTable dataTable = userDAO.GetUserCountMonth();

            // Kiểm tra nếu có dữ liệu
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    string monthYear = row["MonthYear"].ToString();
                    int userCount = Convert.ToInt32(row["UserCount"]);

                    // Thêm dữ liệu vào biểu đồ
                    series.Points.AddXY(monthYear, userCount);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.");
            }

            // Tùy chỉnh biểu đồ (tùy chọn)
            userchart.ChartAreas[0].AxisX.Title = "Tháng";
            userchart.ChartAreas[0].AxisY.Title = "Số tài khoản";
            userchart.ChartAreas[0].AxisX.Interval = 1;
        }

        private void UCTK_Load(object sender, EventArgs e)
        {
            LoadUserChart();
        }
    }
}
