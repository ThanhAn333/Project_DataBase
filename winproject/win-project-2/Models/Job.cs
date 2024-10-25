using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.Models
{
    public class Job
    {
        public int JobID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string SkillRequire {  get; set; }
        public DateTime PostedDate { get; set; }
        public string Salary { get; set; }
        public string Type { get; set; }
        public string Company { get; set; }
        public string Status { get; set; }
        public int Employer { get; set; }


        public Job(){

            }

        public Job(int jobID, string title, string description, string location,string skillRequire, string salary, string type, string company, DateTime postedDate, string status, int employer)
        {
            JobID = jobID;
            Title = title;
            Description = description;
            Location = location;
            SkillRequire = skillRequire;
            Salary = salary;
            Type = type;
            Company = company;
            PostedDate = postedDate;
            Status = status;
            Employer = employer;
        }

        public override string ToString()
        {
            return $"{Title} - {Location} ({Status})";
        }
    }


}
