using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public User Reviewer { get; set; }
        public Job Job { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }

        public Review(int reviewId, User reviewer, Job job, int rating, string comment, DateTime reviewDate)
        {
            ReviewID = reviewId;
            Reviewer = reviewer;
            Job = job;
            Rating = rating;
            Comment = comment;
            ReviewDate = reviewDate;
        }

        public override string ToString()
        {
            return $"{Reviewer.Name} rated job {Job.Title} with {Rating} stars";
        }
    }

}
