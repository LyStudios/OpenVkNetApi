using System.Collections.Generic;

namespace OpenVkNetApi.Models.Friends
{
    public class GetListsModel
    {
        public GetListsResponse response { get; set; }
    }
    public class GetListsResponse
    {
        public int count { get; set; }
        public List<object> items { get; set; }
    }
}
