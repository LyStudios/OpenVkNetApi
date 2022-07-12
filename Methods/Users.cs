using Newtonsoft.Json;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Users;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Users
    {
        OVkApi api = new OVkApi();
        public async Task<GetModel> Get(AuthorizedUser user, string user_ids = "0", string fields = "", int offset = 0, int count = 100)
        {
            return JsonConvert.DeserializeObject<GetModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Users.get?access_token={user.access_token}&user_ids={user_ids}&fields={fields}&offset={offset}&count={count}"));
        }
        public async Task<GetFollowersModel> GetFollowers(AuthorizedUser user, int user_id, string fields = "", int offset = 0, int count = 100)
        {
            return JsonConvert.DeserializeObject<GetFollowersModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Users.getFollowers?access_token={user.access_token}&user_ids={user_id}&fields={fields}&offset={offset}&count={count}"));
        }
        public async Task<SearchModel> Search(AuthorizedUser user, string q, string fields = "", int offset = 0, int count = 100)
        {
            return JsonConvert.DeserializeObject<SearchModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Users.search?access_token={user.access_token}&q={q}&offset={offset}&count={count}&fields={fields}"));
        }
    }
}
