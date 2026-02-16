using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Audio
{
    /// <summary>
    /// Parameters for the <c>audio.getAlbums</c> method.
    /// </summary>
    public class AudioGetAlbumsParams
    {
        /// <summary>
        /// The owner's ID.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; } = 0;

        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// The number of albums to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 50;

        /// <summary>
        /// Whether to exclude private albums (0 or 1).
        /// </summary>
        [JsonProperty("drop_private")]
        public int DropPrivate { get; set; } = 1;
    }
}
