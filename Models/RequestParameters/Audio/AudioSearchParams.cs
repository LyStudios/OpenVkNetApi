using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Audio
{
    /// <summary>
    /// Parameters for the <c>audio.search</c> method.
    /// Used by <see cref="OpenVkNetApi.Methods.Audio.SearchAsync"/>.
    /// </summary>
    public class AudioSearchParams
    {
        /// <summary>
        /// The search query for audio files.
        /// </summary>
        [JsonProperty("q")]
        public string Query { get; set; } = null!;
        
        /// <summary>
        /// Whether to auto-complete the query (0 or 1).
        /// </summary>
        [JsonProperty("auto_complete")]
        public int AutoComplete { get; set; } = 0;
        
        /// <summary>
        /// Whether to search by lyrics (0 or 1).
        /// </summary>
        [JsonProperty("lyrics")]
        public int Lyrics { get; set; } = 0;
        
        /// <summary>
        /// Whether to search only for performers (0 or 1).
        /// </summary>
        [JsonProperty("performer_only")]
        public int PerformerOnly { get; set; } = 0;
        
        /// <summary>
        /// The sorting order of the results.
        /// </summary>
        [JsonProperty("sort")]
        public int Sort { get; set; } = 2;
        
        /// <summary>
        /// Whether to search only among own audio files (0 or 1).
        /// </summary>
        [JsonProperty("search_own")]
        public int SearchOwn { get; set; } = 0;
        
        /// <summary>
        /// Offset for pagination of search results.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;
        
        /// <summary>
        /// The number of results to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 30;
        
        /// <summary>
        /// The hash for the request.
        /// </summary>
        [JsonProperty("hash")]
        public string? Hash { get; set; }
    }
}
