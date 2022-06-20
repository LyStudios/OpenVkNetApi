using System;
using System.Collections.Generic;
using System.Text;

namespace OpenVkNetApi.Models.Friends
{
    public class GetFriendsModel
    {
        public GetFriendsResponse response { get; set; }
    }
    public class FriendItem
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public bool is_closed { get; set; }
        public bool can_access_closed { get; set; }
        public int online { get; set; }
    }

    public class GetFriendsResponse
    {
        public int count { get; set; }
        public List<FriendItem> items { get; set; }
    }
}
