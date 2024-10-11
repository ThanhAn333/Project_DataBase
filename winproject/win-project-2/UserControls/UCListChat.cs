using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_project_2.DataClass;
using win_project_2.Forms;

namespace win_project_2.UserControls
{
    public partial class UCListChat : UserControl
    {
        public FListChat ParentFListChat { get; set; }
        public string ID = "";
        public UCListChat(string id)
        {
            InitializeComponent();
            LoadData(id);
        }

        public async void LoadData(string id)
        {
            var dt = new DB();
            NguoiTho nguoitho = await dt.GetInfoNguoiTho(id);
            if(nguoitho == null)
            {
                NguoiTimTho nguoitimtho = await dt.GetInfoNguoiTimTho(id);
                lb_name.Text = nguoitimtho.Name;
                ID = id;
                if (nguoitimtho.AvatarUrl != "")
                {
                    GlobalVariables.url_avt_other_user = nguoitimtho.AvatarUrl;
                    guna2CirclePictureBox1.Image = Image.FromStream(new MemoryStream(new WebClient().DownloadData(nguoitimtho.AvatarUrl)));
                }
            }
            else
            {
                lb_name.Text = nguoitho.Name;
                ID = id;
                if (nguoitho.AvatarUrl != "")
                {
                    GlobalVariables.url_avt_other_user = nguoitho.AvatarUrl;
                    guna2CirclePictureBox1.Image = Image.FromStream(new MemoryStream(new WebClient().DownloadData(nguoitho.AvatarUrl)));
                }
            }

        }

        private void lb_name_Click(object sender, EventArgs e)
        {

        }

        private void btn_chat_Click(object sender, EventArgs e)
        {
            GlobalVariables.other_user = lb_name.Text;
            this.ParentFListChat.DisplayInPanel(ID);
        }

        private void UCListChat_Load(object sender, EventArgs e)
        {

        }
    }
}
