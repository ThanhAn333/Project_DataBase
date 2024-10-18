using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_project_2.DAO;
using win_project_2.Forms;
using win_project_2.SQLConn;

namespace win_project_2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                lberror.Visible = true;
            }
            else
            {
                try
                {
                    
                    UserDAO userDAO = new UserDAO();
                   

                }
                catch
                {
                    
                }
            }
        }
    }
}
