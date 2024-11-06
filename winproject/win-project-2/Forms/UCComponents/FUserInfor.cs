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
using win_project_2.Service;

namespace win_project_2.Forms
{
    public partial class FUserInfor : Form
    {
        string FileImageName = "";

        
        public FUserInfor()
        {
            InitializeComponent();
            LoadDataUser();
        }

        void LoadDataUser()
        {
            UserDAO userDAO = new UserDAO();
            txb_Name.Text = UserDangNhap.name;
            txb_Email.Text = UserDangNhap.email;
            txb_SDT.Text = UserDangNhap.phone;
            dtBirthday.Value = DateTime.Parse(UserDangNhap.birthday);
            rating.Value = Convert.ToInt32(UserDangNhap.rating);
            if(!string.IsNullOrEmpty(UserDangNhap.image) && File.Exists(UserDangNhap.image))
            {
                avatar_box.Image = Image.FromFile(UserDangNhap.image);

            }
            else
            {
                avatar_box.Image = Image.FromFile("D:\\Nam3\\Hệ QT Cơ sở dữ liệu\\Project\\PROJECT_MOI\\Project_DataBase\\winproject\\win-project-2\\Resources\\user.png");
            }

            SkillDAO skillDAO = new SkillDAO();
            List<Skill> skills = skillDAO.GetSkillsByUserId(UserDangNhap.userId);

            if (skills.Count > 0)
            {
                Skill skill = skills[0];
                txb_skill_name.Text = skill.Name;
                txb_skill_descript.Text = skill.Description;
                Level.SelectedItem = skill.ProficiencyLevel;
            }

            ReviewDAO reviewDAO = new ReviewDAO();
            DataTable dt = reviewDAO.DoDuLieuBangReview(UserDangNhap.userId);
            dgreview.DataSource = dt;

        }

        private string SaveImageToDirectory(string filePath)
        {
            string fileName = Path.GetFileName(filePath);      
            return fileName;
        }
        void LoadImage(ref string imageName)
        {
            OpenFileDialog fileImageName = new OpenFileDialog();
            if (fileImageName.ShowDialog() == DialogResult.OK)
            {
                imageName = fileImageName.FileName;
            }
        }
        String imange = "";
        private void btn_upload_avatar_Click(object sender, EventArgs e)
        {
            LoadImage(ref FileImageName);
            using (var tempImage = new Bitmap(FileImageName))
            {
                avatar_box.Image = new Bitmap(tempImage);
                imange = FileImageName;
            }
        }

        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            //User user = userDAO.GetUserByID(UserDangNhap.userId);
            User user = userDAO.GetUserByID1(UserDangNhap.userId);

            if (user != null)
            {

                user.Name = txb_Name.Text;
                user.Email = txb_Email.Text;
                user.birthDate = dtBirthday.Value;
                user.PhoneNumber = txb_SDT.Text;

                if(imange != null)
                {
                    user.image = imange;
                    UserDangNhap.image = imange;

                }

               // userDAO.UpdateUser(user);

                userDAO.UpdateEmployerView(user);//phân quyền 

                MessageBox.Show("Thông tin người dùng đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            SkillDAO skillDAO = new SkillDAO();

            string name = txb_skill_name.Text;
            string description = txb_skill_descript.Text;
            string proficiencyLevel = Level.SelectedItem.ToString();

            bool isAdded = skillDAO.AddSkill(UserDangNhap.userId, name, description, proficiencyLevel);

            if (isAdded)
            {
                MessageBox.Show("Kỹ năng đã được thêm thành công.");
            }
            else
            {
                MessageBox.Show("Thêm kỹ năng thất bại.");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

