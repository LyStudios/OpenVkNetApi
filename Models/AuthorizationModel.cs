namespace OpenVkNetApi.Models
{
    public class AuthorizationModel
    {
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public int user_id { get; set; }
    }
}
