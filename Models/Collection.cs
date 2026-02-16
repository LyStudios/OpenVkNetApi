using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenVkNetApi.Models
{
    /// <summary>
    /// Represents a generic collection of items returned by the API.
    /// </summary>
    /// <typeparam name="T">The type of items in the collection.</typeparam>
    public class Collection<T>
    {
        /// <summary>
        /// The total number of items in the collection.
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// The list of items on the current page.
        /// </summary>
        [JsonProperty("items")]
        public List<T>? Items { get; set; }
    }
}
