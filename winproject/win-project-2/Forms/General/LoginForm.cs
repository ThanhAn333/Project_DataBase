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
using win_project_2.Forms.General;
using win_project_2.Forms.Recruiter;
using win_project_2.Service;
using win_project_2.SQLConn;

namespace win_project_2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        //HomeEmployee fHome = new HomeEmployee();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lberror.Visible = true;
                lberror.Text = "Vui lòng nhập email và mật khẩu!";
                return;
            }

            UserDAO userDAO = new UserDAO();
            DataTable dt = userDAO.layThongTinTK(txtEmail.Text,txtPassword.Text);
            if (dt == null || dt.Rows.Count == 0)
            {
                lberror.Visible = true;
                lberror.Text = "Email hoặc mật khẩu không chính xác!";
                txtPassword.ResetText();
                return;
            }
            DataRow dr = dt.Rows[0];
            UserDangNhap.userId = (int)dr["UserID"];
            UserDangNhap.email = dr["Email"].ToString();
            UserDangNhap.name = dr["Name"].ToString();
            UserDangNhap.role = dr["Role"].ToString();
            UserDangNhap.phone = dr["PhoneNumber"].ToString();
            UserDangNhap.password = dr["Password"].ToString();
            UserDangNhap.address = dr["Address"].ToString();
            UserDangNhap.birthday = dr["DateOfBirth"].ToString();
            UserDangNhap.image = dr["ProfilePicture"].ToString();
            

            var result = userDAO.Login(txtEmail.Text, txtPassword.Text);

            if (result.UserID.HasValue && !string.IsNullOrEmpty(result.Role))
            {
                string role = result.Role;

                if (role == "Candidate")
                {
                    int userId = result.UserID ?? 0;
                    HomeEmployee fHome = new HomeEmployee(userId);
                    fHome.Show();
                    this.Hide();
                }
                else if (role == "Employer")
                {
                    int userId = result.UserID ?? 0;
                    HomeRecruiter homeRecruiter = new HomeRecruiter(userId);
                    homeRecruiter.Show();
                    this.Hide();
                }
                else if (role == "Admin")
                {
                    FAdmin fAdmin = new FAdmin();
                    fAdmin.Show();
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
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
            this.Hide();
        }

        private void phide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '•')
            {
                peye.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void peye_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                phide.BringToFront();
                txtPassword.PasswordChar = '•';
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            //fHome.Close();
        }
    }
}
