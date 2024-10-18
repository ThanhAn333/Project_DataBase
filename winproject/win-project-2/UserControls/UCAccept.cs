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
    public partial class UCAccept : UserControl
    {
        public FListNTapply ParentFListNTapply { get; set; }
        
        public UCAccept(string idjob, string status)
        {
            InitializeComponent();
            
        }

        public async void LoadData(string status)
        {
            
            
        }


        private async void btn_accept_Click(object sender, EventArgs e)
        {

        }

        private async void btn_info_Click(object sender, EventArgs e)
        {

        }

        private void UCAccept_Load(object sender, EventArgs e)
        {

        }

        private async void btn_accept_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_infor_Click(object sender, EventArgs e)
        {
            
        }
    }
}
