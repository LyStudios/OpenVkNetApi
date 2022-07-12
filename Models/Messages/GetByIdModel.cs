using System.Collections.Generic;

namespace OpenVkNetApi.Models.Messages
{
    public class GetByIdModel
    {
        public MessagesGetByIdResponse response { get; set; }
    }

    public class MessagesGetByIdResponse
    {
        public int count { get; set; }
        public List<Message> items { get; set; }
    }
}
