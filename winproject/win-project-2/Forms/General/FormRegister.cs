using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_project_2.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace win_project_2.Forms.General
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }
        public bool CheckEmail(string em) //Check email
        {
            return Regex.IsMatch(em, @"^[\w.]{3,50}@gmail.com(.vn|)$");
        }
        public bool CheckAccount(string ac)
        {
            return !Regex.IsMatch(ac, @"[^\w]");
        }
        public bool checkSDT(string sdt)
        {
            return Regex.IsMatch(sdt, @"^[0-9]{10,11}$");
        }
        public bool checkTenNguoiDung(string tnd)
        {
            return Regex.IsMatch(tnd, @"^[\p{L}\s]{1,50}$");
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string address = txtAddress.Text;
            DateTime dateOfBirth = dtBirthday.Value;
            string phoneNumber = txtPhoneNumber.Text;
            DateTime createdAt = DateTime.Now;

            
            lbError.Visible = false;
            lbErrorPassword.Visible = false;
            lbErrorName.Visible = false;
            lbErrorEmail.Visible = false;
            lbErrorPhone.Visible = false;
            lbErrorRadio.Visible = false;

            
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phoneNumber))
            {
                lbError.Visible = true;
                lbError.Text = "Vui lòng điền đầy đủ thông tin !";
                return; 
            }

            
            if (txtPassword.Text != txtPassword1.Text)
            {
                lbErrorPassword.Visible = true;
                lbErrorPassword.Text = "Mật khẩu không khớp!";
                return; 
            }

            
            if (!checkTenNguoiDung(name))
            {
                lbErrorName.Visible = true;
                lbErrorName.Text = "Tên người dùng không hợp lệ!";
                return; 
            }

            
            if (!CheckEmail(email))
            {
                lbErrorEmail.Visible = true;
                lbErrorEmail.Text = "Email không hợp lệ!";
                return; 
            }

            
            if (!CheckAccount(password))
            {
                lbErrorPassword.Visible = true;
                lbErrorPassword.Text = "Mật khẩu không hợp lệ!";
                return; 
            }

            
            if (!checkSDT(phoneNumber))
            {
                lbErrorPhone.Visible = true;
                lbErrorPhone.Text = "Số điện thoại không hợp lệ!";
                return; 
            }

            
            string role = "";
            if (rbEmployer.Checked)
            {
                role = "Employer";
            }
            else if (rbCandidate.Checked)
            {
                role = "Candidate";
            }
            else
            {
                lbErrorRadio.Visible = true;
                lbErrorRadio.Text = "Vui lòng chọn vai trò!";
                return; 
            }

            
            try
            {
                UserDAO userDAO = new UserDAO();
                userDAO.Register(name, email, password, role, address, dateOfBirth, phoneNumber, createdAt);

                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lbError.Visible = true;
                lbError.Text = $"Đã xảy ra lỗi: {ex.Message}";
            }


        }

       
        private void FormRegister_Load(object sender, EventArgs e)
        {
            
        }

        private void lbError_Click(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
