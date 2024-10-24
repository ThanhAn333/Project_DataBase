using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public User Sender { get; set; }
        public User Receiver { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }

        public Message(int messageId, User sender, User receiver, string content, DateTime timestamp)
        {
            MessageID = messageId;
            Sender = sender;
            Receiver = receiver;
            Content = content;
            Timestamp = timestamp;
        }

        public override string ToString()
        {
            return $"Message from {Sender.Name} to {Receiver.Name} at {Timestamp}: {Content}";
        }
    }

}
