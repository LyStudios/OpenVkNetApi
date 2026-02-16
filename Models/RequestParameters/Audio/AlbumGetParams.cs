using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Audio
{
    /// <summary>
    /// Parameters for the <c>audio.getAlbums</c> method.
    /// Used by <see cref="OpenVkNetApi.Methods.Audio.GetAlbumsAsync"/>.
    /// </summary>
    public class AlbumGetParams
    {
        /// <summary>
        /// The ID of the owner of the albums.
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; } = 0;
        
        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [JsonProperty("offset")]
        public int? Offset { get; set; } = 0;
        
        /// <summary>
        /// The number of albums to return.
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; } = 50;
    }
}
