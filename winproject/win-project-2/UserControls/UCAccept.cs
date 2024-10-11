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
    public partial class UCAccept : UserControl
    {
        public FListNTapply ParentFListNTapply { get; set; }
        public string _idjob = "";
        public string _idnt = "";
        public string _idntt = GlobalVariables.id;
        public UCAccept(string idjob, string status)
        {
            InitializeComponent();
            _idjob = idjob;
            LoadData(status);
        }

        public async void LoadData(string status)
        {
            _idnt = status;
            var dt = new DB();
            NguoiTho nguoiTho = await dt.GetInfoNguoiTho(_idnt);
            lb_name.Text = nguoiTho.Name;
            
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
            var dt = new DB();
            await dt.AcceptWorker(_idjob, _idnt, _idntt);
        }

        private void btn_infor_Click(object sender, EventArgs e)
        {
            ThoDetail f = new ThoDetail(_idnt);
            f.ShowDialog();
        }
    }
}
