using Newtonsoft.Json;
using OpenVkNetApi.Models.UsersModels;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Users
    {
        private string AccessToken;
        private string InstanceUrl;
        OvkApi api = new OvkApi();
        //для использования методов не требующих авторизации
        public Users() { }
        //для использования методов требующих авторизации
        public Users(string token, string instance)
        {
            this.AccessToken = token;
            this.InstanceUrl = instance;
        }
        /// <summary>
        /// <c>Get</c> возвращает расширенную информацию о пользователях
        /// </summary>
        /// <param name="UserIds">Перечисленные через запятую id пользователей или их короткие имена (screen_name). По умолчанию — id текущего пользователя</param>
        /// <param name="Fields">Список дополнительных полей профилей, которые необходимо вернуть</param>
        /// <param name="Offset">Смещение, необходимое для выборки определенного подмножества пользователей</param>
        /// <param name="Count">Кол-во пользователей, информацию о которых нужно получить</param>
        public async Task<User[]> Get(string UserIds = "0", string Fields = "verified,sex,has_photo,photo_max_orig,photo_max,photo_50,photo_100,photo_200,photo_200_orig,photo_400_orig,status,screen_name,friend_status,last_seen,music,movies,tv,books,city,interests", int Offset = 0, int Count = 100)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Users.get?access_token={AccessToken}&user_ids={UserIds}&fields={Fields}&offset={Offset}&count={Count}")).response.ToObject(typeof(User[]));
        }
        /// <summary>
        /// <c>GetFollowers</c> возвращает список id пользователей, которые являются подписчиками пользователя
        /// </summary>
        /// <param name="UserId">id пользователя</param>
        /// <param name="Fields">Список дополнительных полей профилей, которые необходимо вернуть</param>
        /// <param name="Offset">Смещение, необходимое для выборки определенного подмножества подписчиков</param>
        /// <param name="Count">Кол-во подписчиков, информацию о которых нужно получить</param>
        public async Task<UsersList> GetFollowers(string UserId, string Fields = "verified,sex,has_photo,photo_max_orig,photo_max,photo_50,photo_100,photo_200,photo_200_orig,photo_400_orig,status,screen_name,friend_status,last_seen,music,movies,tv,books,city,interests", int Offset = 0, int Count = 100)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Users.getFollowers?access_token={AccessToken}&user_id={UserId}&fields={Fields}&offset={Offset}&count={Count}")).response.ToObject(typeof(UsersList));
        }
        /// <summary>
        ///  <c>Search</c> возвращает список пользователей в соответствии с заданным критерием поиска
        /// </summary>
        /// <param name="q">Строка поискового запроса. Например, Turborium Turborium.</param>
        /// <param name="Fields">Список дополнительных полей профилей, которые необходимо вернуть</param>
        /// <param name="Offset">Смещение относительно первого найденного пользователя для выборки определенного подмножества</param>
        /// <param name="Count">Количество возвращаемых пользователей</param>
        public async Task<UsersList> Search(string q, string Fields = "verified,sex,has_photo,photo_max_orig,photo_max,photo_50,photo_100,photo_200,photo_200_orig,photo_400_orig,status,screen_name,friend_status,last_seen,music,movies,tv,books,city,interests", int Offset = 0, int Count = 100)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Users.search?access_token={AccessToken}&q={q}&fields={Fields}&offset={Offset}&count={Count}")).response.ToObject(typeof(UsersList));
        }
    }
}
