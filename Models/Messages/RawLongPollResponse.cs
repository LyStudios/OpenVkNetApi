using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents the raw JSON response from the OpenVK Long Poll server.
    /// </summary>
    public class RawLongPollResponse
    {
        /// <summary>
        /// The new 'ts' (timestamp/sequence number) to be used in the next Long Poll request.
        /// </summary>
        [JsonProperty("ts")]
        public long Ts { get; set; }

        /// <summary>
        /// A list of raw updates received from the Long Poll server.
        /// Each update is typically a list of integers and strings.
        /// </summary>
        [JsonProperty("updates")]
        public List<List<object>>? Updates { get; set; }

        /// <summary>
        /// Indicates if there was an error with the Long Poll request.
        /// Possible values: 1 (invalid ts), 2 (invalid key), 3 (connection lost/info outdated).
        /// </summary>
        [JsonProperty("failed")]
        public int? Failed { get; set; }
    }
}
