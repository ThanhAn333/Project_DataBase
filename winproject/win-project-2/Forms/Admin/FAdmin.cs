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
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCQLTK());
        }

        private void ShowUserControl(UserControl uc)
        {
            // Xóa các UserControl đang có trong panelMain
            panelAdmin.Controls.Clear();

            // Đặt kích thước UserControl khớp với Panel
            uc.Dock = DockStyle.Fill;

            // Thêm UserControl mới vào panelMain
            panelAdmin.Controls.Add(uc);

            // Đảm bảo UserControl hiển thị đúng trên cùng
            uc.BringToFront();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCQLBV());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCQLDG());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCQLBC());
        }
    }
}
