using Guna.UI2.AnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_project_2.Forms
{
    public partial class FHome : Form
    {


        private FMain mainForm;

        public FHome(FMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }


        private void FHome_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void pt_TimViec_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new FShowListJob());
        }

        private void pt_TimTho_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new FListNguoiTho());
        }

        private void pt_Chat_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new FListChat());
        }

        private void guna2Shapes2_Click(object sender, EventArgs e)
        {

        }

        private void pt_TimViec_Click_1(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new FShowListJob());
        }

        private void pt_TimTho_Click_1(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new FListNguoiTho());
        }

        private void pt_Chat_Click_1(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new FPostEmloyee());
        }
    }
}
