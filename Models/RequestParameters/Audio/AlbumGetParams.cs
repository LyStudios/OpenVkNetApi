using OpenVkNetApi.Utils;

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
        [ApiParameter("owner_id")]
        public int? OwnerId { get; set; } = 0;
        
        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [ApiParameter("offset")]
        public int? Offset { get; set; } = 0;
        
        /// <summary>
        /// The number of albums to return.
        /// </summary>
        [ApiParameter("count")]
        public int? Count { get; set; } = 50;
    }
}
