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
        public int UserID { get; set; }
        public int JobID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string Status { get; set; }

        public Application(int applicationID, int userID, int jobID, DateTime applicationDate, string status)
        {
            ApplicationID = applicationID;
            UserID = userID;
            JobID = jobID;
            ApplicationDate = applicationDate;
            Status = status;
        }
    }

}
