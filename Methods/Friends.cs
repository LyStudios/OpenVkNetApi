using Newtonsoft.Json;
using OpenVkNetApi.Models.FriendsModels;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Friends
    {
        private string AccessToken;
        private string InstanceUrl;
        OvkApi api = new OvkApi();
        //для использования методов не требующих авторизации
        public Friends() { }
        //для использования методов требующих авторизации
        public Friends(string token, string instance)
        {
            this.AccessToken = token;
            this.InstanceUrl = instance;
        }
        /// <summary>
        /// <c>Get</c> получает список друзей пользователя
        /// </summary>
        /// <param name="UserId">id пользователя, друзья которого будут получены</param>
        /// <param name="Offset"></param>
        /// <param name="Count">кол-во друзей</param>
        /// <returns></returns>
        public async Task<FriendsList> Get(int UserId, int Offset = 0, int Count = 100)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Friends.get?access_token={AccessToken}&user_id={UserId}&offset={Offset}&count={Count}")).response.ToObject(typeof(FriendsList));
        }
        /// <summary>
        /// <c>GetRequests</c> получает запросы в друзья
        /// </summary>
        /// <param name="Offset"></param>
        /// <param name="Count">кол-во запросов</param>
        /// <param name="Extended"></param>
        /// <returns></returns>
        public async Task<FriendRequestsList> GetRequests(int Offset = 0, int Count = 100, int Extended = 0)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Friends.getRequests?access_token={AccessToken}&extended={Extended}&offset={Offset}&count={Count}")).response.ToObject(typeof(FriendRequestsList));
        }
        /// <summary>
        /// <c>Add</c> добавляет пользователя в друзья
        /// </summary>
        /// <param name="UserId">id пользователя, который будет добавлен в друзья</param>
        /// <returns></returns>
        public async Task Add(string UserId)
        {
            await api.GetRequest($"{InstanceUrl}/method/Friends.add?access_token={AccessToken}&user_id={UserId}");
        }
        /// <summary>
        /// <c>Delete</c> удаляет пользователя из друзей
        /// </summary>
        /// <param name="UserId">id пользователя, который будет удалён из друзей</param>
        /// <returns></returns>
        public async Task Delete(string UserId)
        {
            await api.GetRequest($"{InstanceUrl}/method/Friends.delete?access_token={AccessToken}&user_id={UserId}");
        }
        /// <summary>
        /// <c>AreFriends</c> проверяет друзья ли вы с пользователями
        /// </summary>
        /// <param name="UserIds">id пользователей</param>
        /// <returns></returns>
        public async Task<AreFriends> AreFriends(string UserIds)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Friends.getRequests?access_token={AccessToken}&user_ids={UserIds}")).response.ToObject(typeof(AreFriends));
        }
    }
}
