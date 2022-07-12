using System.Collections.Generic;

namespace OpenVkNetApi.Models.Messages
{
    public class GetConversationsModel
    {
        public GetConversationsResponse response { get; set; }
    }
    public class CanWrite
    {
        public bool allowed { get; set; }
    }

    public class Conversation
    {
        public Peer peer { get; set; }
        public int last_message_id { get; set; }
        public int in_read { get; set; }
        public int out_read { get; set; }
        public bool is_marked_unread { get; set; }
        public bool important { get; set; }
        public CanWrite can_write { get; set; }
    }

    public class GetConversationItem
    {
        public Conversation conversation { get; set; }
        public Message last_message { get; set; }
    }

    public class Peer
    {
        public int id { get; set; }
        public string type { get; set; }
        public int local_id { get; set; }
    }

    public class GetConversationsResponse
    {
        public int count { get; set; }
        public List<GetConversationItem> items { get; set; }
    }
}
