using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Utils
{
    /// <summary>
    /// Represents the response from the utils.resolveScreenName method.
    /// </summary>
    public class UtilsResolveScreenName
    {
        /// <summary>
        /// The ID of the resolved object (user, group, or application).
        /// </summary>
        [JsonProperty("object_id")]
        public int ObjectId { get; set; }

        /// <summary>
        /// The type of the resolved object ("user", "group", or "application").
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}
