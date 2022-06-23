using System.Collections.Generic;

namespace OpenVkNetApi.Models.Groups
{
    public class GetGroupsModel
    {
        public GetGroupsResponse response { get; set; }
    }
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string screen_name { get; set; }
        public bool is_closed { get; set; }
        public bool can_access_closed { get; set; }
    }

    public class GetGroupsResponse
    {
        public int count { get; set; }
        public List<Item> items { get; set; }
    }
}
