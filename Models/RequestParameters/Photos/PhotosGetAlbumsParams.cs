using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Photos
{
    /// <summary>
    /// Parameters for the photos.getAlbums method.
    /// </summary>
    public class PhotosGetAlbumsParams
    {
        /// <summary>
        /// ID of the user or community that owns the albums.
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; } = null;

        /// <summary>
        /// A comma-separated list of album IDs.
        /// </summary>
        [JsonProperty("album_ids")]
        public string AlbumIds { get; set; } = "";

        /// <summary>
        /// Offset needed to return a specific subset of albums.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of albums to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 100;

        /// <summary>
        /// True to return system albums.
        /// </summary>
        [JsonProperty("need_system")]
        public bool NeedSystem { get; set; } = true;

        /// <summary>
        /// True to return album covers.
        /// </summary>
        [JsonProperty("need_covers")]
        public bool NeedCovers { get; set; } = true;

        /// <summary>
        /// True to return photo sizes.
        /// </summary>
        [JsonProperty("photo_sizes")]
        public bool PhotoSizes { get; set; } = false;
    }
}
