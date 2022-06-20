namespace OpenVkNetApi.Models
{
    public class AuthorizedUser
    {
        public string access_token { get; set; }
        public string instanceUrl { get; set; }
        public AuthorizedUser(string token, string instance)
        {
            access_token = token;
            instanceUrl = instance;
        }
    }
}
