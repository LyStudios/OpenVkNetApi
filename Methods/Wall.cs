using Newtonsoft.Json;
using OpenVkNetApi.Models.MessagesModels;
using OpenVkNetApi.Models.WallModels;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Wall
    {
        private string AccessToken;
        private string InstanceUrl;
        OvkApi api = new OvkApi();
        //для использования методов не требующих авторизации
        public Wall() { }
        //для использования методов требующих авторизации
        public Wall(string token, string instance)
        {
            this.AccessToken = token;
            this.InstanceUrl = instance;
        }
        public async Task<PostList> Get(int OwnerId, string Domain = "", int Offset = 0, int Count = 30, int Extended = 0)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Wall.get?access_token={AccessToken}&owner_id={OwnerId}&domain={Domain}&offset={Offset}&count={Count}&extended={Extended}")).response.ToObject(typeof(PostList));
        }
        public async Task<PostList> GetById(string Posts, int Extended = 0, string Fields = "")
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Wall.getById?access_token={AccessToken}&posts={Posts}&fields={Fields}&extended={Extended}")).response.ToObject(typeof(PostList));
        }
        public async Task<int> Post(string OwnerId, string Message = "", int FromGroup = 0, int Signed = 0)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Wall.post?access_token={AccessToken}&owner_id={OwnerId}&message={Message}&from_group={FromGroup}&signed={Signed}")).response.post_id.ToObject(typeof(int));
        }
    }
}
