using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_project_2.Forms;

namespace win_project_2.UserControls
{
    public partial class UCShowJobcs : UserControl
    {
        
        public UCShowJobcs()
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
        private void Detail_Click(object sender, EventArgs e)
        {

        }
    }
}
