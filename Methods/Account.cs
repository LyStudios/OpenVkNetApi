using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Account;

namespace OpenVkNetApi.Methods
{
    public class Account
    {
        OVkApi api = new OVkApi();
        public async Task<ProfileInfoModel> GetProfileInfo(AuthorizedUser user)
        {
            return JsonConvert.DeserializeObject<ProfileInfoModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Account.getProfileInfo?access_token={user.access_token}"));
        }
        //я не знаю зачем я реализую заглушку
        public async Task<InfoModel> GetInfo(AuthorizedUser user)
        {
            return JsonConvert.DeserializeObject<InfoModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Account.getInfo?access_token={user.access_token}"));
        }
        public async Task<int> SetOnline(AuthorizedUser user)
        {
            await api.GetRequestAsync($"{user.instanceUrl}/method/Account.setOnline?access_token={user.access_token}");
            return 1;
        }
        //тоже заглушка
        public async Task<int> SetOffline(AuthorizedUser user)
        {
            await api.GetRequestAsync($"{user.instanceUrl}/method/Account.setOffline?access_token={user.access_token}");
            return 1;
        }
        public async Task<int> GetAppPermissions(AuthorizedUser user)
        {
            await api.GetRequestAsync($"{user.instanceUrl}/method/Account.getAppPermissions?access_token={user.access_token}");
            return 9355263;
        }
        public async Task<CountersModel> GetCounters(AuthorizedUser user)
        {
            return JsonConvert.DeserializeObject<CountersModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Account.getCounters?access_token={user.access_token}"));
        }
    }
}
