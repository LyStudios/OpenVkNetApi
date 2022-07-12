using System.Collections.Generic;

namespace OpenVkNetApi.Models.Wall
{
    public class Photo
    {
        public int? album_id { get; set; }
        public int date { get; set; }
        public int id { get; set; }
        public int owner_id { get; set; }
        public List<Size> sizes { get; set; }
        public string text { get; set; }
        public bool has_tags { get; set; }
    }
    public class Size
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public bool crop { get; set; }
        public string type { get; set; }
    }
}
