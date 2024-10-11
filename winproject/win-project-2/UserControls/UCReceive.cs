using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_project_2.UserControls
{
    public partial class UCReceive : UserControl
    {
        public UCReceive()
        {
            InitializeComponent();
        }
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; label1.Text = value; }
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
