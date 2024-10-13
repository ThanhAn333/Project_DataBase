using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.DAO
{
    public class Application
    {
        public int ApplicationID { get; set; }
        public User Applicant { get; set; }
        public Job AppliedJob { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string Status { get; set; }

        public Application(int applicationId, User applicant, Job appliedJob, string status, DateTime applicationDate)
        {
            ApplicationID = applicationId;
            Applicant = applicant;
            AppliedJob = appliedJob;
            ApplicationDate = applicationDate;
            Status = status;
        }


        public override string ToString()
        {
            return $"{Applicant.Name} applied for {AppliedJob.Title} on {ApplicationDate.ToShortDateString()}";
        }
    }

}
