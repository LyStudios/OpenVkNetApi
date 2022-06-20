namespace OpenVkNetApi.Models.Account
{
    public class InfoModel
    {
        public InfoResponse response { get; set; }
    }
    public class InfoResponse
    {
        public int _2fa_required { get; set; }
        public string country { get; set; }
        public bool eu_user { get; set; }
        public int https_required { get; set; }
        public int intro { get; set; }
        public bool community_comments { get; set; }
        public bool is_live_streaming_enabled { get; set; }
        public bool is_new_live_streaming_enabled { get; set; }
        public int lang { get; set; }
        public int no_wall_replies { get; set; }
        public int own_posts_default { get; set; }
    }
}
