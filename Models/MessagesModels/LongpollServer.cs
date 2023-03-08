namespace OpenVkNetApi.Models.MessagesModels
{
    public class LongpollServer
    {
        public string key { get; set; }
        public string server { get; set; }
        public int ts { get; set; }
        public int pts { get; set; }
    }
}
