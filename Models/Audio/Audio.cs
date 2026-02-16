using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Audio
{
    /// <summary>
    /// Represents an audio file.
    /// </summary>
    public class Audio
    {
        /// <summary>
        /// A unique identifier for the audio file.
        /// </summary>
        [JsonProperty("unique_id")]
        public string? UniqueId { get; set; }
        
        /// <summary>
        /// The audio file ID.
        /// </summary>
        [JsonProperty("aid")]
        public int Aid { get; set; }
        
        /// <summary>
        /// The audio file's primary ID.
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }
        
        /// <summary>
        /// The artist's name.
        /// </summary>
        [JsonProperty("artist")]
        public string? Artist { get; set; }
        
        /// <summary>
        /// The track title.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }
        
        /// <summary>
        /// The duration of the audio file in seconds.
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; set; }
        
        /// <summary>
        /// Information about the album.
        /// </summary>
        [JsonProperty("album")]
        public object? Album { get; set; }
        
        /// <summary>
        /// The album ID.
        /// </summary>
        [JsonProperty("album_id")]
        public object? AlbumId { get; set; }
        
        /// <summary>
        /// The URL to play the audio file.
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The number of times the audio has been played.
        /// </summary>
        [JsonProperty("listens")]
        public int? Listens { get; set; }

        /// <summary>
        /// The manifest for streaming playback.
        /// </summary>
        [JsonProperty("manifest")]
        public string? Manifest { get; set; }
        
        /// <summary>
        /// Playback keys for the audio file.
        /// </summary>
        [JsonProperty("keys")]
        public AudioKeys? Keys { get; set; }
        
        /// <summary>
        /// The genre ID.
        /// </summary>
        [JsonProperty("genre")]
        public int Genre { get; set; }
        
        /// <summary>
        /// The genre ID.
        /// </summary>
        [JsonProperty("genre_id")]
        public int GenreId { get; set; }
        
        /// <summary>
        /// The genre name.
        /// </summary>
        [JsonProperty("genre_str")]
        public string? GenreStr { get; set; }
        
        /// <summary>
        /// The ID of the user or community that owns the audio file.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// The lyrics ID, if available.
        /// </summary>
        [JsonProperty("lyrics")]
        public int? Lyrics { get; set; }

        /// <summary>
        /// Indicates if the audio file has been added to the current user's collection.
        /// </summary>
        [JsonProperty("added")]
        public bool Added { get; set; }
        
        /// <summary>
        /// Indicates if the audio file can be edited by the current user.
        /// </summary>
        [JsonProperty("editable")]
        public bool Editable { get; set; }
        
        /// <summary>
        /// Indicates if the audio file is searchable.
        /// </summary>
        [JsonProperty("searchable")]
        public bool Searchable { get; set; }
        
        /// <summary>
        /// Indicates if the audio file has explicit content.
        /// </summary>
        [JsonProperty("explicit")]
        public bool Explicit { get; set; }
        
        /// <summary>
        /// Indicates if the audio file has been withdrawn from public access.
        /// </summary>
        [JsonProperty("withdrawn")]
        public bool Withdrawn { get; set; }
        
        /// <summary>
        /// Indicates if the audio file is ready for playback.
        /// </summary>
        [JsonProperty("ready")]
        public bool Ready { get; set; }
        
        /// <summary>
        /// Information about the user who uploaded the audio.
        /// </summary>
        [JsonProperty("user")]
        public AudioUser? User { get; set; }
    }
}
