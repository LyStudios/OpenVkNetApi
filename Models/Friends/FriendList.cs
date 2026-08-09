using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Friends
{
    /// <summary>
    /// Represents a custom friend list.
    /// </summary>
    public class FriendList
    {
        /// <summary>
        /// Gets or sets the list ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the list name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
