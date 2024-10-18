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
    public partial class UCShowJobcs : UserControl
    {
        string id_post = "";
        public UCShowJobcs()
        {
            InitializeComponent();
            
        }

        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FDetail1 f = new FDetail1(id_post);
            f.ShowDialog();
        }

        private void lb_location_Click(object sender, EventArgs e)
        {

        }
    }
}
