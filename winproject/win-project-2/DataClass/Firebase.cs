using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Auth;
using win_project_2.DataClass;

namespace win_project_2
{
    internal class Firebase
    {
        private const string apiKey = "AIzaSyBHopjb5Cn1r26GQTgsTALAPEVx0UrSUsU";
        private FirebaseAuthProvider authProvider;

        public Firebase()
        {
            authProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
        }

        public async Task CreateUser(string email, string password)
        {
            try
            {
                var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(email, password);
            }
            catch (FirebaseAuthException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                if (ex.Message.Contains("EMAIL_EXISTS"))
                {
                    MessageBox.Show("Email đã được sử dụng để tạo tài khoản. Vui lòng sử dụng email khác.");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tạo tài khoản: " + ex.Message);
                }
            }
        }


        public async Task<string> SignInAsync(string email, string password)
        {
            try
            {
                var auth = await authProvider.SignInWithEmailAndPasswordAsync(email, password);
                return auth.FirebaseToken;
            }
            catch (FirebaseAuthException)
            {
                return null;
            }
        }

        public async Task<bool> CheckIsTho(string username)
        {
            var dt = new DB();
            NguoiTho nguoitho = await dt.GetInfoNguoiTho(username);
            if (nguoitho == null)
            {
                return false;
            }
            return true;
        }
    }
}
