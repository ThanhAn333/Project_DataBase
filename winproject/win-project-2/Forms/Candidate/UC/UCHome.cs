using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_project_2.DAO;
using win_project_2.Forms.Recruiter.UC;
using win_project_2.Forms.UCComponents;
using win_project_2.Models;
using win_project_2.UserControls;

namespace win_project_2.Forms.UC
{
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }
        JobDAO jobDao = new JobDAO();
        private DataTable searchResults;

        private void FilterResults(string selectedLocation)
        {
            if (searchResults != null)
            {
                DataView view = new DataView(searchResults);
                if (selectedLocation == "Tất cả" || string.IsNullOrEmpty(selectedLocation))
                {
                    addJob(searchResults); 
                }
                else
                {
                    view.RowFilter = $"Location = '{selectedLocation}'";
                    if (view.Count > 0)
                    {
                        addJob(view.ToTable());
                    }
                    else
                    {
                        fpanelJob.Controls.Clear();
                        MessageBox.Show("Không tìm thấy kết quả phù hợp cho vị trí đã chọn.");
                    }
                }
            }
        }
        public void addJob(DataTable dt)
        {
            fpanelJob.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                UCShowJobcs uCShowJobcs = new UCShowJobcs();
                int id = (int)row["JobID"];
                string jobname = row["Title"].ToString();
                string company = row["Company"].ToString();
                string salary = row["Salary"].ToString();
                string location = row["Location"].ToString();
                string date = row["PostedDate"].ToString();
                uCShowJobcs.thongtin(id, jobname, salary, location, company, date);
                fpanelJob.Controls.Add(uCShowJobcs);
            }
        }
        public void load()
        {
            fpanelJob.Controls.Clear();
            DataTable dt = jobDao.DoDuLieuJob();
            addJob(dt);

        }
        private void UCHome_Load(object sender, EventArgs e)
        {
            load();
            DataTable dt = jobDao.HienThiLocation();

            cblocation.Items.Clear();
            cblocation.Items.Add("Tất cả"); 
            foreach (DataRow dr in dt.Rows)
            {
                string location = dr["Location"].ToString();
                cblocation.Items.Add(location);
            }
            cblocation.SelectedIndex = 0; 

        }

        public static int indexcbo = 4;
        private void cblocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fpanelJob != null)
            {
                fpanelJob.Controls.Clear();
            }

            if (cblocation.SelectedIndex == 0)
            {
                load(); 
            }
            else
            {
                string location = cblocation.SelectedItem.ToString();
                DataTable dt = jobDao.LayDuLieuLocation(location);
                addJob(dt);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text;
            string selectedLocation = cblocation.SelectedItem?.ToString() ?? string.Empty;

            // Tìm kiếm tất cả nếu không có từ khóa và vị trí
            if (string.IsNullOrEmpty(timKiem) && (selectedLocation == "Tất cả" || string.IsNullOrEmpty(selectedLocation)))
            {
                load();
            }
            else
            {
                // Tìm kiếm công việc
                searchResults = jobDao.TimKiemJob(timKiem); // Lưu trữ kết quả tìm kiếm
                FilterResults(selectedLocation); // Lọc kết quả theo vị trí đã chọn
            }
        }
    }
}
