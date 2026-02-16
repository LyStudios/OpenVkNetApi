using Newtonsoft.Json;

namespace OpenVkNetApi.Models
{
    /// <summary>
    /// Represents a newsfeed collection, which includes a 'next_from' value for pagination.
    /// </summary>
    /// <typeparam name="T">The type of items in the newsfeed.</typeparam>
    public class NewsfeedCollection<T> : Collection<T> where T : class
    {
        /// <summary>
        /// The starting point for the next page of results.
        /// </summary>
        [JsonProperty("next_from")]
        public string? NextFrom { get; set; }
    }
}
