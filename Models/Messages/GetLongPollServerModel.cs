namespace OpenVkNetApi.Models.Messages
{
    public class GetLongPollServerModel
    {
        public GetLongPollServerResponse response { get; set; }
    }
    public class GetLongPollServerResponse
    {
        public string key { get; set; }
        public string server { get; set; }
        public int ts { get; set; }
        public int pts { get; set; }
    }
}
