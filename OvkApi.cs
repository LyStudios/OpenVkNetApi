using Newtonsoft.Json;
using OpenVkNetApi.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenVkNetApi
{
    public class OvkApi
    {
         public async Task<AuthorizedUser> Authorize(string Username, string Password, string InstanceUrl = "https://openvk.uk", string Code = "0", string ClientName = null)
         {
            return new AuthorizedUser(JsonConvert.DeserializeObject<AuthModel>(await GetRequest($"{InstanceUrl}/token?username={Username}&password={Password}&code={Code}&client_name={ClientName}&grant_type=password")).access_token, InstanceUrl);
         }
         internal async Task<string> GetRequest(string Url)
         {
            try
            {
                return await new HttpClient().GetStringAsync(Url);
            }
            catch (Exception e)
            {
                return e.Message;
            }
         }
     }
}
