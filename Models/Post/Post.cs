using System.Collections.Generic;

namespace OpenVkNetApi.Models.Post
{
    public class Post
    {
        public int id { get; set; }
        public int from_id { get; set; }
        public int owner_id { get; set; }
        public int date { get; set; }
        public string post_type { get; set; }
        public string text { get; set; }
        public int can_edit { get; set; }
        public bool can_delete { get; set; }
        public bool can_pin { get; set; }
        public bool can_archive { get; set; }
        public bool is_archived { get; set; }
        public bool is_pinned { get; set; }
        public List<Attachment> attachments { get; set; }
        public PostSource post_source { get; set; }
        public Comments comments { get; set; }
        public Likes likes { get; set; }
        public Reposts reposts { get; set; }
    }
}
