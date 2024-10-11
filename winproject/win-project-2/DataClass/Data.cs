using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Firebase.Storage;
using System;
using System.IO;
using System.Threading.Tasks;
using FireSharp;
using System.Windows.Forms;
using System.Web.UI.WebControls;

namespace win_project_2
{
    internal class Data
    {
        private IFirebaseConfig config;
        private IFirebaseClient client;
        public event Action OnStatusChanged;
        public int postCount;

        string value = GlobalVariables.id;
        public Data()
        {
            config = new FirebaseConfig
            {
                AuthSecret = "bzVpBwNt053VMRWqXMuNt1yL7sAdVeNZMu810ZoW",
                BasePath = "https://win-project-dcfd0-default-rtdb.asia-southeast1.firebasedatabase.app/"
            };
            client = new FirebaseClient(config);
            SubscribeToStatusChanges();
        }

        public async Task<string> uploadFile(string file_path)
        {
            var stream = File.Open(file_path, FileMode.Open);
            var storage = new FirebaseStorage("win-project-dcfd0.appspot.com");
            var task = storage
                .Child("files")
                .Child(Path.GetFileName(file_path))
                .PutAsync(stream);

            string downloadUrl = "";
            try
            {
                downloadUrl = await task;
                //MessageBox.Show("File uploaded successfully! Download URL: " + downloadUrl);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                stream.Close();
            }
            return downloadUrl;
        }

        public async Task UploadData(string file_path ,UserInfo userinfo)
        {

            SetResponse response = await client.SetAsync(file_path, userinfo);
        }

        public async Task<UserInfo> GetData(string path)
        {
            FirebaseResponse response = await client.GetAsync(path);
            UserInfo userinfo = response.ResultAs<UserInfo>();
            return userinfo;
        }

        public async Task PostArticle(string content, string senderId, string imageUrl, string tag, string post_type)
        {
            FirebaseResponse response = await client.GetAsync("numPost/" + post_type);
            postCount = response.ResultAs<int>();
            //Console.WriteLine(response.Body);
            postCount++;
            //Console.WriteLine(response.Body);

            SetResponse setResponse = await client.SetAsync("numPost/" + post_type, postCount);
            //Console.WriteLine(setResponse.Body);
            if (setResponse.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("Failed to increment post count.");
                return;
            }

            //var newPost = new Post(content, senderId, imageUrl, tag);
            Console.WriteLine(postCount);
            //SetResponse postResponse = await client.SetAsync("Post/" + post_type + "/" + postCount + "/" , newPost);
            //if (postResponse.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("Failed to post article.");
                return;
            }
        }

        private async void SubscribeToStatusChanges()
        {
            try
            {
                await client.OnAsync("Post/tim-nv/", (sender, args, context) => {
                    Console.WriteLine("Data changed!", args.Data);
                    OnStatusChanged?.Invoke();
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
