using System.Collections.Generic;
using Newtonsoft.Json;
using OpenVkNetApi.Models.Groups;
using OpenVkNetApi.Models.Users;

namespace OpenVkNetApi.Models.Calls
{
    /// <summary>
    /// Represents calls history response data.
    /// </summary>
    public class CallsHistory
    {
        /// <summary>
        /// List of call items.
        /// </summary>
        [JsonProperty("items")]
        public List<CallItem> Items { get; set; }

        /// <summary>
        /// User profiles related to the calls.
        /// </summary>
        [JsonProperty("profiles")]
        public List<User> Profiles { get; set; }

        /// <summary>
        /// Groups related to the calls.
        /// </summary>
        [JsonProperty("groups")]
        public List<Group> Groups { get; set; }

        /// <summary>
        /// Contact users.
        /// </summary>
        [JsonProperty("contacts")]
        public List<User> Contacts { get; set; }

        /// <summary>
        /// Whether more calls are available for pagination.
        /// </summary>
        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }
}
