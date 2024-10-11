using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2
{
    public class Mess
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Content { get; set; }

        // Constructor không tham số
        public Mess() { }

        // Constructor có tham số
        public Mess(string sender, string receiver, string content)
        {
            Sender = sender;
            Receiver = receiver;
            Content = content;
        }
    }
}
