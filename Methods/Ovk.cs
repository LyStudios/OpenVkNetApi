using Newtonsoft.Json;
using OpenVkNetApi.Models.OvkModels;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Ovk
    {
        private string AccessToken;
        private string InstanceUrl;
        OvkApi api = new OvkApi();
        //для использования методов не требующих авторизации
        public Ovk() { }
        //для использования методов требующих авторизации
        public Ovk(string token, string instance)
        {
            this.AccessToken = token;
            this.InstanceUrl = instance;
        }
        /// <summary>
        /// <c>Version</c> возвращает версию OpenVK
        /// </summary>
        public async Task<string> Version()
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Ovk.version")).response.ToObject(typeof(string));
        }
        /// <summary>
        /// <c>Test</c> возвращает информацию о токене доступа
        /// </summary>
        public async Task<Test> Test()
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Ovk.test?access_token={AccessToken}")).response.ToObject(typeof(Test));
        }
        /// <summary>
        ///  крильця)
        /// </summary>
        public async Task<string> ChickenWings()
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Ovk.chickenWings")).response.ToObject(typeof(string));
        }
    }
}
