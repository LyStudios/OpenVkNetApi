using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Audio
{
    /// <summary>
    /// Represents an audio album.
    /// </summary>
    public class Album
    {
        /// <summary>
        /// The album ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        
        /// <summary>
        /// The ID of the user or community that owns the album.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        
        /// <summary>
        /// The album title.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }
        
        /// <summary>
        /// The album description.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }
        
        /// <summary>
        /// The number of audio tracks in the album.
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }
        
        /// <summary>
        /// The total duration of the album in seconds.
        /// </summary>
        [JsonProperty("length")]
        public int Length { get; set; }
        
        /// <summary>
        /// The date when the album was created, in Unix time.
        /// </summary>
        [JsonProperty("created")]
        public int Created { get; set; }
        
        /// <summary>
        /// The date when the album was last updated, in Unix time.
        /// </summary>
        [JsonProperty("modified")]
        public int? Modified { get; set; }
        
        /// <summary>
        /// Indicates if the album is accessible to the current user.
        /// </summary>
        [JsonProperty("accessible")]
        public bool Accessible { get; set; }
        
        /// <summary>
        /// Indicates if the album can be edited by the current user.
        /// </summary>
        [JsonProperty("editable")]
        public bool Editable { get; set; }
        
        /// <summary>
        /// Indicates if the album is in the current user's bookmarks.
        /// </summary>
        [JsonProperty("bookmarked")]
        public bool Bookmarked { get; set; }
        
        /// <summary>
        /// The number of times the album has been played.
        /// </summary>
        [JsonProperty("listens")]
        public int Listens { get; set; }
        
        /// <summary>
        /// The URL of the album cover.
        /// </summary>
        [JsonProperty("cover_url")]
        public string? CoverUrl { get; set; }
        
        /// <summary>
        /// Indicates if the album is searchable.
        /// </summary>
        [JsonProperty("searchable")]
        public bool Searchable { get; set; }
    }
}
