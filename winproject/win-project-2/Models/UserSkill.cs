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
        public User User { get; set; }
        public Skill Skill { get; set; }
        public string ProficiencyLevel { get; set; }

        public UserSkill(int userSkillId, User user, Skill skill, string proficiencyLevel)
        {
            UserSkillID = userSkillId;
            User = user;
            Skill = skill;
            ProficiencyLevel = proficiencyLevel;
        }

        public override string ToString()
        {
            return $"{User.Name} has {ProficiencyLevel} proficiency in {Skill.Name}";
        }
    }

}
