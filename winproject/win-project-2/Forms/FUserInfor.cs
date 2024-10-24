using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using System.Xml.Linq;
using win_project_2.Models;
using win_project_2.DAO;

namespace win_project_2.Forms
{
    public partial class FUserInfor : Form
    {
        string FileImageName = "";
        private int _userId;

        
        public FUserInfor(int userid)
        {
            InitializeComponent();
            _userId = userid;
            LoadDataUser();
        }

        void LoadDataUser()
        {
            UserDAO userDAO = new UserDAO();
            User user = userDAO.GetUserByID(_userId);

            if (user != null)
            {
                txb_Name.Text = user.Name;
                txb_Email.Text = user.Email;
                txb_SDT.Text = user.PhoneNumber;
                dtBirthday.Value = user.birthDate;
                
                
            }
        }


        void LoadImage(ref string imageName)
        {
            OpenFileDialog fileImageName = new OpenFileDialog();
            if (fileImageName.ShowDialog() == DialogResult.OK)
            {
                imageName = fileImageName.FileName;
            }
        }

        private void btn_upload_avatar_Click(object sender, EventArgs e)
        {
            LoadImage(ref FileImageName);
            using (var tempImage = new Bitmap(FileImageName))
            {
                avatar_box.Image = new Bitmap(tempImage);

            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            User user = userDAO.GetUserByID(_userId);

            if (user != null)
            {
                user.Name = txb_Name.Text;
                user.Email = txb_Email.Text;
                user.birthDate = dtBirthday.Value;
                user.PhoneNumber = txb_SDT.Text;

                userDAO.UpdateUser(user);

                MessageBox.Show("Thông tin người dùng đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bnt_Huy_Click(object sender, EventArgs e)
        {

        }
    }
}
