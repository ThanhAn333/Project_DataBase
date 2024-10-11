using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.DAO
{
    public class UserSkill
    {
        public int UserSkillID { get; set; }
        public int UserID { get; set; }
        public int SkillID { get; set; }
        public int ProficiencyLevel { get; set; }

        public UserSkill(int userSkillID, int userID, int skillID, int proficiencyLevel)
        {
            UserSkillID = userSkillID;
            UserID = userID;
            SkillID = skillID;
            ProficiencyLevel = proficiencyLevel;
        }
    }

}
