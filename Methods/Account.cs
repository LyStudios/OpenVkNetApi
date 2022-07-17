using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Account;

namespace OpenVkNetApi.Methods
{
    public class Account
    {
        OVkApi api = new OVkApi();
        /// <summary>
        /// Возвращает информацию о пользователе
        /// </summary>
        /// <param name="user">Авторизованный пользователь(можно получить при авторизации)</param>
        public async Task<ProfileInfoModel> GetProfileInfo(AuthorizedUser user)
        {
            return JsonConvert.DeserializeObject<ProfileInfoModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Account.getProfileInfo?access_token={user.access_token}"));
        }
        /// <summary>
        /// Оно вроде как тоже возвращает какую-то инфу о пользователе, но этот метод является затычкой(https://docs.openvk.su/openvk_engine/api/description/#getinfo)
        /// </summary>
        /// <param name="user">Авторизованный пользователь(можно получить при авторизации)</param>
        //я не знаю зачем я реализую заглушку
        public async Task<InfoModel> GetInfo(AuthorizedUser user)
        {
            return JsonConvert.DeserializeObject<InfoModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Account.getInfo?access_token={user.access_token}"));
        }
        /// <summary>
        /// Обновляет пользователю онлайн-статус
        /// </summary>
        /// <param name="user">Авторизованный пользователь(можно получить при авторизации)</param>
        public async Task<int> SetOnline(AuthorizedUser user)
        {
            await api.GetRequestAsync($"{user.instanceUrl}/method/Account.setOnline?access_token={user.access_token}");
            return 1;
        }
        /// <summary>
        /// Глупая функция, всегда возвращает 1(https://docs.openvk.su/openvk_engine/api/description/#setoffline)
        /// </summary>
        /// <param name="user">Авторизованный пользователь(можно получить при авторизации)</param>
        //тоже заглушка
        public async Task<int> SetOffline(AuthorizedUser user)
        {
            await api.GetRequestAsync($"{user.instanceUrl}/method/Account.setOffline?access_token={user.access_token}");
            return 1;
        }
        /// <summary>
        /// Глупая функция, всегда возвращает 9355263(https://docs.openvk.su/openvk_engine/api/description/#getapppermissions)
        /// </summary>
        /// <param name="user">Авторизованный пользователь(можно получить при авторизации)</param>
        public async Task<int> GetAppPermissions(AuthorizedUser user)
        {
            await api.GetRequestAsync($"{user.instanceUrl}/method/Account.getAppPermissions?access_token={user.access_token}");
            return 9355263;
        }
        /// <summary>
        /// Возвращает счетчики непрочитанных сообщений, уведомлений и запросов друзей.
        /// </summary>
        /// <param name="user">Авторизованный пользователь(можно получить при авторизации)</param>
        public async Task<CountersModel> GetCounters(AuthorizedUser user)
        {
            return JsonConvert.DeserializeObject<CountersModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Account.getCounters?access_token={user.access_token}"));
        }
    }
}
