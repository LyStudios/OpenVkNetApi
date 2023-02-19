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
        /// <param name="Owner_Id">id автора</param>
        /// <param name="Item_Id">id объекта</param>
        /// <param name="Type">тип объекта</param>
        /// <returns>Кол-во лайков</returns>
        public async Task<Like> Add(int Owner_Id, int Item_Id, string Type = "post")
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Likes.add?access_token={AccessToken}&type={Type}&owner_id={Owner_Id}&item_id={Item_Id}")).response.ToObject(typeof(Like));
        }
        /// <summary>
        /// <c>Delete</c> убирает лайк
        /// </summary>
        /// <param name="Owner_Id">id автора</param>
        /// <param name="Item_Id">id объекта</param>
        /// <param name="Type">тип объекта</param>
        /// <returns>Кол-во лайков</returns>
        public async Task<Like> Delete(int Owner_Id, int Item_Id, string Type = "post")
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Likes.delete?access_token={AccessToken}&type={Type}&owner_id={Owner_Id}&item_id={Item_Id}")).response.ToObject(typeof(Like));
        }
        /// <summary>
        /// <c>IsLiked</c> проверяет, лайкнут ли объект
        /// </summary>
        /// <param name="Owner_Id">id автора</param>
        /// <param name="Item_Id">id объекта</param>
        /// <param name="Type">тип объекта</param>
        /// <param name="User_Id">id лайкнувшего</param>
        public async Task<IsLiked> IsLiked(int Owner_Id, int Item_Id, int User_Id, string Type = "post")
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Likes.isLiked?access_token={AccessToken}&type={Type}&user_id={User_Id}&owner_id={Owner_Id}&item_id={Item_Id}")).response.ToObject(typeof(IsLiked));
        }
    }
}
