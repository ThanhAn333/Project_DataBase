using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_project_2.Forms.Recruiter.UC
{
    public partial class UC_Job : UserControl
    {
        public UC_Job()
        {
            InitializeComponent();
        }
        public void thongtin(string namejob, string salary, string location, string company)
        {
            lblNameJob.Text = namejob;
            lblSalary.Text = salary;
            lblLocation.Text = location;
            lblCompany.Text = company;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            UC_ListApply_Job uC_ListApp_Job = new UC_ListApply_Job();
            uC_ListApp_Job.Show();

        }
        public void SetData(DataRow row)
        {
            lblNameJob.Text = row["JobName"].ToString();    // Tên cột trong DataTable
            lblSalary.Text = row["Salary"].ToString();
            lblLocation.Text = row["Location"].ToString();
            lblCompany.Text = row["Company"].ToString();
        }

    }
}
