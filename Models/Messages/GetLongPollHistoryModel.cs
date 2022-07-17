using System.Collections.Generic;

namespace OpenVkNetApi.Models.Messages
{
    public class GetLongPollHistoryModel
    {
        public GetLongPollHistoryResponse response { get; set; }
    }
    public class Messages
    {
        public int count { get; set; }
        public List<object> items { get; set; }
    }

    public class GetLongPollHistoryResponse
    {
        public List<object> history { get; set; }
        public Messages messages { get; set; }
        public List<object> profiles { get; set; }
        public int new_pts { get; set; }
    }
}
