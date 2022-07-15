using Newtonsoft.Json;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Wall;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Wall
    {
        OVkApi api = new OVkApi();
        public async Task<GetModel> Get(AuthorizedUser user, string owner_id, int extended = 0, int offset = 0, int count = 30)
        {
            return JsonConvert.DeserializeObject<GetModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Wall.get?access_token={user.access_token}&owner_id={owner_id}&extended={extended}&offset={offset}&count={count}"));
        }
        public async Task<GetByIdModel> GetById(AuthorizedUser user, string posts, int extended = 0, string fields = "")
        {
            return JsonConvert.DeserializeObject<GetByIdModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Wall.getById?access_token={user.access_token}&posts={posts}&extended={extended}&fields={fields}"));
        }
        public async Task Post(AuthorizedUser user, string owner_id, string contentType = "photo", byte[] file = null, string message = "", int from_group = 0, int signed = 0)
        {
            if (file == null) {
                var content = new MultipartFormDataContent();
                content.Add(new StringContent(user.access_token), "access_token");
                content.Add(new StringContent(owner_id), "owner_id");
                content.Add(new StringContent(message), "message");
                content.Add(new StringContent(from_group.ToString()), "from_group");
                content.Add(new StringContent(signed.ToString()), "signed");
                var response = await new HttpClient().PostAsync($"{user.instanceUrl}/method/Wall.post", content);
            }
            else
            { 
                var content = new MultipartFormDataContent();
                content.Add(new StringContent(user.access_token), "access_token");
                content.Add(new StringContent(owner_id), "owner_id");
                content.Add(new StringContent(message), "message");
                content.Add(new StringContent(from_group.ToString()), "from_group");
                content.Add(new StringContent(signed.ToString()), "signed");
                content.Add(new ByteArrayContent(file), contentType);
                var response = await new HttpClient().PostAsync($"{user.instanceUrl}/method/Wall.post", content);
            }
        }
    }
}
