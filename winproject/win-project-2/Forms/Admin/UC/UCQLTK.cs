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
using System.IO;


namespace win_project_2.UserControls
{
    public partial class UCQLTK : UserControl
    {
        public UCQLTK()
        {
            InitializeComponent();
            LoadAllUser();
        }

        private void LoadAllUser()
        {

            
            UserDAO userDAO = new UserDAO();  // Khởi tạo đối tượng UserDAO
            int userCount = userDAO.CountUsers();
            DataTable userTable = userDAO.LoadAllUsers();  // Lấy dữ liệu từ DAO

            
            Console.WriteLine("Số lượng User: " + userCount);  // Kiểm tra số lượng
            lb_dem.Text = userCount.ToString();
         

            if (userTable != null && userTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = userTable;  // Gán dữ liệu vào DataGridView

                // Thiết lập tiêu đề cho các cột
                dataGridView1.Columns["Name"].HeaderText = "Tên";
                dataGridView1.Columns["Email"].HeaderText = "Gmail";
                dataGridView1.Columns["Address"].HeaderText = "Địa chỉ";
                dataGridView1.Columns["Password"].HeaderText = "Mật khẩu";
                dataGridView1.Columns["DateOfBirth"].HeaderText = "Ngày sinh";
                dataGridView1.Columns["Role"].HeaderText = "Vai trò";
                dataGridView1.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
                dataGridView1.Columns["ProfilePicture"].HeaderText = "Ảnh đại diện"; // Đảm bảo có cột này

                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Indigo;
               dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;  // Màu chữ
              dataGridView1 .EnableHeadersVisualStyles = false;  // Tắt kiểu mặc định của header

                // Tự động điều chỉnh kích thước cột để phù hợp với nội dung
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.");  // Thông báo nếu bảng trống
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) // Kiểm tra nếu là cột hình ảnh
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Hiển thị hình ảnh trong một PictureBox hoặc một Form mới
                string imagePath = row.Cells["ProfilePicture"].Value.ToString();
                if (File.Exists(imagePath))
                {
                    // Mở hình ảnh trong PictureBox
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(imagePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Dock = DockStyle.Fill;

                    Form imageForm = new Form();
                    imageForm.Controls.Add(pictureBox);
                    imageForm.ClientSize = new Size(400, 400); // Kích thước cửa sổ
                    imageForm.ShowDialog(); // Hiển thị cửa sổ
                }
                else
                {
                    MessageBox.Show("Hình ảnh không tồn tại.");
                }
            }
            else if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txt_gmail.Texts = row.Cells["Email"].Value.ToString();
                txt_ten.Texts = row.Cells["Name"].Value.ToString();
                txt_diachi.Texts = row.Cells["Address"].Value != null ? row.Cells["Address"].Value.ToString() : string.Empty;
                txt_matkhau.Texts = row.Cells["Password"].Value.ToString();
                txt_ngaysinh.Texts = row.Cells["DateOfBirth"].Value != null ? Convert.ToDateTime(row.Cells["DateOfBirth"].Value).ToString("yyyy-MM-dd") : string.Empty;
                txt_role.Texts = row.Cells["Role"].Value.ToString();
                txt_sdt.Texts = row.Cells["PhoneNumber"].Value != null ? row.Cells["PhoneNumber"].Value.ToString() : string.Empty;

                string imagePath = row.Cells["ProfilePicture"].Value.ToString();
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    pb_avatar.Image = Image.FromFile(imagePath); // Hiển thị ảnh trong PictureBox
                }
                else
                {
                    pb_avatar.Image = null; // Nếu không có ảnh, đặt thành null
                }
            }
        }





        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                UserDAO userDAO = new UserDAO();
                int maxUserID = userDAO.GetMaxUserID();

                // Nếu bạn có một OpenFileDialog để chọn ảnh
                string imagePath = null;
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Các định dạng ảnh
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Lưu ảnh vào thư mục Images và lấy đường dẫn
                        string fileName = Path.GetFileName(openFileDialog.FileName);
                        imagePath = Path.Combine("Images", fileName); // Thay đổi đường dẫn nếu cần

                        // Sao chép ảnh vào thư mục
                        File.Copy(openFileDialog.FileName, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath), true);
                    }
                }

                User newUser = new User(
                    maxUserID + 1,
                    txt_ten.Texts,
                    txt_gmail.Texts,
                    txt_matkhau.Texts,
                    txt_role.Texts,
                    !string.IsNullOrEmpty(txt_diachi.Texts) ? txt_diachi.Texts : null,
                    !string.IsNullOrEmpty(txt_ngaysinh.Texts) ? Convert.ToDateTime(txt_ngaysinh.Texts) : DateTime.MinValue,
                    !string.IsNullOrEmpty(txt_sdt.Texts) ? txt_sdt.Texts : null,
                    imagePath, // Đường dẫn ảnh đã lưu
                    DateTime.Now,
                    DateTime.Now
                );

                // Thêm người dùng vào cơ sở dữ liệu
                userDAO.AddUser(newUser);
                MessageBox.Show("Thêm người dùng thành công!");
                LoadAllUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int userID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserID"].Value);

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
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int userID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserID"].Value);
                    string imagePath = null;

                    UserDAO userDAO = new UserDAO();

                    // Mở OpenFileDialog để chọn ảnh
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Các định dạng ảnh
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Lưu ảnh vào thư mục Images
                            string fileName = Path.GetFileName(openFileDialog.FileName);
                            imagePath = Path.Combine("Images", fileName);

                            // Sao chép ảnh vào thư mục
                            string targetPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);
                            File.Copy(openFileDialog.FileName, targetPath, true);
                        }
                        else
                        {
                            // Nếu không chọn ảnh, lấy đường dẫn ảnh cũ từ cơ sở dữ liệu
                            User oldUser = userDAO.GetUserByID(userID); // Giả sử có phương thức này
                            imagePath = oldUser.image; // Lấy đường dẫn ảnh cũ
                        }
                    }

                    User updatedUser = new User(
                        userID,
                        txt_ten.Texts,
                        txt_gmail.Texts,
                        txt_matkhau.Texts,
                        txt_role.Texts,
                        !string.IsNullOrEmpty(txt_diachi.Texts) ? txt_diachi.Texts : null,
                        !string.IsNullOrEmpty(txt_ngaysinh.Texts) ? Convert.ToDateTime(txt_ngaysinh.Texts) : DateTime.MinValue,
                        !string.IsNullOrEmpty(txt_sdt.Texts) ? txt_sdt.Texts : null,
                        imagePath,
                        DateTime.Now,
                        DateTime.Now
                    );

                    userDAO.UpdateUser(updatedUser);
                    MessageBox.Show("Cập nhật người dùng thành công!");
                    LoadAllUser(); // Tải lại danh sách người dùng
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một người dùng để sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }






        private string selectedImagePath; // Biến để lưu đường dẫn hình ảnh đã chọn


        private void pb_avatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Chọn ảnh đại diện";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file
                    string imagePath = openFileDialog.FileName;
                    pb_avatar.Image = Image.FromFile(imagePath); // Hiển thị ảnh trong PictureBox
                    this.selectedImagePath = imagePath;

                }
            }
        }
    }
}
