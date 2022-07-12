using Newtonsoft.Json;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Utils;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Utils
    {
        OVkApi api = new OVkApi();
        public async Task<GetServerTimeModel> GetServerTime(AuthorizedUser user)
        {
            return JsonConvert.DeserializeObject<GetServerTimeModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Utils.getServerTime"));
        }
    }
}
