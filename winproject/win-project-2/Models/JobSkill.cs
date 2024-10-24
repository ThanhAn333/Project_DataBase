using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.Models
{
    public class JobSkill
    {
        public int JobSkillID { get; set; }
        public Job Job { get; set; }
        public Skill Skill { get; set; }

        public JobSkill(int jobSkillId, Job job, Skill skill)
        {
            JobSkillID = jobSkillId;
            Job = job;
            Skill = skill;
        }

        public override string ToString()
        {
            return $"Skill {Skill.Name} required for job {Job.Title}";
        }
    }

}
