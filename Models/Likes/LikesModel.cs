namespace OpenVkNetApi.Models.Likes
{
    public class LikesModel
    {
        public LikesResponse response { get; set; }
    }
    public class LikesResponse
    {
        public int likes { get; set; }
    }
    public class IsLikedResponse
    {
        public int liked { get; set; }
        public int copied { get; set; }
    }
    public class IsLikedModel
    {
        public IsLikedResponse response { get; set; }
    }
}
