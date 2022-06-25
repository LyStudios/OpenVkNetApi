using System.Collections.Generic;

namespace OpenVkNetApi.Models.Messages
{
    public class GetByIdModel
    {
        public MessagesGetByIdResponse response { get; set; }
    }
    public class GetByIdItem
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

    public class MessagesGetByIdResponse
    {
        public int count { get; set; }
        public List<GetByIdItem> items { get; set; }
    }
}
