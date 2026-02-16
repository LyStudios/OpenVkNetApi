using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Photos
{
    /// <summary>
    /// Represents the result of saving an owner's photo (profile or group avatar).
    /// </summary>
    public class PhotosSaveOwnerPhoto
    {
        /// <summary>
        /// This property is obsolete and always returns null.
        /// </summary>
        [JsonProperty("photo_hash")]
        public object? PhotoHash { get; set; }

        /// <summary>
        /// The URL of the saved photo.
        /// </summary>
        [JsonProperty("photo_src")]
        public string? PhotoSrc { get; set; }
    }
}
