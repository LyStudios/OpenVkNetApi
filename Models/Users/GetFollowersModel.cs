using System.Collections.Generic;

namespace OpenVkNetApi.Models.Users
{
    public class GetFollowersModel
    {
        public GetFollowersResponse response { get; set; }
    }

    public class GetFollowersResponse
    {
        public int count { get; set; }
        public List<User> items { get; set; }
    }
}
