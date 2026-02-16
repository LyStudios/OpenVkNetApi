using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Audio
{
    /// <summary>
    /// Represents playback keys for an audio file.
    /// This is a dynamic object, so extra properties are stored in a dictionary.
    /// </summary>
    public class AudioKeys
    {
        /// <summary>
        /// A dictionary to store any additional, unspecified properties returned by the API.
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, object> Properties { get; set; } = new Dictionary<string, object>();
    }
}
