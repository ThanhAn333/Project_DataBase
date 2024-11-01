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
    public partial class UCCandidate : UserControl
    {
        public UCCandidate()
        {
            InitializeComponent();
        }
        public void themThongTin(string name, string email, string date)
        {
            lblname.Text = name;
            lblemail.Text = email;
            lbldate.Text = date;
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
