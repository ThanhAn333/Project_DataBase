using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.DAO
{
    public class Job
    {
        public int JobID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
<<<<<<< HEAD
        public string Salary {  get; set; }
=======
        public string Request {  get; set; }
        public string Salar { get; set; }
>>>>>>> 0379e35c084d72d3aa2339b8b6895009dab600ef
        public string Type { get; set; }
        public string Company { get; set; }
        public DateTime PostedDate { get; set; }
        public string Status { get; set; }

<<<<<<< HEAD
        public Job(int jobID, string title, string description, string location, string salary, string type, string company, DateTime postedDate, string status)
=======
        public Job(){

            }

        public Job(int jobID, string title, string description, string location,string request, string salar, string type, string company, DateTime postedDate, string status)
>>>>>>> 0379e35c084d72d3aa2339b8b6895009dab600ef
        {
            JobID = jobID;
            Title = title;
            Description = description;
            Location = location;
<<<<<<< HEAD
            Salary = salary;
=======
            Request = request;
            Salar = salar;
>>>>>>> 0379e35c084d72d3aa2339b8b6895009dab600ef
            Type = type;
            Company = company;
            PostedDate = postedDate;
            Status = status;
        }

        public override string ToString()
        {
            return $"{Title} - {Location} ({Status})";
        }
    }


}
