namespace OpenVkNetApi.Models.MessagesModels
{
    public class ConversationsList
    {
        public int Count { get; set; }
        public Item[] Items { get; set; }
    }

    public class Item
    {
        public Conversation Conversation { get; set; }
        public Message Last_Message { get; set; }
    }

    public class Conversation
    {
        public Peer Peer { get; set; }
        public int Last_Message_Id { get; set; }
        public int In_Read { get; set; }
        public int Out_Read { get; set; }
        public bool Is_Marked_Unread { get; set; }
        public bool Important { get; set; }
        public Can_Write Can_Write { get; set; }
    }

    public class Peer
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Local_Id { get; set; }
    }

    public class Can_Write
    {
        public bool Allowed { get; set; }
    }

    public class ConversationsByIdList
    {
        public int Count { get; set; }
        public ConversationById[] Items { get; set; }
    }

    public class ConversationById
    {
        public Peer Peer { get; set; }
        public int Last_Message_Id { get; set; }
        public int In_Read { get; set; }
        public int Out_Read { get; set; }
        public Sort_Id Sort_Id { get; set; }
        public int Last_Conversation_Message_Id { get; set; }
        public int In_Read_Cmid { get; set; }
        public int Out_Read_Cmid { get; set; }
        public bool Is_Marked_Unread { get; set; }
        public bool Important { get; set; }
        public Can_Write Can_Write { get; set; }
    }

    public class Sort_Id
    {
        public int major_id { get; set; }
        public int minor_id { get; set; }
    }
}
