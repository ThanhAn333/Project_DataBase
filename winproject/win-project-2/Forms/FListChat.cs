using Firebase.Auth;
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
    public partial class FListChat : Form
    {
        public FListChat()
        {
            InitializeComponent();
            
        }

        public async void LoadData(string id)
        {
        }

        private void FListChat_Load(object sender, EventArgs e)
        {

        }

        public void DisplayInPanel(string id)
        {
            this.panel1.Controls.Clear();
            FChat f = new FChat(id);
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            f.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
