using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } 

        public string Address {  get; set; }
        public DateTime birthDate { get; set; }
        public string PhoneNumber {  get; set; }
        public string image {  get; set; }
        public DateTime createDate {  get; set; }
        public DateTime updateDate { get; set; }

        public User(int userID, string name, string email, string password, string role, string address, DateTime birthDate, string phoneNumber, string image, DateTime createDate, DateTime updateDate)
        {
            UserID = userID;
            Name = name;
            Email = email;
            Password = password;
            Role = role;
            Address = address;
            this.birthDate = birthDate;
            PhoneNumber = phoneNumber;
            this.image = image;
            this.createDate = createDate;
            this.updateDate = updateDate;
        }

        public override string ToString()
        {
            return $"{Name} ({Role})";
        }
    }
}
