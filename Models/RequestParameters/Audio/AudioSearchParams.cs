using OpenVkNetApi.Utils;

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
        [ApiParameter("q")]
        public string Query { get; set; } = null!;
        
        /// <summary>
        /// Whether to auto-complete the query (0 or 1).
        /// </summary>
        [ApiParameter("auto_complete")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool AutoComplete { get; set; } = false;
        
        /// <summary>
        /// Whether to search by lyrics (0 or 1).
        /// </summary>
        [ApiParameter("lyrics")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool Lyrics { get; set; } = false;
        
        /// <summary>
        /// Whether to search only for performers (0 or 1).
        /// </summary>
        [ApiParameter("performer_only")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool PerformerOnly { get; set; } = false;
        
        /// <summary>
        /// The sorting order of the results.
        /// </summary>
        [ApiParameter("sort")]
        public int Sort { get; set; } = 2;
        
        /// <summary>
        /// Whether to search only among own audio files (0 or 1).
        /// </summary>
        [ApiParameter("search_own")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)] 
        public bool SearchOwn { get; set; } = false;
        
        /// <summary>
        /// Offset for pagination of search results.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;
        
        /// <summary>
        /// The number of results to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 30;
        
        /// <summary>
        /// The hash for the request.
        /// </summary>
        [ApiParameter("hash")]
        public string? Hash { get; set; } = null;
    }
}
