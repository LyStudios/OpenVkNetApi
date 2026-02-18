using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Comments
{
    /// <summary>
    /// Represents a comment on a note.
    /// </summary>
    public class NoteComment : Comment
    {
        [JsonProperty("uid")]
        public int UserId { get; set; }

        [JsonProperty("nid")]
        public int NoteId { get; set; }

        [JsonProperty("oid")]
        public int OwnerId { get; set; }
    }
}
