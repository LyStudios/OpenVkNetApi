using Newtonsoft.Json;
using OpenVkNetApi.Models;
using OpenVkNetApi.Exceptions;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenVkNetApi
{
    public class OVkApi
    {
        /// <summary>
        /// Авторизация в инстанции OpenVK
        /// </summary>
        /// <param name="instanceUrl">Ссылка на нужную инстанцию (по умолчанию https://openvk.uk)</param>
        /// <param name="username">Логин</param>
        /// <param name="password">Пароль</param>
        /// <param name="code">Код двухфакторной авторизации</param>
        public async Task<AuthorizedUser> Authorization(string username, string password, string instanceUrl = "https://openvk.uk", string code="0")
        {
            return new AuthorizedUser(JsonConvert.DeserializeObject<AuthorizationModel>(await GetRequestAsync($"{instanceUrl}/token?username={username}&password={password}&code={code}&grant_type=password")).access_token, instanceUrl);
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
