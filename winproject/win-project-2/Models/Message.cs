using System;

public class Message
{
    public int MessageID { get; set; }
    public int SenderID { get; set; }
    public int ReceiverID { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }

    public Message(int messageId, int sender, int receiver, string content, DateTime timestamp)
    {
        MessageID = messageId;
        SenderID = sender;
        ReceiverID = receiver;
        Content = content;
        Timestamp = timestamp;
    }

    public override string ToString()
    {
        return $"Message from {SenderID} to {ReceiverID} at {Timestamp}: {Content}";
    }
}
