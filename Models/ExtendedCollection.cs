using Newtonsoft.Json;
using System.Collections.Generic;
using OpenVkNetApi.Models.Groups;
using OpenVkNetApi.Models.Users;

namespace OpenVkNetApi.Models
{
    /// <summary>
    /// Represents a collection that can include extended information about users and groups.
    /// </summary>
    /// <typeparam name="T">The type of the main items in the collection.</typeparam>
    public class ExtendedCollection<T> : Collection<T> where T : class
    {
        /// <summary>
        /// A list of user profiles mentioned in the collection.
        /// </summary>
        [JsonProperty("profiles")]
        public List<User>? Profiles { get; set; }

        /// <summary>
        /// A list of group profiles mentioned in the collection.
        /// </summary>
        [JsonProperty("groups")]
        public List<Group>? Groups { get; set; }
    }
}
