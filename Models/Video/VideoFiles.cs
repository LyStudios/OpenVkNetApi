using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Video
{
    public class VideoFiles
    {
        [JsonProperty("mp4_480")]
        public string? Mp4480 { get; set; }
    }
}
