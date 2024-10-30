using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_project_2.DAO;

namespace win_project_2.Forms.Candidate.UC
{
    public partial class FormDetailJob : Form
    {
        private int jobID;
        private int applicationID;
        public FormDetailJob()
        {
            InitializeComponent();
        }

        public void themThongTin(int applicationid, int jobid, string jobname, string description, string skillRequire, string location, string salary, string company, string type, string date)
        {
            applicationID = applicationid;
            jobID = jobid;
            lbtitle.Text = jobname;
            lbdescription.Text = description;
            lbSkillRRequire.Text = skillRequire;
            lblocation.Text = location;
            lbsalary.Text = salary;
            lbcompany.Text = company;
            lbtype.Text = type;
            lbDate.Text = date;


        }
        public int getApplicationID() { return applicationID; }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa đơn ứng tuyển này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ApplicationDAO applicationDAO = new ApplicationDAO();
               
                    applicationDAO.DeleteApplication(getApplicationID());
                    MessageBox.Show("Đơn ứng tuyển đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    FormDetailJob_Load(sender, e);

            }
        }

        private void FormDetailJob_Load(object sender, EventArgs e)
        {
            FormDetailJob jobDetail = new FormDetailJob();
            jobDetail.Refresh();
        }
    }
}
