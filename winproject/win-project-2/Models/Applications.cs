using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.Models
{
    public class Applications
    {
        public int ApplicationID { get; set; }
        public User Applicant { get; set; }
        public Job AppliedJob { get; set; }

        public string Title {  get; set; }
        public DateTime ApplicationDate { get; set; }
        public string Status { get; set; }

        public Applications()
        {

        }
        public Applications(int applicationId, User applicant, Job appliedJob,string title, string status, DateTime applicationDate)
        {
            ApplicationID = applicationId;
            Applicant = applicant;
            AppliedJob = appliedJob;
            Title = title;
            ApplicationDate = applicationDate;
            Status = status;
        }


        public override string ToString()
        {
            return $"{Applicant.Name} applied for {AppliedJob.Title} on {ApplicationDate.ToShortDateString()}";
        }
    }

}
