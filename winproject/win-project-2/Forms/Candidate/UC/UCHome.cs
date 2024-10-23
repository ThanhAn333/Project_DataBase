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
        public void load()
        {
            fpanelJob.Controls.Clear();

            DataTable dt = jobDao.DoDuLieuJob();
            foreach (DataRow row in dt.Rows)
            {
                UCShowJobcs uCJob = new UCShowJobcs();
                int id = (int)row["JobID"];
                string jobname = row["Title"].ToString();
                string company = row["Company"].ToString();
                string salary = row["Salary"].ToString();
                string location = row["Location"].ToString();
                string date = row["PostedDate"].ToString();
                uCJob.thongtin(id,jobname,salary, location, company,date);
                fpanelJob.Controls.Add(uCJob);
                uCJob.BringToFront();


            }


        }
        private void UCHome_Load(object sender, EventArgs e)
        {
            load();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
