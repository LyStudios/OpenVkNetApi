namespace OpenVkNetApi.Models.Account
{
    public class CountersModel
    {
        public CountersResponse response;
    }
    public class CountersResponse
    {
        public int friends { get; set; }
        public int notifications { get; set; }
        public int messages { get; set; }
    }
}
