using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.DAO
{
    public class Skill
    {
        public int SkillID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Skill(int skillId, string name, string description)
        {
            SkillID = skillId;
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }

}
