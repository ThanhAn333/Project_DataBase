using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using win_project_2.UserControls;

namespace win_project_2.Forms
{
    public partial class FListReview : Form
    {
        public FListReview(string id)
        {
            InitializeComponent();
            Loadlist(id);
        }

        public async void Loadlist(string id)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
