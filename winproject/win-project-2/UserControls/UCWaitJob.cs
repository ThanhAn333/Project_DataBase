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

            string[] parts = status.Split('-');
            _idjob = parts[1];

            var dt = new DB();
            Post post = await dt.GetInfoPost(parts[1]);
            _idntt = post.SenderId;

            if (parts[0] == "WAIT" )
            {
                btn_complete.Enabled = false;
                lb_status.Text = "Trạng thái: ĐANG CHỜ";
            }
            else if (parts[0] == "ACCEPT")
            {
                btn_complete.Enabled = true;
                lb_status.Text = "Trạng thái: ĐÃ NHẬN VIỆC";
            }

            lb_jobname.Text = post.Tag;
        }


        private async void btn_complete_Click(object sender, EventArgs e)
        {
            var dt = new DB();
            await dt.CompleteJob(_idjob, GlobalVariables.id, _idntt);
            this.ParentFListWaitJob.LoadData();
        }

        
    }
}
