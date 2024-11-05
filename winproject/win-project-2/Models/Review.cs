using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.Models
{
    public class Review
    {
        private int reviewid;
        public int ReviewId { get; set; }
        public int CandidateID { get; set; }
        public int EmployerID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }

        public Review(int candidateid, int employerid, int rating, string comment, DateTime reviewDate)
        {
            ReviewId = reviewid;
            CandidateID = candidateid;
            EmployerID = employerid;
            Rating = rating;
            Comment = comment;
            ReviewDate = reviewDate;
        }
    }
}
