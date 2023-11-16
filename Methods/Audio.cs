using Newtonsoft.Json;
using OpenVkNetApi.Models.AudioModels;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Audio
    {
        private string AccessToken;
        private string InstanceUrl;
        OvkApi api = new OvkApi();
        //для использования методов не требующих авторизации
        public Audio() { }
        //для использования методов требующих авторизации
        public Audio(string token, string instance)
        {
            this.AccessToken = token;
            this.InstanceUrl = instance;
        }
        public async Task<SearchModel> Search(string Q, int Auto_Complete = 0, int Search_Own = 0, int Lyrics = 0, int Performer_Only = 0, int Sort = 0, int Offset = 0, int Count = 30, string Hash = "")
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Audio.search?access_token={AccessToken}&q={Q}&auto_complete={Auto_Complete}&search_own={Search_Own}&lyrics={Lyrics}&performer_only={Performer_Only}&sort={Sort}&offset={Offset}&count={Count}&hash={Hash}")).response.ToObject(typeof(SearchModel));
        }
    }
}
