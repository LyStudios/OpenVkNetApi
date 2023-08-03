using OpenVkNetApi.Methods;

namespace OpenVkNetApi.Models
{
    public class AuthorizedUser
    {
        public Account Account { get; set; }
        public Friends Friends { get; set; }
        public Groups Groups { get; set; }
        public Likes Likes { get; set; }
        public Messages Messages { get; set; }
        public Ovk Ovk { get; set; }
        public Utils Utils { get; set; }
        public Users Users { get; set; }
        public Wall Wall { get; set; }
        public Newsfeed Newsfeed { get; set; }
        public Status Status { get; set; }
        public string AccessToken { get; set; }
        public string InstanceUrl { get; set; }
        public AuthorizedUser(string token, string instance)
        {
            AccessToken = token;
            InstanceUrl = instance;
            Account = new Account(token, instance);
            Friends = new Friends(token, instance);
            Groups = new Groups(token, instance);
            Likes = new Likes(token, instance);
            Messages = new Messages(token, instance);
            Ovk = new Ovk(token, instance);
            Utils = new Utils(token, instance);
            Users = new Users(token, instance);
            Wall = new Wall(token, instance);
            Newsfeed = new Newsfeed(token, instance);
        }
    }
}
