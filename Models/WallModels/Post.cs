namespace OpenVkNetApi.Models.WallModels
{
    public class Profile
    {
        public string first_name { get; set; }
        public int id { get; set; }
        public string last_name { get; set; }
        public bool can_access_closed { get; set; }
        public bool is_closed { get; set; }
        public int sex { get; set; }
        public string screen_name { get; set; }
        public string photo_50 { get; set; }
        public string photo_100 { get; set; }
        public bool online { get; set; }
    }

    public class Group
    {
        public int id { get; set; }
        public string name { get; set; }
        public string screen_name { get; set; }
        public int is_closed { get; set; }
        public string type { get; set; }
        public string photo_50 { get; set; }
        public string photo_100 { get; set; }
        public string photo_200 { get; set; }
    }

    public class PostList
    {
        public int? Count { get; set; }
        public Post[] Items { get; set; }
        public Profile[]? Profiles { get; set; }
        public Group[]? Groups { get; set; }
    }
    public class Post
    {
        public int Id { get; set; }
        public int From_Id { get; set; }
        public int Owner_Id { get; set; }
        public int Date { get; set; }
        public string Post_Type { get; set; }
        public string Text { get; set; }
        public Copy_History[] Copy_History { get; set; }
        public int Can_Edit { get; set; }
        public bool Can_Delete { get; set; }
        public bool Can_Pin { get; set; }
        public bool Can_Archive { get; set; }
        public bool Is_Archived { get; set; }
        public bool Is_Pinned { get; set; }
        public Attachment[] Attachments { get; set; }
        public Post_Source Post_Source { get; set; }
        public Comments Comments { get; set; }
        public Likes Likes { get; set; }
        public Reposts Reposts { get; set; }
    }
    public class Post_Source
    {
        public string Type { get; set; }
    }
    public class Comments
    {
        public int Count { get; set; }
        public int Can_Post { get; set; }
    }
    public class Likes
    {
        public int Count { get; set; }
        public int User_Likes { get; set; }
        public int Can_Like { get; set; }
        public int Can_Publish { get; set; }
    }
    public class Reposts
    {
        public int Count { get; set; }
        public int User_Reposted { get; set; }
    }
    public class Copy_History
    {
        public int Id { get; set; }
        public int Owner_Id { get; set; }
        public int From_Id { get; set; }
        public int Date { get; set; }
        public string Post_Type { get; set; }
        public string Text { get; set; }
        public Attachment[] Attachments { get; set; }
        public Post_Source Post_Source { get; set; }
    }
    public class Attachment
    {
        public string Type { get; set; }
        public Photo Photo { get; set; }
    }
    public class Photo
    {
        public int? Album_id { get; set; }
        public int Date { get; set; }
        public int Id { get; set; }
        public int Owner_Id { get; set; }
        public Size[] Sizes { get; set; }
        public string Text { get; set; }
        public bool Has_Tags { get; set; }
    }
    public class Size
    {
        public string Url { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public bool? Crop { get; set; }
        public string Type { get; set; }
    }
}
