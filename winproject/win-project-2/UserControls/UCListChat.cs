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
            

        }

        private void lb_name_Click(object sender, EventArgs e)
        {

        }

        private void btn_chat_Click(object sender, EventArgs e)
        {
            
        }

        private void UCListChat_Load(object sender, EventArgs e)
        {

        }
    }
}
