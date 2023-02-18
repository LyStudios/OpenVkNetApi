using Newtonsoft.Json;
using OpenVkNetApi.Models.GroupsModels;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Groups
    {
        private string AccessToken;
        private string InstanceUrl;
        OvkApi api = new OvkApi();
        //для использования методов не требующих авторизации
        public Groups() { }
        //для использования методов требующих авторизации
        public Groups(string token, string instance)
        {
            this.AccessToken = token;
            this.InstanceUrl = instance;
        }
        /// <summary>
        /// <c>Get</c> получает группы пользователя
        /// </summary>
        /// <param name="UserId">id пользователя, группы которого будут получены</param>
        /// <param name="Offset">Смещение, необходимое для выборки определённого подмножества результатов поиска. По умолчанию — 0.</param>
        /// <param name="Count">кол-во групп</param>
        /// <param name="Fields">Список дополнительных полей, которые необходимо вернуть.</param>
        /// <returns></returns>
        public async Task<GroupsList> Get(int UserId=0, int Offset = 0, int Count = 100, string Fields = "verified,has_photo,photo_max_orig,photo_max,photo_50,photo_100,photo_200,photo_200_orig,photo_400_orig,members_count")
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Groups.get?access_token={AccessToken}&user_id={UserId}&offset={Offset}&count={Count}&fields={Fields}")).response.ToObject(typeof(GroupsList));
        }
        /// <summary>
        /// <c>GetById</c> получает группы по id
        /// </summary>
        /// <param name="Group_Ids">id групп, которые будут получены</param>
        /// <param name="Offset">Смещение, необходимое для выборки определённого подмножества результатов поиска. По умолчанию — 0.</param>
        /// <param name="Count">кол-во групп</param>
        /// <param name="Fields">Список дополнительных полей, которые необходимо вернуть.</param>
        /// <returns></returns>
        public async Task<Group[]> GetById(string Group_Ids = "", int Offset = 0, int Count = 500, string Fields = "verified,has_photo,photo_max_orig,photo_max,photo_50,photo_100,photo_200,photo_200_orig,photo_400_orig,members_count,site,description,contacts,can_post,is_member")
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Groups.getById?access_token={AccessToken}&group_ids={Group_Ids}&offset={Offset}&count={Count}&fields={Fields}")).response.ToObject(typeof(Group[]));
        }
        /// <summary>
        /// <c>Search</c> получает найденные группы
        /// </summary>
        /// <param name="Q">текст поискового запроса</param>
        /// <param name="Offset">Смещение, необходимое для выборки определённого подмножества результатов поиска. По умолчанию — 0.</param>
        /// <param name="Count">кол-во групп</param>
        /// <returns></returns>
        public async Task<GroupsList> Search(string Q, int Offset = 0, int Count = 100)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Groups.search?access_token={AccessToken}&q={Q}&offset={Offset}&count={Count}")).response.ToObject(typeof(GroupsList));
        }
        /// <summary>
        /// <c>Join</c> вступает в группу
        /// </summary>
        /// <param name="Group_Id">id группы</param>
        public async Task Join(int Group_Id)
        {
            await api.GetRequest($"{InstanceUrl}/method/Groups.join?access_token={AccessToken}&group_id={Group_Id}");
        }
        /// <summary>
        /// <c>Leave</c> покидает группу
        /// </summary>
        /// <param name="Group_Id">id группы</param>
        public async Task Leave(int Group_Id)
        {
            await api.GetRequest($"{InstanceUrl}/method/Groups.leave?access_token={AccessToken}&group_id={Group_Id}");
        }
    }
}
