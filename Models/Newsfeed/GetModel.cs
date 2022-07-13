using System.Collections.Generic;

namespace OpenVkNetApi.Models.Newsfeed
{
    public class GetModel
    {
        public GetResponse response { get; set; } 
    }
    public class GetResponse
    {
        public List<Post.Post> items { get; set; }
    }
}
