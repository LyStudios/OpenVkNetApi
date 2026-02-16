using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Photos
{
    /// <summary>
    /// Represents a photo album.
    /// </summary>
    public class Album
    {
        /// <summary>
        /// The album ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The ID of the photo that is the album's cover.
        /// </summary>
        [JsonProperty("thumb_id")]
        public int ThumbId { get; set; }

        /// <summary>
        /// The album owner's ID.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// The album title.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The album description.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The date when the album was created, in Unix time.
        /// </summary>
        [JsonProperty("created")]
        public long Created { get; set; }

        /// <summary>
        /// The date when the album was last updated, in Unix time.
        /// </summary>
        [JsonProperty("updated")]
        public long Updated { get; set; }

        /// <summary>
        /// The number of photos in the album.
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }
        
        /// <summary>
        /// Indicates if the current user can upload photos to this album.
        /// </summary>
        [JsonProperty("can_upload")]
        public bool CanUpload { get; set; }

        /// <summary>
        /// The URL of the album's thumbnail.
        /// </summary>
        [JsonProperty("thumb_src")]
        public string? ThumbSrc { get; set; }

        [JsonProperty("privacy_comment")]
        public int? PrivacyComment { get; set; }

        [JsonProperty("upload_by_admins_only")]
        public int? UploadByAdminsOnly { get; set; }

        [JsonProperty("comments_disabled")]
        public int? CommentsDisabled { get; set; }

        /// <summary>
        /// A list of available thumbnail sizes for the album cover.
        /// </summary>
        [JsonProperty("sizes")]
        public List<PhotoSize>? Sizes { get; set; }
    }
}
