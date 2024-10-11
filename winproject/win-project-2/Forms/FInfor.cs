using Guna.UI2.WinForms;
using RJCodeAdvance.RJControls;
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
using System.Windows.Forms;
using System.Xml.Linq;
using win_project_2.DataClass;

namespace win_project_2
{
    public partial class FInfor : Form
    {
        string FileImageName = "";
        public FInfor()
        {
            InitializeComponent();
        }

        private async void rjButton2_Click(object sender, EventArgs e)
        {
            var firebase = new Firebase();
            await firebase.CreateUser(txt_mail.Texts, txt_pass.Texts);

            var dt = new DB();
            string id_user = txt_mail.Texts.Split('@')[0];
            GlobalVariables.id = id_user;
            if (rjToggleButton1.Checked)
            {
                var path = "";
                if (FileImageName != "")
                {
                    path = await dt.uploadFile(FileImageName);
                }
                NguoiTho nguoitho = new NguoiTho("", txt_name.Texts, txt_date.Texts, txt_phonenumber.Texts, path, txt_mail.Texts, txt_address.Texts, rjToggleButton1.Checked, id_user, "", "", 0, "", "", "", 0);
                await dt.UploadInfoNguoiTho(nguoitho);
            }
            else
            {
                var path = "";
                if (FileImageName != "")
                {
                    path = await dt.uploadFile(FileImageName);
                }
                NguoiTimTho nguoitimtho = new NguoiTimTho("", "", txt_name.Texts, txt_date.Texts, txt_phonenumber.Texts, path, txt_mail.Texts, txt_address.Texts, rjToggleButton1.Checked, id_user);
                await dt.UploadInfoNguoiTimTho(nguoitimtho);
            }

            this.Close();
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        void LoadImage(ref string imageName)
        {
            OpenFileDialog fileImageName = new OpenFileDialog();
            if (fileImageName.ShowDialog() == DialogResult.OK)
            {
                imageName = fileImageName.FileName;
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            LoadImage(ref FileImageName);

            // Sử dụng using để đảm bảo tài nguyên được giải phóng
            using (var tempImage = new Bitmap(FileImageName))
            {
                pictureBox1.Image = new Bitmap(tempImage);

            }
        }
    }
}
