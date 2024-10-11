using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.DAO
{
    public class JobSkill
    {
        public int JobSkillID { get; set; }
        public int JobID { get; set; }
        public int SkillID { get; set; }

        public JobSkill(int jobSkillID, int jobID, int skillID)
        {
            JobSkillID = jobSkillID;
            JobID = jobID;
            SkillID = skillID;
        }
    }

}
