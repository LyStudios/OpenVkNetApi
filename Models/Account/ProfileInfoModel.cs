namespace OpenVkNetApi.Models.Account
{
    public class ProfileInfoModel
    {
        public PIResponse response { get; set; }
    }
    public class PIResponse
    {
        public string first_name { get; set; }
        public int id { get; set; }
        public string last_name { get; set; }
        public string home_town { get; set; }
        public string status { get; set; }
        public string bdate { get; set; }
        public int bdate_visibility { get; set; }
        public string phone { get; set; }
        public int relation { get; set; }
        public int sex { get; set; }
    }
}
