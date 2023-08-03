namespace OpenVkNetApi.Models.NewsfeedModels
{
    public class NewsfeedList
    {
        public Item[] Items { get; set; }
        public int Next_From { get; set; }
    }

    public class Item
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
        public Post_Source Post_Source { get; set; }
        public Attachment[] Attachments { get; set; }
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
        public int? Can_Like { get; set; }
        public int? Can_Publish { get; set; }
    }

    public class Reposts
    {
        public int Сount { get; set; }
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
        public Video? Video { get; set; }
    }

    public class Photo
    {
        public object Album_Id { get; set; }
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

    public class Video
    {
        public int Can_Comment { get; set; }
        public int Can_Like { get; set; }
        public int Can_Repost { get; set; }
        public int Can_Subscribe { get; set; }
        public int Can_Add_To_Faves { get; set; }
        public int Can_Add { get; set; }
        public int Comments { get; set; }
        public int Date { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public Image[] Image { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Id { get; set; }
        public int Owner_Id { get; set; }
        public int User_Id { get; set; }
        public string Title { get; set; }
        public bool Is_Favorite { get; set; }
        public string Player { get; set; }
        public Files Files { get; set; }
        public object Platform { get; set; }
        public int Added { get; set; }
        public int Repeat { get; set; }
        public string Type { get; set; }
        public int Views { get; set; }
        public Likes Likes { get; set; }
        public Reposts Reposts { get; set; }
    }

    public class Files
    {
        public string Mp4_480 { get; set; }
    }

    public class Image
    {
        public string Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int With_Padding { get; set; }
    }
}
