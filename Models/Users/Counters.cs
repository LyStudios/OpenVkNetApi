using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Users
{
    /// <summary>
    /// Represents various counters for a user.
    /// </summary>
    public class Counters
    {
        /// <summary>
        /// Number of friends.
        /// </summary>
        [JsonProperty("friends")]
        public int? Friends { get; set; }
        /// <summary>
        /// Number of photos.
        /// </summary>
        [JsonProperty("photos")]
        public int? Photos { get; set; }
        /// <summary>
        /// Number of videos.
        /// </summary>
        [JsonProperty("videos")]
        public int? Videos { get; set; }
        /// <summary>
        /// Number of audios.
        /// </summary>
        [JsonProperty("audios")]
        public int? Audios { get; set; }
        /// <summary>
        /// Number of notes.
        /// </summary>
        [JsonProperty("notes")]
        public int? Notes { get; set; }
        /// <summary>
        /// Number of groups.
        /// </summary>
        [JsonProperty("groups")]
        public int? Groups { get; set; }

        /// <summary>
        /// Number of online friends.
        /// </summary>
        [JsonProperty("online_friends")]
        public int? OnlineFriends { get; set; }
    }
}
