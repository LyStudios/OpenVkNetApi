using System.Collections.Generic;

namespace OpenVkNetApi.Models.Messages
{
    public class GetHistoryModel
    {
        public GetHistoryResponse response { get; set; }
    }

    public class GetHistoryResponse
    {
        public int count { get; set; }
        public List<Message> items { get; set; }
    }
}
