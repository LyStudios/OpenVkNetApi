namespace OpenVkNetApi.Models.AudioModels
{
    public class SearchModel
    {
        public int Count { get; set; }
        public Track[] Items { get; set; }
    }

    public class Track
    {
        public string Unique_Id { get; set; }
        public int Aid { get; set; }
        public int Id { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public object Album { get; set; }
        public object Album_Id { get; set; }
        public string Url { get; set; }
        public bool Manifest { get; set; }
        public bool Keys { get; set; }
        public int Genre { get; set; }
        public int Genre_Id { get; set; }
        public string Genre_Str { get; set; }
        public int Owner_Id { get; set; }
        public int? Lyrics { get; set; }
        public bool Added { get; set; }
        public bool Editable { get; set; }
        public bool Searchable { get; set; }
        public bool Explicit { get; set; }
        public bool Withdrawn { get; set; }
        public bool Ready { get; set; }
    }

}
