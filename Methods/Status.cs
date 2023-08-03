using Newtonsoft.Json;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Status
    {
        private string AccessToken;
        private string InstanceUrl;
        OvkApi api = new OvkApi();
        public Status(string token, string instance)
        {
            this.AccessToken = token;
            this.InstanceUrl = instance;
        }
        public async Task Set(string Text)
        {
            await api.GetRequest($"{InstanceUrl}/method/Status.set?access_token={AccessToken}&text={Text}");
        }
        public async Task<string> Get(string User_Id = null)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Status.set?access_token={AccessToken}&user_id={User_Id}")).response.ToObject(typeof(string));
        }
    }
}
