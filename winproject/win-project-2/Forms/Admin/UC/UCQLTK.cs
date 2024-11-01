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
using OfficeOpenXml;


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
            DataTable userTable = userDAO.LoadAllUsers();  // Lấy dữ liệu từ DAO

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

                // Khai báo biến lưu trữ đường dẫn ảnh
                string imagePath = SelectImage();

                // Tạo đối tượng User mới
                User newUser = new User(
                    0, // Giả sử UserID là 0 hoặc bạn có thể thay thế bằng giá trị phù hợp
                    txt_ten.Texts,
                    txt_gmail.Texts,
                    txt_matkhau.Texts,
                    txt_role.Texts,
                    string.IsNullOrEmpty(txt_diachi.Texts) ? null : txt_diachi.Texts,
                    string.IsNullOrEmpty(txt_ngaysinh.Texts) ? DateTime.MinValue : Convert.ToDateTime(txt_ngaysinh.Texts),
                    string.IsNullOrEmpty(txt_sdt.Texts) ? null : txt_sdt.Texts,
                    imagePath, // Đường dẫn ảnh đã lưu
                    DateTime.Now, // CreatedAt
                    DateTime.Now  // UpdatedAt
                );

                // Thêm người dùng vào cơ sở dữ liệu
                userDAO.AddUser1(newUser);
                MessageBox.Show("Thêm người dùng thành công!");

                // Tải lại danh sách người dùng
                LoadAllUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }



        // Phương thức để chọn ảnh từ máy tính
        private string SelectImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Các định dạng ảnh

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = Path.GetFileName(openFileDialog.FileName);
                    string imagePath = Path.Combine("Images", fileName); // Đường dẫn thư mục lưu ảnh

                    // Sao chép ảnh vào thư mục Images trong dự án
                    File.Copy(openFileDialog.FileName, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath), true);
                    return imagePath; // Trả về đường dẫn ảnh
                }
            }

            return null; // Trả về null nếu không chọn ảnh
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Lấy ID từ TextBox
            int userId;
            if (int.TryParse(tbtimkiem.Text, out userId))
            {
                bool found = false; // Biến để kiểm tra xem đã tìm thấy hay chưa

                // Làm sạch màu nền của tất cả các dòng
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White; // Đặt lại màu nền
                    row.Selected = false; // Bỏ chọn dòng
                }

                // Lặp qua từng dòng trong DataGridView để tìm kiếm UserID
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Kiểm tra UserID của dòng với ID nhập vào
                    if ((int)row.Cells["UserID"].Value == userId)
                    {
                        // Tô màu dòng tương ứng
                        // Tô màu dòng
                        row.Selected = true; // Chọn dòng
                        found = true; // Đã tìm thấy
                        break; // Ngừng tìm kiếm
                    }
                }

                // Hiện thông báo nếu không tìm thấy
                if (!found)
                {
                    label1.Text = "Không tìm thấy người dùng với ID này.";
                }
                else
                {
                    // Xóa thông báo không tìm thấy nếu có
                    label1.Text = string.Empty;
                }
            }
            else
            {
                // Hiện thông báo nếu ID không hợp lệ
                label1.Text = "Vui lòng nhập ID hợp lệ.";
            }
        }

        public void ExportDataTableToCSV(DataTable dataTable, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Viết tiêu đề
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    writer.Write(dataTable.Columns[i].ColumnName);
                    if (i < dataTable.Columns.Count - 1)
                        writer.Write(",");
                }
                writer.WriteLine();

                // Viết dữ liệu
                foreach (DataRow row in dataTable.Rows)
                {
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        writer.Write(row[i].ToString());
                        if (i < dataTable.Columns.Count - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();
                }
            }
        }

        // Gọi hàm xuất dữ liệu từ DataTable
       

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            DataTable userList = userDAO.GetUserList(); // Gọi stored procedure

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = "UserList.csv",
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Save a CSV File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportDataTableToCSV(userList, saveFileDialog.FileName);
                MessageBox.Show("Dữ liệu đã được xuất thành công!");
            }
        }


        public void ExportDataGridViewToExcel(DataGridView dataGridView, string filePath)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Users");

                // Viết tiêu đề
                for (int i = 1; i <= dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i].Value = dataGridView.Columns[i - 1].HeaderText;
                }

                // Viết dữ liệu
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value;
                    }
                }

                FileInfo excelFile = new FileInfo(filePath);
                excelPackage.SaveAs(excelFile);
            }
        }

        // Gọi hàm xuất dữ liệu từ DataGridView
       

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = "UserList.xlsx",
                Filter = "Excel files (*.xlsx)|*.xlsx",
                Title = "Save an Excel File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportDataGridViewToExcel(dataGridView1, saveFileDialog.FileName);
                MessageBox.Show("Dữ liệu đã được xuất thành công!");
            }
        }
    }
}
