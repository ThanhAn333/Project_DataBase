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
    public partial class FListNguoiTho : Form
    {
        private FMain mainForm;
        public FListNguoiTho()
        {
            InitializeComponent();
            LoadData();
        }
        public async void LoadData()
        {
            var dt = new DB();
            List<NguoiTho> listnguoitho = await dt.GetAllNguoiTho();
            foreach (NguoiTho nguoitho in listnguoitho)
            {
                var new_uc = new UCTho(nguoitho);
                flowLayoutPanel1.Controls.Add(new_uc);
            }
        }

        private async void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var dt = new DB();
            List<NguoiTho> listtho = await dt.GetAllNguoiTho();
            if (guna2TextBox1.Text != "")
            {
                foreach (NguoiTho tho in listtho)
                {
                    if (tho.JobName == guna2TextBox1.Text)
                    {
                        var new_uc = new UCTho(tho);
                        flowLayoutPanel1.Controls.Add(new_uc);
                    }

                }
            }
            else
            {
                foreach (NguoiTho tho in listtho)
                {

                        var new_uc = new UCTho(tho);
                        flowLayoutPanel1.Controls.Add(new_uc);
                    

                }
            }
        }
    }
}
