using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.DataClass
{
    
        public class NguoiTimTho : UserInfo
        {
            public string FavThoIds { get; set; }
            public string PostIds { get; set; }

            public NguoiTimTho(string favThoIds, string postIds, string name, string dateOfBirth, string phoneNumber, string avatarUrl, string email, string address, Boolean istho, String id)
                : base(name, dateOfBirth, phoneNumber, avatarUrl, email, address, istho, id)
            {
                FavThoIds = favThoIds ?? string.Empty;
                PostIds = postIds ?? string.Empty;
            }

            public NguoiTimTho() : base()
            {
                FavThoIds = string.Empty;
                PostIds = string.Empty;
            }
        }

    
}
