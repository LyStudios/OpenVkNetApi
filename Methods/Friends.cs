using Newtonsoft.Json;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Friends;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Friends
    {
        OVkApi api = new OVkApi();
        public async Task<GetFriendsModel> Get(AuthorizedUser user, int user_id, string fields="", int offset=0, int count=100)
        {
            return JsonConvert.DeserializeObject<GetFriendsModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Friends.get?access_token={user.access_token}&user_id={user_id}&offset={offset}&count={count}&fields={fields}"));
        }
        public async Task<int> Add(AuthorizedUser user, int user_id){
        	return JsonConvert.DeserializeObject<AddFriendsModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Friends.add?access_token={user.access_token}&user_id={user_id}"));
        }
    }
}
