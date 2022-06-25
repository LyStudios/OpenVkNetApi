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
        public LastMessage last_message { get; set; }
    }

    public class LastMessage
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int from_id { get; set; }
        public int date { get; set; }
        public int read_state { get; set; }
        public int @out { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public string text { get; set; }
        public List<object> attachments { get; set; }
        public List<object> fwd_messages { get; set; }
        public bool emoji { get; set; }
        public bool important { get; set; }
        public int deleted { get; set; }
        public object random_id { get; set; }
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
