using Newtonsoft.Json;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Groups;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Groups
    {
        OVkApi api = new OVkApi();
        public async Task<GetGroupsModel> Get(AuthorizedUser user, int user_id, int offset = 0, int count = 6, string fields = "")
        {
            return JsonConvert.DeserializeObject<GetGroupsModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Groups.get?access_token={user.access_token}&user_id={user_id}&offset={offset}&count={count}&fields={fields}"));
        }
        public async Task<GetGroupByIdModel> GetById(AuthorizedUser user, string groups_ids = null, string group_id = null, string fields = "")
        {
            if (groups_ids == null)
            {
                return JsonConvert.DeserializeObject<GetGroupByIdModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Groups.getById?access_token={user.access_token}&group_id={group_id}&fields={fields}"));
            }
            else
            {
                return JsonConvert.DeserializeObject<GetGroupByIdModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Groups.getById?access_token={user.access_token}&groups_ids={groups_ids}&fields={fields}"));
            }
        }
    }
}
