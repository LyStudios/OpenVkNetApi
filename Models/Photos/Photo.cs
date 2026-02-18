using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Photos
{
    /// <summary>
    /// Represents a photo entity returned by the API.
    /// Contains both modern and legacy fields for maximum compatibility.
    /// </summary>
    public class Photo
    {
        /// <summary>
        /// Legacy photo identifier used in older API methods.
        /// Usually duplicates <see cref="Id"/>.
        /// </summary>
        [JsonProperty("pid")]
        public int? PhotoId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the photo.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Legacy album identifier.
        /// Prefer <see cref="AlbumId"/> when available.
        /// </summary>
        [JsonProperty("aid")]
        public int? Aid { get; set; }

        /// <summary>
        /// Gets or sets the album identifier the photo belongs to.
        /// </summary>
        [JsonProperty("album_id")]
        public int? AlbumId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the photo owner.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the user who uploaded the photo.
        /// May differ from <see cref="OwnerId"/>.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the upload date in Unix time.
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        /// <summary>
        /// Gets or sets the creation timestamp in Unix time.
        /// Often identical to <see cref="Date"/>.
        /// </summary>
        [JsonProperty("created")]
        public long Created { get; set; }

        /// <summary>
        /// Gets or sets the original photo width in pixels.
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the original photo height in pixels.
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// URL of the 75px thumbnail copy.
        /// Legacy size field.
        /// </summary>
        [JsonProperty("photo_75")]
        public string? Photo75 { get; set; }

        /// <summary>
        /// Alternative small preview URL (legacy alias).
        /// </summary>
        [JsonProperty("src_small")]
        public string? SrcSmall { get; set; }

        /// <summary>
        /// URL of the ~130px preview copy.
        /// </summary>
        [JsonProperty("photo_130")]
        public string? Photo130 { get; set; }

        /// <summary>
        /// Legacy generic preview URL.
        /// </summary>
        [JsonProperty("src")]
        public string? Src { get; set; }

        /// <summary>
        /// URL of the ~604px copy.
        /// </summary>
        [JsonProperty("photo_604")]
        public string? Photo604 { get; set; }

        /// <summary>
        /// Alternative large preview URL (legacy alias).
        /// </summary>
        [JsonProperty("src_big")]
        public string? SrcBig { get; set; }

        /// <summary>
        /// URL of the ~807px copy.
        /// </summary>
        [JsonProperty("photo_807")]
        public string? Photo807 { get; set; }

        /// <summary>
        /// Legacy alias for extended size preview.
        /// </summary>
        [JsonProperty("src_xbig")]
        public string? SrcXbig { get; set; }

        /// <summary>
        /// URL of the ~1280px copy.
        /// </summary>
        [JsonProperty("photo_1280")]
        public string? Photo1280 { get; set; }

        /// <summary>
        /// Legacy alias for very large preview.
        /// </summary>
        [JsonProperty("src_xxbig")]
        public string? SrcXxbig { get; set; }

        /// <summary>
        /// URL of the ~2560px copy.
        /// </summary>
        [JsonProperty("photo_2560")]
        public string? Photo2560 { get; set; }

        /// <summary>
        /// Legacy alias for maximum preview size.
        /// </summary>
        [JsonProperty("src_xxxbig")]
        public string? SrcXxxbig { get; set; }

        /// <summary>
        /// Direct CDN URL to the photo.
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Gets or sets the original (maximum resolution) photo URL.
        /// </summary>
        [JsonProperty("src_original")]
        public string? OriginalSource { get; set; }

        /// <summary>
        /// Detailed metadata about the original photo.
        /// </summary>
        [JsonProperty("orig_photo")]
        public OriginalPhoto? OriginalPhoto { get; set; }

        /// <summary>
        /// Gets or sets the number of likes on the photo.
        /// </summary>
        [JsonProperty("likes")]
        public int? Likes { get; set; }

        /// <summary>
        /// Gets or sets the number of comments on the photo.
        /// </summary>
        [JsonProperty("comments")]
        public int? Comments { get; set; }

        /// <summary>
        /// Indicates whether the current user can comment on the photo (1 = yes, 0 = no).
        /// </summary>
        [JsonProperty("can_comment")]
        public int CanComment { get; set; }

        /// <summary>
        /// Indicates whether the current user can repost the photo (1 = yes, 0 = no).
        /// </summary>
        [JsonProperty("can_repost")]
        public int CanRepost { get; set; }

        /// <summary>
        /// Collection of available photo sizes with URLs and dimensions.
        /// Preferred over legacy size fields.
        /// </summary>
        [JsonProperty("sizes")]
        public List<PhotoSize>? Sizes { get; set; }
    }
}
