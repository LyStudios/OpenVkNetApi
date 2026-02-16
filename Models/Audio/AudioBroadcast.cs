using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Audio
{
    /// <summary>
    /// Represents an audio broadcast object.
    /// </summary>
    public class AudioBroadcast
    {
        /// <summary>
        /// The ID of the broadcasting user or community.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        
        /// <summary>
        /// The name of the broadcasting user or community.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
        
        /// <summary>
        /// The screen name of the broadcasting user or community.
        /// </summary>
        [JsonProperty("screen_name")]
        public string? ScreenName { get; set; }
        
        /// <summary>
        /// Indicates if the community is closed.
        /// </summary>
        [JsonProperty("is_closed")]
        public bool IsClosed { get; set; }
        
        /// <summary>
        /// The type of the broadcasting entity (e.g., "user", "group").
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }
        
        /// <summary>
        /// Indicates if the current user is a member of the broadcasting community.
        /// </summary>
        [JsonProperty("is_member")]
        public int IsMember { get; set; }
        
        /// <summary>
        /// Indicates if the broadcasting user or community is deactivated.
        /// </summary>
        [JsonProperty("deactivated")]
        public bool? Deactivated { get; set; }
        
        /// <summary>
        /// Indicates if the current user can access the closed community.
        /// </summary>
        [JsonProperty("can_access_closed")]
        public bool CanAccessClosed { get; set; }
        
        /// <summary>
        /// The audio file currently being broadcast.
        /// </summary>
        [JsonProperty("status_audio")]
        public Audio? StatusAudio { get; set; }
    }
}
