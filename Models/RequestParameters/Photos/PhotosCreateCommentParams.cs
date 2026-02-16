using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Photos
{
    /// <summary>
    /// Parameters for the photos.createComment method.
    /// </summary>
    public class PhotosCreateCommentParams
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
        /// The text of the comment.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// True if the comment is published on behalf of a group.
        /// </summary>
        [JsonProperty("from_group")]
        public bool FromGroup { get; set; } = false;
    }
}
