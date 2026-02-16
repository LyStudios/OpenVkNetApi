using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Photos
{
    /// <summary>
    /// Parameters for the photos.editAlbum method.
    /// </summary>
    public class PhotosEditAlbumParams
    {
        /// <summary>
        /// Album ID.
        /// </summary>
        [JsonProperty("album_id")]
        public int AlbumId { get; set; }

        /// <summary>
        /// Album owner's ID.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// New album title.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// New album description.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Privacy settings for the album.
        /// </summary>
        [JsonProperty("privacy")]
        public int Privacy { get; set; } = 0;
    }
}
