using Guna.UI2.WinForms;
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
using win_project_2.Models;

namespace win_project_2.UserControls
{
    public partial class UCQLTK : UserControl
    {
        public UCQLTK()
        {
            InitializeComponent();
            LoadAllUser();
        }

        void LoadAllUser()
        {
            UserDAO userDAO = new UserDAO();
            DataTable dttable = userDAO.LoadAllUsers();

            this.DataGridView.DataSource = dttable;
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridView.Rows[e.RowIndex];

                txt_gmail.Texts = row.Cells["Email"].Value.ToString();
                txt_ten.Texts = row.Cells["Name"].Value.ToString();
                txt_diachi.Texts = row.Cells["Address"].Value != null ? row.Cells["Address"].Value.ToString() : string.Empty;
                txt_matkhau.Texts = row.Cells["Password"].Value.ToString();
                txt_ngaysinh.Texts = row.Cells["DateOfBirth"].Value != null ? Convert.ToDateTime(row.Cells["DateOfBirth"].Value).ToString("yyyy-MM-dd") : string.Empty;
                txt_role.Texts = row.Cells["Role"].Value.ToString();
                txt_sdt.Texts = row.Cells["PhoneNumber"].Value != null ? row.Cells["PhoneNumber"].Value.ToString() : string.Empty;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                UserDAO userDAO = new UserDAO();
                int maxUserID = userDAO.GetMaxUserID();

                User newUser = new User(
                    maxUserID + 1,
                    txt_ten.Texts,
                    txt_gmail.Texts,
                    txt_matkhau.Texts,
                    txt_role.Texts,
                    !string.IsNullOrEmpty(txt_diachi.Texts) ? txt_diachi.Texts : null,
                    !string.IsNullOrEmpty(txt_ngaysinh.Texts) ? Convert.ToDateTime(txt_ngaysinh.Texts) : DateTime.MinValue,
                    !string.IsNullOrEmpty(txt_sdt.Texts) ? txt_sdt.Texts : null,
                    null,
                    DateTime.Now,
                    DateTime.Now
                );

                userDAO.AddUser(newUser);

                MessageBox.Show("Thêm user thành công!");
                LoadAllUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm user: " + ex.Message);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    int userID = Convert.ToInt32(DataGridView.SelectedRows[0].Cells["UserID"].Value);

                    UserDAO userDAO = new UserDAO();
                    userDAO.DeleteUser(userID);

                    MessageBox.Show("Xóa user thành công!");
                    LoadAllUser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa user: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một user để xóa.");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count > 0)
            {
                int userID = Convert.ToInt32(DataGridView.SelectedRows[0].Cells["UserID"].Value);

                User updatedUser = new User(
                    userID,
                    txt_ten.Texts,
                    txt_gmail.Texts,
                    txt_matkhau.Texts,
                    txt_role.Texts,
                    !string.IsNullOrEmpty(txt_diachi.Texts) ? txt_diachi.Texts : null,
                    !string.IsNullOrEmpty(txt_ngaysinh.Texts) ? Convert.ToDateTime(txt_ngaysinh.Texts) : DateTime.MinValue,
                    !string.IsNullOrEmpty(txt_sdt.Texts) ? txt_sdt.Texts : null,
                    null,
                    DateTime.Now,
                    DateTime.Now
                );

                UserDAO userDAO = new UserDAO();
                userDAO.UpdateUser(updatedUser);

                MessageBox.Show("Cập nhật user thành công!");
                LoadAllUser();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một user để sửa.");
            }
        }
    }
}
