namespace OpenVkNetApi.Models.OVKSpecific
{
    public class TestModel
    {
        public TestResponse response { get; set; }
    }
    public class TestResponse
    {
        public bool authorized { get; set; }
        public string auth_with { get; set; }
        public string version { get; set; }
    }
}
