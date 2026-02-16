using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Friends
{
    /// <summary>
    /// Represents the friendship status between the current user and a target user.
    /// </summary>
    public class FriendStatus
    {
        /// <summary>
        /// The friendship status code. 
        /// 0 - not a friend, 1 - friend request sent, 2 - incoming friend request, 3 - friend.
        /// </summary>
        [JsonProperty("friend_status")]
        public int Status { get; set; }

        /// <summary>
        /// The target user's ID.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}
