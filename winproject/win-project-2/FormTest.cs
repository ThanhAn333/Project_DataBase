using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_project_2.DataClass
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //Up info NguoiTimTho (dùng khi tạo tk hoặc cập nhật thông tin)
            var dt = new DB();
            NguoiTimTho nguoiTimTho = new NguoiTimTho("", "", "Nguyễn Văn A", "01/01/1990", "0123456789", "", "email@example.com", "123 Đường ABC, Quận 1", false, GlobalVariables.id);
            dt.UploadInfoNguoiTimTho(nguoiTimTho);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            //Trả về List gồm các NguoiTho mà NguoiTimTho yêu thích 


            var dt = new DB();
            NguoiTimTho nguoitimtho = await dt.GetInfoNguoiTimTho(GlobalVariables.id); //GlobalVariables.id là id của tk hiện đăng nhập, có thể sửa thành id của tk khác để xem ds fav của người khác
            //MessageBox.Show(nguoitimtho.FavThoIds);
            List<NguoiTho> listnguoitho = await dt.GetInfoFavTho(nguoitimtho.FavThoIds);
            foreach (NguoiTho nguoitho in listnguoitho)
            {
                Console.WriteLine("Tên: " + nguoitho.Name);
                Console.WriteLine("Ngày sinh: " + nguoitho.DateOfBirth);
                Console.WriteLine("Số điện thoại: " + nguoitho.PhoneNumber);
                Console.WriteLine("Email: " + nguoitho.Email);
                Console.WriteLine("Địa chỉ: " + nguoitho.Address);
                // In thêm các thông tin khác của NguoiTho nếu cần
                Console.WriteLine("---------------------");
            }

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            //Up Post lên để và cập nhật Posted của NguoiTimTho

            var dt = new DB();
            Post newPost = new Post("", "Sua may lanh", "...", "tphcm", "30/03/20224", "...", "200000", GlobalVariables.id);
            string temp = await dt.PostArticle(newPost);
            await dt.AddPostToPosted(temp);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //Up info NguoiTho dùng khi tạo tk hoặc cập nhật info

            var dt = new DB();
            NguoiTho nguoiTho = new NguoiTho("", "Pham Van C", "15/03/2000", "291388287", "", "test@gmail.com", "Ha Noi", true, "rrr", "Game Dev", "Game", 20000000, "100", "Ha Noi", "12/12", 0);
            dt.UploadInfoNguoiTho(nguoiTho);
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            // Lấy List tất cả Post NguoiTimTho đã đăng

            var dt = new DB();
            NguoiTimTho nguoiTimTho = await dt.GetInfoNguoiTimTho(GlobalVariables.id); //GlobalVariables.id là id của chính tk đang dùng, có thể sửa thành id của người khác để xem ds tất cả Post mà id này đã đăng
            List<Post> listPost = await dt.GetListPost(nguoiTimTho.PostIds);
            foreach (Post post in listPost)
            {
                Console.WriteLine("ID: " + post.Id);
                Console.WriteLine("Tag: " + post.Tag);
                Console.WriteLine("Mô tả: " + post.Description);
                Console.WriteLine("Địa điểm: " + post.Location);
                Console.WriteLine("Ngày: " + post.Date);
                Console.WriteLine("Yêu cầu: " + post.Request);
                Console.WriteLine("Giá: " + post.Price);
                Console.WriteLine("ID người gửi: " + post.SenderId);
                Console.WriteLine("---------------------");
            }

        }

        private async void button6_Click(object sender, EventArgs e)
        {

            //Trả về Ds tất cả Post đã thực hiện

            var dt = new DB();
            NguoiTho nguoiTho = await dt.GetInfoNguoiTho(GlobalVariables.id); //GlobalVariables.id là id của chính tk đang dùng, có thể sửa thành id của người khác để xem ds tất cả Post mà id này đã đăng
            List<Post> listPost = await dt.GetListPost(nguoiTho.DonePostIds);
            foreach (Post post in listPost)
            {
                Console.WriteLine("ID: " + post.Id);
                Console.WriteLine("Tag: " + post.Tag);
                Console.WriteLine("Mô tả: " + post.Description);
                Console.WriteLine("Địa điểm: " + post.Location);
                Console.WriteLine("Ngày: " + post.Date);
                Console.WriteLine("Yêu cầu: " + post.Request);
                Console.WriteLine("Giá: " + post.Price);
                Console.WriteLine("ID người gửi: " + post.SenderId);
                Console.WriteLine("---------------------");
            }
        }

        private async void button7_Click(object sender, EventArgs e)
        {

            // Lấy Thông tin tất cả NguoiTimTho trả về List

            var dt = new DB();
            List<NguoiTimTho> listNguoiTimTho = await dt.GetAllNguoiTimTho();
            foreach (NguoiTimTho nguoiTimTho in listNguoiTimTho)
            {
                Console.WriteLine("ID: " + nguoiTimTho.Id);
                Console.WriteLine("Tên: " + nguoiTimTho.Name);
                Console.WriteLine("Ngày sinh: " + nguoiTimTho.DateOfBirth);
                Console.WriteLine("Số điện thoại: " + nguoiTimTho.PhoneNumber);
                Console.WriteLine("Email: " + nguoiTimTho.Email);
                Console.WriteLine("Địa chỉ: " + nguoiTimTho.Address);
                Console.WriteLine("FavThoIds: " + nguoiTimTho.FavThoIds);
                Console.WriteLine("PostIds: " + nguoiTimTho.PostIds);
                Console.WriteLine("---------------------");
            }
        }

        private async void button8_Click(object sender, EventArgs e)
        {

            //Lấy tất cả thông tin NguoiTho trả về List

            var dt = new DB();
            List<NguoiTho> listNguoiTho = await dt.GetAllNguoiTho();
            foreach (NguoiTho nguoiTho in listNguoiTho)
            {
                Console.WriteLine("ID: " + nguoiTho.Id);
                Console.WriteLine("Tên: " + nguoiTho.Name);
                Console.WriteLine("Ngày sinh: " + nguoiTho.DateOfBirth);
                Console.WriteLine("Số điện thoại: " + nguoiTho.PhoneNumber);
                Console.WriteLine("Email: " + nguoiTho.Email);
                Console.WriteLine("Địa chỉ: " + nguoiTho.Address);
                Console.WriteLine("Tên công việc: " + nguoiTho.JobName);
                Console.WriteLine("Mô tả: " + nguoiTho.Description);
                Console.WriteLine("Giá: " + nguoiTho.Price);
                Console.WriteLine("Kỹ năng: " + nguoiTho.Skills);
                Console.WriteLine("Địa điểm làm việc: " + nguoiTho.JobLocation);
                Console.WriteLine("Học vấn: " + nguoiTho.Study);
                Console.WriteLine("Các bài đăng đã hoàn thành: " + nguoiTho.DonePostIds);
                Console.WriteLine("---------------------");
            }
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            // Thêm NguoiTho vào danh sách FavTho

            var dt = new DB();
            await dt.AddUserToFavorites("test8"); //Thêm NguoiTho id = test8 vào ds yêu thích
        }

        private async void button11_Click(object sender, EventArgs e)
        {

            //Thêm Post vào ds Done Post

            var dt = new DB();
            await dt.AddPostToDonePost("1"); //Thêm Post có id = 1 vào ds Post Done
        }

        private async void button12_Click(object sender, EventArgs e)
        {
            //Thêm Id của bài đăng vào List Posted(ds tất cả bài đăng) của NguoiTimTho
            /*
             Hoặc đi kèm với Up Post và Up vừa cập nhật list posted
             
             var dt = new DB();
            Post newPost = new Post("", "Sua may lanh", "...", "tphcm", "30/03/20224", "...", 200000, GlobalVariables.id);
            string temp = await dt.PostArticle(newPost);
            await dt.AddPostToPosted(temp);
             */

            var dt = new DB();
            await dt.AddPostToPosted("1");
        }

        private async void button10_Click(object sender, EventArgs e)
        {

            // Lấy tất cả các Post trả về List

            var dt = new DB();
            List<Post> listPosts =  await dt.GetAllPosts();

            foreach (Post post in listPosts)
            {
                Console.WriteLine("ID: " + post.Id);
                Console.WriteLine("Tag: " + post.Tag);
                Console.WriteLine("Mô tả: " + post.Description);
                Console.WriteLine("Địa điểm: " + post.Location);
                Console.WriteLine("Ngày: " + post.Date);
                Console.WriteLine("Yêu cầu: " + post.Request);
                Console.WriteLine("Giá: " + post.Price);
                Console.WriteLine("ID người gửi: " + post.SenderId);
                Console.WriteLine("---------------------");
            }

        }

        private async void button13_Click(object sender, EventArgs e)
        {
            var dt = new DB();
            List<Review> listReview = await dt.GetAllReview("test10");

            foreach (Review rv in listReview)
            {
                Console.WriteLine(rv.Rating);
                Console.WriteLine(rv.NguoiThoId);
            }
        }

        private async void button14_Click(object sender, EventArgs e)
        {
            var dt = new DB();
            string tinnhan = "hieu" + "-" + "thang" + "-" + "tin nhan 10";
            //dt.SendMessage(tinnhan);
        }

        private async void button15_Click(object sender, EventArgs e)
        {
            var dt = new DB();
            List<string> listmess = await dt.GetAllMessagesAsync("");

            foreach(string s in listmess)
            {
                Console.WriteLine(s);
                Console.WriteLine("--------");
            }
        }

        private async void button16_Click(object sender, EventArgs e)
        {
            var dt = new DB();
        }
    }
}
