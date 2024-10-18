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
    public partial class UCWaitJob : UserControl
    {
        public FListWaitJob ParentFListWaitJob { get; set; }
        public string _idjob = "";
        public string _idntt = "";
        
        public UCWaitJob(string status)
        {
            InitializeComponent();
            LoadData(status);
        }

        public async Task LoadData(string status)
        {

            
        }


        private async void btn_complete_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
