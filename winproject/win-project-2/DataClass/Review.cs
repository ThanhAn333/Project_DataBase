using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.DataClass
{
    public class Review
    {
        public string NguoiThoId { get; set; }
        public string NguoiTimThoId { get; set; }
        public float Rating { get; set; }
        public string Comment { get; set; }
        public string ImgUrl { get; set; }

        public Review(string nguoithoid, string nguoitimthoid, float rating, string comment, string imgurl)
        {
            NguoiThoId = nguoithoid;
            NguoiTimThoId = nguoitimthoid;
            Rating = rating;
            Comment = comment;
            ImgUrl = imgurl;
        }
    }

}
