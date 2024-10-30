using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.Models
{
    public class Skill
    {
        public int SkillID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProficiencyLevel { get; set; } // Thêm thuộc tính ProficiencyLevel

        // Hàm khởi tạo không tham số
        public Skill() { }

        // Hàm khởi tạo với tham số
        public Skill(int skillId, string name, string description, string proficiencyLevel)
        {
            SkillID = skillId;
            Name = name;
            Description = description;
            ProficiencyLevel = proficiencyLevel;
        }
    }


}
