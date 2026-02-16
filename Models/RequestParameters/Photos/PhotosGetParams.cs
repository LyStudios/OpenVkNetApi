using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Photos
{
    /// <summary>
    /// Parameters for the photos.get method.
    /// </summary>
    public class PhotosGetParams
    {
        /// <summary>
        /// ID of the user or community that owns the photos.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// Album ID.
        /// </summary>
        [JsonProperty("album_id")]
        public int AlbumId { get; set; }

        /// <summary>
        /// A comma-separated list of photo IDs.
        /// </summary>
        [JsonProperty("photo_ids")]
        public string PhotoIds { get; set; } = "";

        /// <summary>
        /// True to return extended information about photos.
        /// </summary>
        [JsonProperty("extended")]
        public bool Extended { get; set; } = false;

        /// <summary>
        /// True to return photo sizes.
        /// </summary>
        [JsonProperty("photo_sizes")]
        public bool PhotoSizes { get; set; } = false;

        /// <summary>
        /// Offset needed to return a specific subset of photos.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of photos to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 10;
    }
}
