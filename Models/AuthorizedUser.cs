using OpenVkNetApi.Methods;

namespace OpenVkNetApi.Models
{
    public class AuthorizedUser
    {
        public Account Account { get; set; }
        public Friends Friends { get; set; }
        public Groups Groups { get; set; }
        public Likes Likes { get; set; }
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
        }
    }
}
