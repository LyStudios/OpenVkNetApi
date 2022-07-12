using System.Collections.Generic;

namespace OpenVkNetApi.Models.Wall
{
    public class GetModel
    {
        public GetWallResponse response { get; set; }
    }
    
    public class GetWallResponse
    {
        public int count { get; set; }
        public List<Post> items { get; set; }
    }
}
