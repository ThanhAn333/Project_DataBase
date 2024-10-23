using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace win_project_2.Forms
{
    public partial class FDetail1 : Form
    {
        
        public FDetail1()
        {
            InitializeComponent();

        }

        public void themThongTin(string jobname, string description, string request,string location, string salary, string company, string type, string date)
        {
            lb_jobname.Text = jobname;
            lbDescrip.Text = description;
            lbRequest.Text = request;
            lbLocation.Text = location;
            lbSalary.Text = salary;
            lbCompany.Text = company;
            lbType.Text = type;
            lbdate.Text = date;

           
        }
        private void FDetail1_Load(object sender, EventArgs e)
        {

        }

        private void Nopdon_Click(object sender, EventArgs e)
        {

        }
    }
}
