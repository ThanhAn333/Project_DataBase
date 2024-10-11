using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.DAO
{
    public class Message
    {
        public int MessageID { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }

        public Message(int messageID, int senderID, int receiverID, string content, DateTime timestamp)
        {
            MessageID = messageID;
            SenderID = senderID;
            ReceiverID = receiverID;
            Content = content;
            Timestamp = timestamp;
        }
    }

}
