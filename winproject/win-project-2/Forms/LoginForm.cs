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
using win_project_2.Forms.Employer;
using win_project_2.Forms.Recruiter;
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

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lberror.Visible = true;
                lberror.Text = "Vui lòng nhập email và mật khẩu!";
                return; 
            }
                UserDAO userDAO = new UserDAO();
                string role = userDAO.Login(txtEmail.Text, txtPassword.Text);

                // Kiểm tra vai trò
                if (!string.IsNullOrEmpty(role))
                {
                    if (role == "Employer")
                    {
                        HomeEmployee fHome = new HomeEmployee();
                        fHome.Show();
                        this.Hide(); 
                    }
                    else if (role == "Recruiter")
                    {
                        HomeRecruiter homeRecruiter = new HomeRecruiter();
                        homeRecruiter.Show();
                        this.Hide();
                    }
                    else
                    {
                        lberror.Visible = true;
                        lberror.Text = "Vai trò không xác định!";
                    }
                }
                else
                {
                    lberror.Visible = true;
                    lberror.Text = "Email hoặc mật khẩu không chính xác!";
                    txtPassword.ResetText();
                }
            
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
