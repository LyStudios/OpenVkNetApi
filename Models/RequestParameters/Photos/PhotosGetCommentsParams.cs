using Newtonsoft.Json;
using OpenVkNetApi.Models.Enums;

namespace OpenVkNetApi.Models.RequestParameters.Photos
{
    /// <summary>
    /// Parameters for the photos.getComments method.
    /// </summary>
    public class PhotosGetCommentsParams
    {
        /// <summary>
        /// ID of the user or community that owns the photo.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// Photo ID.
        /// </summary>
        [JsonProperty("photo_id")]
        public int PhotoId { get; set; }

        /// <summary>
        /// True to return the 'likes' object.
        /// </summary>
        [JsonProperty("need_likes")]
        public bool NeedLikes { get; set; } = false;

        /// <summary>
        /// Offset needed to return a specific subset of comments.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of comments to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 100;

        /// <summary>
        /// True to return extended information about users who posted comments.
        /// </summary>
        [JsonProperty("extended")]
        public bool Extended { get; set; } = false;

        /// <summary>
        /// A list of additional fields to return.
        /// </summary>
        [JsonProperty("fields")]
        public UserFields Fields { get; set; } = UserFields.None;
    }
}
