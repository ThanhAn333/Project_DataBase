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
    public partial class UCWriteRV : UserControl
    {
        public FListNTapply ParentFListNTapply { get; set; }
        public string _idnt = "";
        public UCWriteRV(string status)
        {
            InitializeComponent();
            LoadData(status);
            _idnt = status;
        }

        public async void LoadData(string status)
        {
            var dt = new DB();
            NguoiTho nguoiTho = await dt.GetInfoNguoiTho(status);
            lb_name.Text = nguoiTho.Name + "   ĐÃ HOÀN THÀNH CÔNG VIỆC";
        }

        private void btn_rv_Click(object sender, EventArgs e)
        {
            FRating f = new FRating(_idnt);
            f.Show();
        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {

        }
    }
}
