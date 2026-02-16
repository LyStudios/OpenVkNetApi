using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Attachments
{
    public class Reposts
    {
        [JsonProperty("count")]
        public int? Count { get; set; }

        [JsonProperty("user_reposted")]
        public int? UserReposted { get; set; }
    }
}
