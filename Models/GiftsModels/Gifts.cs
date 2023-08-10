namespace OpenVkNetApi.Models.GiftsModels
{
    public class UserGift
    {
        public int id { get; set; }
        public int from_id { get; set; }
        public string message { get; set; }
        public int date { get; set; }
        public SendedGift gift { get; set; }
        public int privacy { get; set; }
    }

    public class SendedGift
    {
        public int id { get; set; }
        public string thumb_256 { get; set; }
        public string thumb_96 { get; set; }
        public string thumb_48 { get; set; }
    }

    public class GiftCategory
    {
        public string name { get; set; }
        public string description { get; set; }
        public int id { get; set; }
        public string thumbnail { get; set; }
    }

    public class SendResponse
    {
        public int success { get; set; }
        public int user_ids { get; set; }
        public int withdraw_votes { get; set; }
    }

    public class Gift
    {
        public string name { get; set; }
        public string image { get; set; }
        public int usages_left { get; set; }
        public int price { get; set; }
        public bool is_free { get; set; }
    }
}
