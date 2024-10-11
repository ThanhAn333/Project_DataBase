using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2
{
    public class UserInfo
    {
        public string Name { get; set; }

        public string DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string AvatarUrl { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Boolean IsTho {  get; set; }
        public String Id { get; set; }


        public UserInfo() { }
        public UserInfo(string name, string dateOfBirth, string phoneNumber, string avatarUrl, string email, string address, Boolean istho, String id)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            AvatarUrl = avatarUrl;
            Email = email;
            Address = address;
            IsTho = istho;
            Id = id;
        }   
    }

}
