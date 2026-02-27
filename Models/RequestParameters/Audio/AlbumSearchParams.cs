using OpenVkNetApi.Utils;

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
        [ApiParameter("q")]
        public string Query { get; set; } = "";
        
        /// <summary>
        /// Offset for pagination of search results.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;
        
        /// <summary>
        /// The number of results to return (limit).
        /// </summary>
        [ApiParameter("limit")]
        public int Limit { get; set; } = 25;
        
        /// <summary>
        /// Whether to exclude private albums (0 or 1).
        /// </summary>
        [ApiParameter("drop_private")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool DropPrivate { get; set; } = false;
        
        /// <summary>
        /// The sorting order of the results.
        /// </summary>
        [ApiParameter("order")]
        public int Order { get; set; } = 0;
        
        /// <summary>
        /// Whether to search only among own albums (0 or 1).
        /// </summary>
        [ApiParameter("from_me")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool FromMe { get; set; } = false;
    }
}
