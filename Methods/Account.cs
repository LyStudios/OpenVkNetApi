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
        public async Task<ProfileInfo> GetProfileInfo()
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Account.getProfileInfo?access_token={AccessToken}")).response.ToObject(typeof(ProfileInfo));
        }
        /// <summary>
        /// <c>GetInfo</c> получает информацию
        /// </summary>
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
        public async Task<Counters> GetCounters()
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Account.getCounters?access_token={AccessToken}")).response.ToObject(typeof(Counters));
        }
        /// <summary>
        ///  <c>SaveProfileInfo</c> изменяет информацию в профиле
        /// </summary>
        /// <param name="FirstName">Имя</param>
        /// <param name="LastName">Фамилия</param>
        /// <param name="ScreenName">Ник</param>
        /// <param name="Sex">Пол</param>
        /// <param name="Relation">Семейное положение</param>
        /// <param name="Bdate">День рождения</param>
        /// <param name="BdateVisibility">Видимость дня рождения</param>
        /// <param name="HomeTown">Родной город</param>
        /// <param name="Status">Статус</param>
        public async Task SaveProfileInfo(string FirstName = "", string LastName = "", string ScreenName = "", int Sex = -1, int Relation = -1, string Bdate = "", int BdateVisibility = -1, string HomeTown = "", string Status = "")
        {
            await api.GetRequest($"{InstanceUrl}/method/Account.saveProfileInfo?access_token={AccessToken}&first_name={FirstName}&last_name={LastName}&screen_name={ScreenName}&sex={Sex}&relation={Relation}&bdate={Bdate}&bdate_visibility={BdateVisibility}&home_town={HomeTown}&status={Status}");
        }
    }
}
