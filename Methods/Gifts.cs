using Newtonsoft.Json;
using OpenVkNetApi.Models.GiftsModels;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Gifts
    {
        private string AccessToken;
        private string InstanceUrl;
        OvkApi api = new OvkApi();
        public Gifts(string token, string instance)
        {
            this.AccessToken = token;
            this.InstanceUrl = instance;
        }
        public async Task<UserGift[]> Get(string User_Id, int Offset = 0, int Count = 10)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Gifts.set?access_token={AccessToken}&user_id={User_Id}&offset={Offset}&count={Count}")).response.ToObject(typeof(UserGift[]));
        }
        public async Task<Gift[]> GetGiftsInCategory(string Id, int Page = 1)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Gifts.getGiftsInCategory?access_token={AccessToken}&id={Id}&page={Page}")).response.ToObject(typeof(Gift[]));
        }
        public async Task<GiftCategory[]>GetCategories(int Extended = 0, int Page = 1)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Gifts.getCategories?access_token={AccessToken}&extended={Extended}&page={Page}")).response.ToObject(typeof(GiftCategory[]));
        }
        public async Task<SendResponse> Send(string User_Ids, int Gift_Id, string Message = "", int Privacy = 0)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Gifts.send?access_token={AccessToken}&user_ids={User_Ids}&gift_id={Gift_Id}&message={Message}&privacy={Privacy}")).response.ToObject(typeof(SendResponse));
        }
    }
}
