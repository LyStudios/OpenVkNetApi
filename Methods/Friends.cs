using Newtonsoft.Json;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Friends;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Friends
    {
        OVkApi api = new OVkApi();
        /// <summary>
        /// Возвращает список друзей пользователя
        /// </summary>
        /// <param name="user">Авторизованный пользователь(можно получить при авторизации)</param>
        /// <param name="user_id">id пользователя, друзей которого нужно получить</param>
        /// <param name="fields">хз ваще, что эт такое, в доках не расписано</param>
        /// <param name="offset">хз ваще, что эт такое, в доках не расписано</param>
        /// <param name="count">количество друзей, которое нужно получить</param>
        public async Task<GetFriendsModel> Get(AuthorizedUser user, int user_id, string fields="", int offset=0, int count=100)
        {
            return JsonConvert.DeserializeObject<GetFriendsModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Friends.get?access_token={user.access_token}&user_id={user_id}&offset={offset}&count={count}&fields={fields}"));
        }
        /// <summary>
        /// Добавить в друзья
        /// </summary>
        /// <param name="user">Авторизованный пользователь(можно получить при авторизации)</param>
        /// <param name="user_id">id пользователя, которого нужно добавить в друзья</param>
        /// <returns></returns>
        public async Task<AddFriendsModel> Add(AuthorizedUser user, int user_id)
        {
        	return JsonConvert.DeserializeObject<AddFriendsModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Friends.add?access_token={user.access_token}&user_id={user_id}"));
        }
        /// <summary>
        /// Удалить из друзей
        /// </summary>
        /// <param name="user">Авторизованный пользователь(можно получить при авторизации)</param>
        /// <param name="user_id">id пользователя, которого нужно удалить из друзей</param>
        /// <returns></returns>
        public async Task<int> Remove(AuthorizedUser user, int user_id)
        {
            await api.GetRequestAsync($"{user.instanceUrl}/method/Friends.remove?access_token={user.access_token}&user_id={user_id}");
            return 1;
        }
        /// <summary>
        /// Глупая функция, всегда возвращает 0
        /// </summary>
        /// <param name="user">Авторизованный пользователь(можно получить при авторизации)</param>
        /// <returns></returns>
        public async Task<GetListsModel> GetLists(AuthorizedUser user)
        {
            return JsonConvert.DeserializeObject<GetListsModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Friends.getLists?access_token={user.access_token}"));
        }
        /// <summary>
        /// Глупая функция, всегда возвращает 1
        /// </summary>
        /// <param name="user">Авторизованный пользователь(можно получить при авторизации)</param>
        /// <returns></returns>
        public async Task<int> Edit(AuthorizedUser user)
        {
            return 1;
        }
        /// <summary>
        /// Глупая функция, всегда возвращает 1
        /// </summary>
        /// <param name="user">Авторизованный пользователь(можно получить при авторизации)</param>
        /// <returns></returns>
        public async Task<int> DeleteList(AuthorizedUser user)
        {
            return 1;
        }
        /// <summary>
        /// Глупая функция, всегда возвращает 1
        /// </summary>
        /// <param name="user">Авторизованный пользователь(можно получить при авторизации)</param>
        /// <returns></returns>
        public async Task<int> EditList(AuthorizedUser user)
        {
            return 1;
        }
    }
}
