using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_project_2.DataClass;
using win_project_2.UserControls;

namespace win_project_2.Forms
{
    public partial class FListWaitJob : Form
    {
        public string status = "";
        public string id_job = "";
        public FListWaitJob()
        {
            InitializeComponent();
            LoadData();
        }

        public async void LoadData()
        {
            this.flowLayoutPanel1.Controls.Clear();
            var dt = new DB();
            List<string> listWaitJob = await dt.GetAllWaitJob();
            if (listWaitJob == null)
            {
                return;
            }
            foreach (string str in listWaitJob)
            {
                Console.WriteLine(str);
                UCWaitJob new_uc = new UCWaitJob(str);
                new_uc.ParentFListWaitJob = this;
                flowLayoutPanel1.Controls.Add(new_uc);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
