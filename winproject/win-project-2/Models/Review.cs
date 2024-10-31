using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.Models
{
    public class Review
    {
        public int UserID { get; set; }
        public int JobID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }

        public Review(int userID, int jobID, int rating, string comment, DateTime reviewDate)
        {
            UserID = userID;
            JobID = jobID;
            Rating = rating;
            Comment = comment;
            ReviewDate = reviewDate;
        }
    }
}
