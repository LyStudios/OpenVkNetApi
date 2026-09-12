using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Places
{
    /// <summary>
    /// Represents a check-in object in the OpenVK API.
    /// </summary>
    public class Checkin
    {
        /// <summary>
        /// Gets or sets the check-in ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the user ID who checked in.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of the check-in.
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or sets the place ID.
        /// </summary>
        [JsonProperty("place_id")]
        public int PlaceId { get; set; }

        /// <summary>
        /// Gets or sets the check-in text.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
