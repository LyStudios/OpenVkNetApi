using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Audio
{
    /// <summary>
    /// Parameters for the <c>audio.searchAlbums</c> method.
    /// Used by <see cref="OpenVkNetApi.Methods.Audio.SearchAlbumsAsync"/>.
    /// </summary>
    public class AlbumSearchParams
    {
        /// <summary>
        /// The search query for albums.
        /// </summary>
        [JsonProperty("q")]
        public string? Query { get; set; } = "";
        
        /// <summary>
        /// Offset for pagination of search results.
        /// </summary>
        [JsonProperty("offset")]
        public int? Offset { get; set; } = 0;
        
        /// <summary>
        /// The number of results to return (limit).
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; } = 25;
        
        /// <summary>
        /// Whether to exclude private albums (0 or 1).
        /// </summary>
        [JsonProperty("drop_private")]
        public int? DropPrivate { get; set; } = 0;
        
        /// <summary>
        /// The sorting order of the results.
        /// </summary>
        [JsonProperty("order")]
        public int? Order { get; set; } = 0;
        
        /// <summary>
        /// Whether to search only among own albums (0 or 1).
        /// </summary>
        [JsonProperty("from_me")]
        public int? FromMe { get; set; } = 0;
    }
}
