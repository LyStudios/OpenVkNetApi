using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Photos
{
    /// <summary>
    /// Represents a tag on a photo.
    /// </summary>
    public class PhotoTag
    {
        /// <summary>
        /// Tag identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Tagged user identifier.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// Identifier of the user who added the tag.
        /// </summary>
        [JsonProperty("placer_id")]
        public int PlacerId { get; set; }

        /// <summary>
        /// Tagged user name or description if not a user profile.
        /// </summary>
        [JsonProperty("tagged_name")]
        public string TaggedName { get; set; }

        /// <summary>
        /// Date when the tag was created as Unix timestamp.
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        /// <summary>
        /// Left coordinate in percentage (0.0 to 100.0).
        /// </summary>
        [JsonProperty("x")]
        public double X { get; set; }

        /// <summary>
        /// Top coordinate in percentage (0.0 to 100.0).
        /// </summary>
        [JsonProperty("y")]
        public double Y { get; set; }

        /// <summary>
        /// Right coordinate in percentage (0.0 to 100.0).
        /// </summary>
        [JsonProperty("x2")]
        public double X2 { get; set; }

        /// <summary>
        /// Bottom coordinate in percentage (0.0 to 100.0).
        /// </summary>
        [JsonProperty("y2")]
        public double Y2 { get; set; }

        /// <summary>
        /// Whether the tag is confirmed (1 or 0).
        /// </summary>
        [JsonProperty("viewed")]
        public int Viewed { get; set; }
    }
}
