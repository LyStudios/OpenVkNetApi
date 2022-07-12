using System.Collections.Generic;

namespace OpenVkNetApi.Models.Users
{
    public class SearchModel
    {
        public SearchResponse response { get; set; }
    }

    public class SearchResponse
    {
        public int count { get; set; }
        public List<User> items { get; set; }
    }
}
