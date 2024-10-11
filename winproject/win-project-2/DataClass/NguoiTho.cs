using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2
{
    public class NguoiTho : UserInfo
    {
        public string JobName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Skills { get; set; }
        public string JobLocation { get; set; }
        public string Study { get; set; }
        public float rate { get; set; }
        public string DonePostIds { get; set; }

        // Constructor với tất cả các thuộc tính, kể cả thuộc tính từ lớp cơ sở UserInfo
        public NguoiTho(string donePostIds, string name, string dateOfBirth, string phoneNumber, string avatarUrl, string email, string address, bool isTho, string id, string jobName, string description, double price, string skills, string jobLocation, string study, float rate)
            : base(name, dateOfBirth, phoneNumber, avatarUrl, email, address, isTho, id)
        {
            JobName = jobName;
            Description = description;
            Price = price;
            Skills = skills;
            JobLocation = jobLocation;
            Study = study;
            DonePostIds = donePostIds ?? string.Empty;
            this.rate = rate;
        }

        // Constructor mặc định
        public NguoiTho() : base()
        {
            DonePostIds = string.Empty;
        }
    }


}
