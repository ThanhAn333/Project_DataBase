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
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Security.Cryptography;


namespace win_project_2.DataClass
{
    public delegate void MessageReceivedHandler(string message);
    public delegate void NotificationReceivedHandler(string notification);
    public delegate void Notify_nt(string notify_nt);
    public delegate void Notify_ntt(string notify_ntt);
    public class DB
    {
        private IFirebaseConfig config;
        private IFirebaseClient client;

        
        public int postCount;

        string value = GlobalVariables.id;
        public event MessageReceivedHandler OnMessageReceived;
        public event NotificationReceivedHandler OnNotificationReceived;
        public event Notify_nt OnNotify_nt;
        public event Notify_ntt OnNotify_ntt;
        public DB()
        {
            config = new FirebaseConfig
            {
                AuthSecret = "bzVpBwNt053VMRWqXMuNt1yL7sAdVeNZMu810ZoW",
                BasePath = "https://win-project-dcfd0-default-rtdb.asia-southeast1.firebasedatabase.app/"
            };
            client = new FirebaseClient(config);
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
               
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                stream.Close();
            }
            return downloadUrl;
        }
        public async Task UploadInfoNguoiTimTho(NguoiTimTho nguoitimtho)
        {
            SetResponse response = await client.SetAsync("info/nguoitimtho/" + GlobalVariables.id, nguoitimtho);
        }

        public async Task<NguoiTimTho> GetInfoNguoiTimTho(string id)
        {
            FirebaseResponse response = await client.GetAsync("info/nguoitimtho/" + id);
            NguoiTimTho nguoitimtho = response.ResultAs<NguoiTimTho>();
            return nguoitimtho;
        }

        public async Task<List<NguoiTho>> GetInfoFavTho(string Ids) 
        {
            if (string.IsNullOrEmpty(Ids)) return null;

            List<NguoiTho> usersList = new List<NguoiTho>();
            string[] ids = Ids.Split(',');
            

            foreach (string id in ids)
            {
                NguoiTho user = await GetInfoNguoiTho(id);
                usersList.Add(user);
            }

            return usersList;
        }
        public async Task<Post> GetInfoPost(string id)
        {
            FirebaseResponse response = await client.GetAsync("post/timtho/" + id);
            Post post = response.ResultAs<Post>();
            return post;
        }

        public async Task<List<Post>> GetListPost(string Ids)
        {
            if (string.IsNullOrEmpty(Ids)) return null;

            List<Post> postsList = new List<Post>();
            string[] ids = Ids.Split(',');


            foreach (string id in ids)
            {
                Post post = await GetInfoPost("p" + id);
                postsList.Add(post);
            }

            return postsList;
        }

        public async Task AddUserToFavorites(string userId)
        {
            
            FirebaseResponse response = await client.GetAsync("info/nguoitimtho/" + GlobalVariables.id + "/FavThoIds");
            var favTho = response.ResultAs<string>();

            
            if (!favTho.Contains(userId))
            {
                if (favTho == "")
                {
                    favTho += userId;
                }
                else
                {
                    favTho += "," + userId;
                }
                SetResponse setResponse = await client.SetAsync("info/nguoitimtho/" + GlobalVariables.id + "/FavThoIds", favTho);
                if (setResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine("ID người dùng đã được thêm vào danh sách yêu thích.");
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi thêm ID người dùng.");
                }
            }
            else
            {
                Console.WriteLine("ID người dùng đã tồn tại trong danh sách yêu thích.");
            }
        }



