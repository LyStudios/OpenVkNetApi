using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Photos
{
    /// <summary>
    /// Represents a photo object.
    /// </summary>
    public class Photo
    {
        [JsonProperty("pid")]
        public int? Pid { get; set; }

        /// <summary>
        /// The photo ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("aid")]
        public int? Aid { get; set; }

        /// <summary>
        /// The album ID.
        /// </summary>
        [JsonProperty("album_id")]
        public int? AlbumId { get; set; }

        /// <summary>
        /// The photo owner's ID.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// The ID of the user who uploaded the photo.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// The date when the photo was added, in Unix time.
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        [JsonProperty("created")]
        public long Created { get; set; }

        /// <summary>
        /// The original photo's width in pixels.
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// The original photo's height in pixels.
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// URL of the 75x75px copy.
        /// </summary>
        [JsonProperty("photo_75")]
        public string? Photo75 { get; set; }

        [JsonProperty("src_small")]
        public string? SrcSmall { get; set; }

        /// <summary>
        /// URL of the 130x130px copy.
        /// </summary>
        [JsonProperty("photo_130")]
        public string? Photo130 { get; set; }

        [JsonProperty("src")]
        public string? Src { get; set; }

        /// <summary>
        /// URL of the 604px copy.
        /// </summary>
        [JsonProperty("photo_604")]
        public string? Photo604 { get; set; }

        [JsonProperty("src_big")]
        public string? SrcBig { get; set; }

        /// <summary>
        /// URL of the 807px copy.
        /// </summary>
        [JsonProperty("photo_807")]
        public string? Photo807 { get; set; }

        [JsonProperty("src_xbig")]
        public string? SrcXbig { get; set; }

        /// <summary>
        /// URL of the 1280px copy.
        /// </summary>
        [JsonProperty("photo_1280")]
        public string? Photo1280 { get; set; }

        [JsonProperty("src_xxbig")]
        public string? SrcXxbig { get; set; }

        /// <summary>
        /// URL of the 2560px copy.
        /// </summary>
        [JsonProperty("photo_2560")]
        public string? Photo2560 { get; set; }

        [JsonProperty("src_xxxbig")]
        public string? SrcXxxbig { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The URL of the original photo.
        /// </summary>
        [JsonProperty("src_original")]
        public string? OriginalSource { get; set; }

        [JsonProperty("orig_photo")]
        public OriginalPhoto? OriginalPhoto { get; set; }

        /// <summary>
        /// Information about likes on the photo.
        /// </summary>
        [JsonProperty("likes")]
        public int? Likes { get; set; }

        /// <summary>
        /// Information about comments on the photo.
        /// </summary>
        [JsonProperty("comments")]
        public int? Comments { get; set; }

        /// <summary>
        /// Whether the current user can comment on the photo (1 for yes, 0 for no).
        /// </summary>
        [JsonProperty("can_comment")]
        public int CanComment { get; set; }

        /// <summary>
        /// Whether the current user can repost the photo (1 for yes, 0 for no).
        /// </summary>
        [JsonProperty("can_repost")]
        public int CanRepost { get; set; }
        
        /// <summary>
        /// A list of available photo sizes.
        /// </summary>
        [JsonProperty("sizes")]
        public List<PhotoSize>? Sizes { get; set; }
    }
}