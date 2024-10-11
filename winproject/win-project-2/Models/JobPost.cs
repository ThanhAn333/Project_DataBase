using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.DAO
{
    public class JobPost
    {
        public int JobPostID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime PostedDate { get; set; }
        public string Status { get; set; }

        public JobPost(int jobPostID, int userID, string title, string description, string location, DateTime postedDate, string status)
        {
            JobPostID = jobPostID;
            UserID = userID;
            Title = title;
            Description = description;
            Location = location;
            PostedDate = postedDate;
            Status = status;
        }
    }

}
