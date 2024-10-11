using System.Net.Http.Headers;

namespace win_project_2
{
    public class Post
    {
        public string Id { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Date { get; set; }
        public string Request { get; set; }
        public string Price { get; set; }
        public string SenderId { get; set; }

        public Post() { }
        public Post(string id, string tag, string description, string location, string date, string request, string price, string senderid)
        {
            Id = id;
            Tag = tag;
            Description = description;
            Location = location;
            Date = date;
            Request = request;
            Price = price;
            SenderId = senderid;
        }
    }
}