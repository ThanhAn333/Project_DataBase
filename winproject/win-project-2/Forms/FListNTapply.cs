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
    public partial class FListNTapply : Form
    {
        public FListNTapply()
        {
            InitializeComponent();
            LoadData();
        }

        public async void LoadData()
        {
            this.flowLayoutPanel1.Controls.Clear();
            var dt = new DB();
            List<string> list = await dt.GetAllApply();
            if (list == null) { return; }
            foreach (string item in list)
            {
                string[] parts = item.Split('-');
                if (parts[1] == "COMPLETE")
                {
                    UCWriteRV new_uc = new UCWriteRV(parts[2]);
                    new_uc.ParentFListNTapply = this;
                    flowLayoutPanel2.Controls.Add(new_uc);
                }
                else
                {
                    string[] users = parts[1].Split(',');
                    foreach (string user in users)
                    {
                        UCAccept new_uc = new UCAccept(parts[0], user);
                        new_uc.ParentFListNTapply = this;
                        flowLayoutPanel1.Controls.Add(new_uc);
                    }
                }
            }
        }
    }
}
