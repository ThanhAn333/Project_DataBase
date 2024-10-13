using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.DAO
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } 

        public User(int userId, string name, string email, string password, string role)
        {
            UserID = userId;
            Name = name;
            Email = email;
            Password = password;
            Role = role;
        }

        public override string ToString()
        {
            return $"{Name} ({Role})";
        }
    }
}