        public async Task<List<NguoiTimTho>> GetAllNguoiTimTho()
        {
            FirebaseResponse response = await client.GetAsync("info/nguoitimtho/");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var allNguoiTimTho = response.ResultAs<Dictionary<string, NguoiTimTho>>();
                List<NguoiTimTho> listNguoiTimTho = allNguoiTimTho.Values.ToList();

                return listNguoiTimTho;
            }
            else
            {
                Console.WriteLine("Không thể lấy dữ liệu: " + response.StatusCode);
                return new List<NguoiTimTho>();
            }
        }

        public async Task UploadInfoNguoiTho(NguoiTho nguoitho)
        {
            SetResponse response = await client.SetAsync("info/nguoitho/" + GlobalVariables.id, nguoitho);
        }

        public async Task<NguoiTho> GetInfoNguoiTho(string id)
        {
            FirebaseResponse response = await client.GetAsync("info/nguoitho/" + id);
            NguoiTho nguoitho = response.ResultAs<NguoiTho>();
            return nguoitho;
        }

        public async Task<List<NguoiTho>> GetAllNguoiTho()
        {
            FirebaseResponse response = await client.GetAsync("info/nguoitho/");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var allNguoiTho = response.ResultAs<Dictionary<string, NguoiTho>>();
                List<NguoiTho> listNguoiTho = allNguoiTho.Values.ToList();

                return listNguoiTho;
            }
            else
            {
                Console.WriteLine("Không thể lấy dữ liệu: " + response.StatusCode);
                return new List<NguoiTho>();
            }
        }

        public async Task<string> PostArticle(Post post)
        {
            FirebaseResponse response = await client.GetAsync("numPost/timtho");
            int postCount = response.ResultAs<int>();
            postCount++;

            SetResponse setResponse = await client.SetAsync("numPost/timtho", postCount);
            if (setResponse.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("Failed to increment post count.");
                return null;
            }

            post.Id = postCount.ToString();
            SetResponse postResponse = await client.SetAsync("post/timtho/" + "p" + post.Id + "/", post);
            if (postResponse.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("Failed to post article.");
                return null;
            }

            return post.Id;
        }


        public async Task<List<Post>> GetAllPosts()
        {
            FirebaseResponse response = await client.GetAsync("post/timtho/");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var allPosts = response.ResultAs<Dictionary<string, Post>>();
                List<Post> listPosts = allPosts.Values.ToList();

                return listPosts;
            }
            else
            {
                Console.WriteLine("Không thể lấy dữ liệu: " + response.StatusCode);
                return new List<Post>();
            }
        }

        public async Task AddPostToDonePost(string postId)
        {

            FirebaseResponse response = await client.GetAsync("info/nguoitho/" + GlobalVariables.id + "/DonePostIds");
            var donePost = response.ResultAs<string>();


            if (!donePost.Contains(postId))
            {
                if (donePost == "")
                {
                    donePost += postId;
                }
                else
                {
                    donePost += "," + postId;
                }
                SetResponse setResponse = await client.SetAsync("info/nguoitho/" + GlobalVariables.id + "/DonePostIds", donePost);
                if (setResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine("ID người dùng đã được thêm vào danh sách yêu thích.");
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi thêm ID người dùng.");
                }
            }
            else
            {
                Console.WriteLine("ID người dùng đã tồn tại trong danh sách yêu thích.");
            }
        }

        public async Task AddPostToPosted(string postId)
        {
            FirebaseResponse response = await client.GetAsync("info/nguoitimtho/" + GlobalVariables.id + "/PostIds");
            var Posted = response.ResultAs<string>();
            string[] postedArray = Posted?.Split(',') ?? new string[0];

            if (!postedArray.Contains(postId))
            {
                Posted = String.IsNullOrEmpty(Posted) ? postId : Posted + "," + postId;

                SetResponse setResponse = await client.SetAsync("info/nguoitimtho/" + GlobalVariables.id + "/PostIds", Posted);
                if (setResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine("ID người dùng đã được thêm vào danh sách yêu thích.");
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi thêm ID người dùng.");
                }
            }
            else
            {
                Console.WriteLine("ID người dùng đã tồn tại trong danh sách yêu thích.");
            }
        }


        public async Task UpReview(Review review, string idnguoitho) 
        {
            SetResponse response = await client.SetAsync("review/" + idnguoitho + "/" + GlobalVariables.id, review);
        }

        public async Task UpdateRate(string nguoithoid, float rate)
        {
            SetResponse response = await client.SetAsync("info/nguoitho/" + nguoithoid + "/rate", rate);
        }

        public async Task<List<Review>> GetAllReview(string nguoithoid)
        {
            FirebaseResponse response = await client.GetAsync("review/" + nguoithoid + "/");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var allReview = response.ResultAs<Dictionary<string, Review>>();
                if (allReview == null)
                {
                    return null;
                }
                List<Review> listReview = allReview.Values.ToList();

                return listReview;
            }
            else
            {
                Console.WriteLine("Không thể lấy dữ liệu: " + response.StatusCode);
                return new List<Review>();
            }
        }

        public async void SendMessage(string roomId, string tinnhan)
        {
            FirebaseResponse response = await client.GetAsync("message/" + roomId + "/" + "count");
            int count = response.Body == "null" ? 0 : response.ResultAs<int>();
            count++;
            SetResponse setResponse = await client.SetAsync("message/" + roomId + "/" + "count", count);
            SetResponse Messresponse = await client.SetAsync("message/" + roomId + "/" + count, tinnhan);
        }


        public async Task<List<string>> GetAllMessagesAsync(string roomId)
        {
            FirebaseResponse response = await client.GetAsync("message/" + "idroom");
            Dictionary<string, string> messages = response.ResultAs<Dictionary<string, string>>();
            List<string> messageList = new List<string>();

            foreach (var message in messages)
            {
                messageList.Add(message.Value);
            }

            return messageList;
        }

        public string LatestMessage { get; private set; }

        public async void ListenForNewMessages(string roomId)
        {
            EventStreamResponse response = await client.OnAsync("message/" + roomId + "/",
                added: (sender, args, context) =>
                {
                    OnMessageReceived?.Invoke(args.Data);
                });
        }

        public async Task AddtoContact(string id)
        {
            FirebaseResponse response = await client.GetAsync("contactlist/" + GlobalVariables.id);
            var contact = response.ResultAs<string>();
            string[] contactsArray = contact?.Split(',') ?? new string[0];

            if (!contactsArray.Contains(id))
            {
                contact = contact == null || contact == "" ? id : contact + "," + id;

                SetResponse setResponse = await client.SetAsync("contactlist/" + GlobalVariables.id, contact);
                if (setResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra");
                }

                response = await client.GetAsync("contactlist/" + id);
                var reverseContact = response.ResultAs<string>();
                string[] reverseContactsArray = reverseContact?.Split(',') ?? new string[0];

                if (!reverseContactsArray.Contains(GlobalVariables.id))
                {
                    reverseContact = reverseContact == null || reverseContact == "" ? GlobalVariables.id : reverseContact + "," + GlobalVariables.id;
                    SetResponse reverseSetResponse = await client.SetAsync("contactlist/" + id, reverseContact);
                    if (reverseSetResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        Console.WriteLine("OK - GlobalVariables.id đã được thêm vào danh sách liên lạc của ID.");
                    }
                    else
                    {
                        Console.WriteLine("Có lỗi xảy ra khi thêm GlobalVariables.id vào danh sách liên lạc của ID.");
                    }
                }
                else
                {
                    Console.WriteLine("GlobalVariables.id đã tồn tại trong danh sách liên lạc của ID.");
                }
            }
            else
            {
                Console.WriteLine("ID đã tồn tại trong danh sách liên lạc.");
            }
        }



        public async Task<string> GetContactList(string userId)
        {
            FirebaseResponse response = await client.GetAsync("contactlist/" + userId);
            string contactList = response.ResultAs<string>();

            if (contactList != null)
            {
                return contactList;
            }
            else
            {
                return "";
            }
        }

        public async Task ApplyForJob(string jobId, string workerId)
        {
            FirebaseResponse response = await client.GetAsync("jobs/" + jobId + "/applicants");
            var applicants = response.ResultAs<string>();

            if (applicants == null || !applicants.Contains(workerId))
            {
                applicants = applicants == null || applicants == "" ? workerId : applicants + "," + workerId;
                SetResponse setResponse = await client.SetAsync("jobs/" + jobId + "/applicants", applicants);

                if (setResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine("Người thợ đã được thêm vào danh sách ứng viên.");
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi thêm người thợ vào danh sách ứng viên.");
                }
            }
            else
            {
                Console.WriteLine("Người thợ đã tồn tại trong danh sách ứng viên.");
            }
        }

        public async Task NotifyWorker(string workerId, string message)
        {
            PushResponse pushResponse = await client.PushAsync("notifications/" + workerId, message);

            if (pushResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //Console.WriteLine("Thông báo đã được gửi.");
            }
            else
            {
                Console.WriteLine("Có lỗi xảy ra khi gửi thông báo.");
            }
        }

        //public string LatestNotify { get; private set; }

        public async void ListenForNewNotify(string workerId)
        {
            EventStreamResponse response = await client.OnAsync("notifications/" + workerId + "/",
                added: (sender, args, context) =>
                {
                    //Console.WriteLine("New notification received: " + args.Data);
                    OnNotificationReceived?.Invoke(args.Data);
                });
        }

        //
        public async Task ApplyforJob(string id_job, string nt_id, string ntt_id)
        {
            SetResponse setResponse = await client.SetAsync($"nt_notify/{nt_id}/{id_job}", $"WAIT-"+$"{id_job}");
            if (setResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("Người thợ đã được thêm vào danh sách ứng viên.");
            }
            else
            {
                Console.WriteLine("Có lỗi xảy ra khi thêm người thợ vào danh sách ứng viên.");
            }

            FirebaseResponse response = await client.GetAsync($"ntt_notify/{ntt_id}/{id_job}/");
            var waitlist = response.ResultAs<string>();
            string[] partss = waitlist.Split('-');
            if (partss[1] == "COMPLETE")
            {
                return;
            }

            if (waitlist == null)
            {
                waitlist = $"{id_job}-{nt_id}";
                SetResponse resetResponse = await client.SetAsync($"ntt_notify/{ntt_id}/{id_job}/", waitlist);
                if (resetResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine("Danh sách ứng viên đã được khởi tạo.");
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi khởi tạo danh sách ứng viên.");
                }
            }
            else
            {
                string[] parts = waitlist.Split('-');
                string[] users = parts[1].Split(',');

                // Kiểm tra xem my_id có trong danh sách người dùng không
                bool containsMyId = false;
                foreach (string user in users)
                {
                    if (user == nt_id)
                    {
                        containsMyId = true;
                        break;
                    }
                }

                if (!containsMyId)
                {
                    waitlist += $",{nt_id}";
                    SetResponse resetResponse = await client.SetAsync($"ntt_notify/{ntt_id}/{id_job}/", waitlist);
                }

            }
        }

        public async Task AcceptWorker(string id_job, string nt_id, string ntt_id) //người tìm thợ
        {
            SetResponse setResponse = await client.SetAsync($"nt_notify/{nt_id}/{id_job}", $"ACCEPT-{id_job}");
            FirebaseResponse response = await client.DeleteAsync($"ntt_notify/{ntt_id}/{id_job}");
        }

        public async Task CompleteJob(string id_job, string nt_id, string ntt_id) //người thợ
        {
            SetResponse setResponse = await client.SetAsync($"ntt_notify/{ntt_id}/{id_job}", $"{id_job}-COMPLETE-{nt_id}");
            FirebaseResponse response = await client.DeleteAsync($"nt_notify/{nt_id}/{id_job}");
        }

        public async Task<List<string>> GetAllWaitJob()
        {
            FirebaseResponse response = await client.GetAsync("nt_notify/" + GlobalVariables.id);
            Dictionary<string, string> job = response.ResultAs<Dictionary<string, string>>();
            List<string> jobList = new List<string>();

            if(job == null)
            {
                return null;
            }

            foreach (var j in job)
            {
                jobList.Add(j.Value);
            }

            return jobList;
        }

        public async Task<List<string>> GetAllApply()
        {
            FirebaseResponse response = await client.GetAsync("ntt_notify/" + GlobalVariables.id);
            Dictionary<string, string> job = response.ResultAs<Dictionary<string, string>>();
            if (job == null)
            {
                return null;
            }
            List<string> jobList = new List<string>();

            foreach (var j in job)
            {
                jobList.Add(j.Value);
            }

            return jobList;
        }
    }
}
