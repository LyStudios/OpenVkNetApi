using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Attachments
{
    public class Likes
    {
        [JsonProperty("count")]
        public int? Count { get; set; }

        [JsonProperty("user_likes")]
        public bool? UserLikes { get; set; }
    }
}
