using Newtonsoft.Json;
using OpenVkNetApi.Models.AccountModels;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Account
    {
        private string AccessToken;
        private string InstanceUrl;
        OvkApi api = new OvkApi();
        //для использования методов не требующих авторизации
        public Account() { }
        //для использования методов требующих авторизации
        public Account(string token, string instance)
        {
            this.AccessToken = token;
            this.InstanceUrl = instance;
        }
        /// <summary>
        /// <c>GetProfileInfo</c> получает информацию из профиля
        /// </summary>
        /// <returns>Класс <c>ProfileInfo</c> с информацией из профиля</returns>
        public async Task<ProfileInfo> GetProfileInfo()
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Account.getProfileInfo?access_token={AccessToken}")).response.ToObject(typeof(ProfileInfo));
        }
        /// <summary>
        /// <c>GetInfo</c> получает информацию
        /// </summary>
        /// <returns>Класс <c>Info</c> с информацией </returns>
        public async Task<Info> GetInfo()
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Account.getInfo?access_token={AccessToken}")).response.ToObject(typeof(Info));
        }
        /// <summary>
        /// <c>SetOnline</c> выводит аккаунт в онлайн
        /// </summary>
        public async Task SetOnline()
        {
            await api.GetRequest($"{InstanceUrl}/method/Account.setOnline?access_token={AccessToken}");
        }
        /// <summary>
        /// <c>SetOffline</c> выводит аккаунт из онлайна
        /// </summary>
        public async Task SetOffline()
        {
            await api.GetRequest($"{InstanceUrl}/method/Account.setOffline?access_token={AccessToken}");
        }
        /// <summary>
        /// Фиктивная функция(так в доках овк написано)
        /// </summary>
        /// <returns>Всегда возвращает 9355263</returns>
        public async Task<int> GetAppPermissions()
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Account.getAppPermissions")).response.ToObject(typeof(int));
        }
        /// <summary>
        /// <c>GetCounters</c> получает кол-во непрочитанных сообщений, уведомлений и запросов в друзья
        /// </summary>
        /// <returns>Класс <c>Counters</c> с кол-вом непрочитанных уведомлений и т.д.</returns>
        public async Task<Counters> GetCounters()
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Account.getCounters?access_token={AccessToken}")).response.ToObject(typeof(Counters));
        }
    }
}
