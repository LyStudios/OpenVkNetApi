using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Notes
{
    /// <summary>
    /// Represents a user note.
    /// </summary>
    public class Note
    {
        /// <summary>
        /// The note ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The note owner's ID.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// The note title.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The note text.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The date when the note was created, in Unix time.
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        /// <summary>
        /// The number of comments on the note.
        /// </summary>
        [JsonProperty("comments")]
        public int Comments { get; set; }

        /// <summary>
        /// The URL to view the note.
        /// </summary>
        [JsonProperty("view_url")]
        public string? ViewUrl { get; set; }
    }
}
