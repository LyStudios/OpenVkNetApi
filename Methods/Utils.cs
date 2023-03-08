using Newtonsoft.Json;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Utils
    {
        private string AccessToken;
        private string InstanceUrl;
        OvkApi api = new OvkApi();
        //для использования методов не требующих авторизации
        public Utils() { }
        //для использования методов требующих авторизации
        public Utils(string token, string instance)
        {
            this.AccessToken = token;
            this.InstanceUrl = instance;
        }
        /// <summary>
        /// <c>GetServerTime</c> возвращает время на сервере
        /// </summary>
        public async Task<string> GetServerTime()
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Utils.getServerTime")).response.ToObject(typeof(string));
        }
    }
}
