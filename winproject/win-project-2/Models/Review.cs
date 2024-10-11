using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.DAO
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int UserID { get; set; }
        public int JobID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }

        public Review(int reviewID, int userID, int jobID, int rating, string comment, DateTime reviewDate)
        {
            ReviewID = reviewID;
            UserID = userID;
            JobID = jobID;
            Rating = rating;
            Comment = comment;
            ReviewDate = reviewDate;
        }
    }

}
