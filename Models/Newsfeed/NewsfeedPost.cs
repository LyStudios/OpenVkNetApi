using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Newsfeed
{
    /// <summary>
    /// Represents a post in the newsfeed.
    /// </summary>
    public class NewsfeedPost
    {
        /// <summary>
        /// The post ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The ID of the post's owner.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// The ID of the author of the post.
        /// </summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }

        /// <summary>
        /// The date when the post was published, in Unix time.
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        /// <summary>
        /// The text content of the post.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; set; }
    }
}
