namespace OpenVkNetApi.Models.MessagesModels
{
    public class Message
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int From_Id { get; set; }
        public int Date { get; set; }
        public int Read_State { get; set; }
        public int Out { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Text { get; set; }
        public object[] Attachments { get; set; }
        public object[] Fwd_Messages { get; set; }
        public bool Emoji { get; set; }
        public bool Important { get; set; }
        public int Deleted { get; set; }
        public object Random_Id { get; set; }
    }

    public class MessageList
    {
        public int Count { get; set; }
        public Message[] Items { get; set; }
    }
}
