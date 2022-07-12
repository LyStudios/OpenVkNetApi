using System.Collections.Generic;

namespace OpenVkNetApi.Models.Wall
{
    public class GetByIdModel
    {
        public GetByIdResponse response { get; set; }
    }

    public class GetByIdResponse
    {
        public List<Post> items { get; set; }
    }
}
