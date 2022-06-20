using Newtonsoft.Json;
using OpenVkNetApi.Models;
using OpenVkNetApi.Exceptions;
using System.Net.Http;
using System.Threading.Tasks;


namespace OpenVkNetApi
{
    public class OVkApi
    {
        public async Task<AuthorizedUser> Authorization(string instanceUrl, string username, string password)
        {
            return new AuthorizedUser(JsonConvert.DeserializeObject<AuthorizationModel>(await GetRequestAsync($"{instanceUrl}/token?username={username}&password={password}&grant_type=password")).access_token, instanceUrl);
        }
        internal async Task<string> GetRequestAsync(string Url)
        {
            var content = await new HttpClient().GetStringAsync(Url);
            if (content.Contains("error_msg"))
            {
                var convertedError = JsonConvert.DeserializeObject<ErrorModel>(content);
                throw new OnRequestErrorException($"Error {convertedError.error_code}: {convertedError.error_msg}");
            }
            else { return content; }
        }
    }
}
