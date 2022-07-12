using Newtonsoft.Json;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Wall;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Wall
    {
        OVkApi api = new OVkApi();
        public async Task<GetModel> Get(AuthorizedUser user, string owner_id, int extended = 0, int offset = 0, int count = 30)
        {
            return JsonConvert.DeserializeObject<GetModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Wall.get?access_token={user.access_token}&owner_id={owner_id}&extended={extended}&offset={offset}&count={count}"));
        }
    }
}
