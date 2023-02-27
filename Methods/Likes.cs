using Newtonsoft.Json;
using OpenVkNetApi.Models.LikesModels;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Likes
    {
        private string AccessToken;
        private string InstanceUrl;
        OvkApi api = new OvkApi();
        //для использования методов не требующих авторизации
        public Likes() { }
        //для использования методов требующих авторизации
        public Likes(string token, string instance)
        {
            this.AccessToken = token;
            this.InstanceUrl = instance;
        }
        /// <summary>
        /// <c>Add</c> ставит лайк на объект
        /// </summary>
        /// <param name="OwnerId">id автора</param>
        /// <param name="ItemId">id объекта</param>
        /// <param name="Type">тип объекта</param>
        /// <returns>Кол-во лайков</returns>
        public async Task<Like> Add(int OwnerId, int ItemId, string Type = "post")
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Likes.add?access_token={AccessToken}&type={Type}&owner_id={OwnerId}&item_id={ItemId}")).response.ToObject(typeof(Like));
        }
        /// <summary>
        /// <c>Delete</c> убирает лайк
        /// </summary>
        /// <param name="OwnerId">id автора</param>
        /// <param name="ItemId">id объекта</param>
        /// <param name="Type">тип объекта</param>
        /// <returns>Кол-во лайков</returns>
        public async Task<Like> Delete(int OwnerId, int ItemId, string Type = "post")
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Likes.delete?access_token={AccessToken}&type={Type}&owner_id={OwnerId}&item_id={ItemId}")).response.ToObject(typeof(Like));
        }
        /// <summary>
        /// <c>IsLiked</c> проверяет, лайкнут ли объект
        /// </summary>
        /// <param name="OwnerId">id автора</param>
        /// <param name="ItemId">id объекта</param>
        /// <param name="Type">тип объекта</param>
        /// <param name="UserId">id лайкнувшего</param>
        public async Task<IsLiked> IsLiked(int OwnerId, int ItemId, int UserId, string Type = "post")
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Likes.isLiked?access_token={AccessToken}&type={Type}&user_id={UserId}&owner_id={OwnerId}&item_id={ItemId}")).response.ToObject(typeof(IsLiked));
        }
    }
}
