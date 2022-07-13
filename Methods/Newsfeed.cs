using Newtonsoft.Json;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Newsfeed;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Newsfeed
    {
        OVkApi api = new OVkApi();
        public async Task<GetModel> Get(AuthorizedUser user, string fields = "", int start_from = 0, int offset = 0, int count = 30, int extended = 0)
        {
            return JsonConvert.DeserializeObject<GetModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Newsfeed.get?access_token={user.access_token}&fields={fields}&extended={extended}&offset={offset}&count={count}&start_from={start_from}"));
        }
    }
}
