using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Audio
{
    /// <summary>
    /// Represents information about the user who uploaded an audio file.
    /// </summary>
    public class AudioUser
    {
        /// <summary>
        /// The user's ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        
        /// <summary>
        /// The URL of the user's profile photo.
        /// </summary>
        [JsonProperty("photo")]
        public string? Photo { get; set; }
        
        /// <summary>
        /// The user's full name.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
        
        /// <summary>
        /// The user's name in the genitive case.
        /// </summary>
        [JsonProperty("name_gen")]
        public string? NameGen { get; set; }
    }
}
