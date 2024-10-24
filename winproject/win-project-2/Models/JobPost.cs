using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.Models
{
    public class JobPost
    {
        public int JobPostID { get; set; }
        public User Recruiter { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime PostedDate { get; set; }
        public string Status { get; set; } 

        public JobPost(int jobPostId, User recruiter, string title, string description, string location, string status, DateTime postedDate)
        {
            JobPostID = jobPostId;
            Recruiter = recruiter;
            Title = title;
            Description = description;
            Location = location;
            PostedDate = postedDate;
            Status = status;
        }
    }


}
