namespace OpenVkNetApi.Models.FriendsModels
{
    public class FriendRequestsList
    {
        public int Count { get; set; }
        public FriendRequest[] Requests { get; set; }
    }
    public class FriendRequest
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public bool Is_closed { get; set; }
        public bool Can_access_closed { get; set; }
        public int Online { get; set; }
        public int User_id { get; set; }
    }
}
