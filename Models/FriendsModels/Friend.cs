namespace OpenVkNetApi.Models.FriendsModels
{
    public class FriendsList
    {
        public int Count { get; set; }
        public Friend[] Friends { get; set; }
    }

    public class Friend
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public bool Is_Closed { get; set; }
        public bool Can_Access_Closed { get; set; }
        public int Online { get; set; }
        public string Deactivated { get; set; }
    }
}
