namespace OpenVkNetApi.Models.AccountModels
{
    public class Info
    {
        public int _2fa_required { get; set; }
        public string Country { get; set; }
        public bool Eu_User { get; set; }
        public int Https_Required { get; set; }
        public int Intro { get; set; }
        public bool Community_Comments { get; set; }
        public bool Is_Live_Streaming_Enabled { get; set; }
        public bool Is_New_Live_Streaming_Enabled { get; set; }
        public int Lang { get; set; }
        public int No_Wall_Replies { get; set; }
        public int Own_Posts_Default { get; set; }
    }
}
