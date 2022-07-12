using Newtonsoft.Json;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.OVKSpecific;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class OVKSpecificMethods
    {
        OVkApi api = new OVkApi();
        public async Task<VersionModel> GetVersion(AuthorizedUser user)
        {
            return JsonConvert.DeserializeObject<VersionModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Ovk.version"));
        }
        public async Task<TestModel> Test(AuthorizedUser user)
        {
            return JsonConvert.DeserializeObject<TestModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Ovk.test?access_token={user.access_token}"));
        }
        public async Task<ChickenWingsModel> ChickenWings(AuthorizedUser user)
        {
            return JsonConvert.DeserializeObject<ChickenWingsModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Ovk.chickenWings"));
        }
    }
}
