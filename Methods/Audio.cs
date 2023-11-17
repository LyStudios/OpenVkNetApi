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
        public async Task<AudioModel> Search(string Q, int Auto_Complete = 0, int Search_Own = 0, int Lyrics = 0, int Performer_Only = 0, int Sort = 0, int Offset = 0, int Count = 30, string Hash = "")
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Audio.search?access_token={AccessToken}&q={Q}&auto_complete={Auto_Complete}&search_own={Search_Own}&lyrics={Lyrics}&performer_only={Performer_Only}&sort={Sort}&offset={Offset}&count={Count}&hash={Hash}")).response.ToObject(typeof(AudioModel));
        }
        public async Task<AudioModel> Get(int Owner_Id = 0, int Album_Id = 0, string Audio_Ids = "", int Need_User = 1, int Offset = 0, int Count = 100, int Uploaded_Only = 0, int Need_Seed = 0, string Shuffle_Seed = "", int Shuffle = 0, string Hash = "")
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Audio.search?access_token={AccessToken}&owner_id={Owner_Id}&album_id={Album_Id}&audio_ids={Audio_Ids}&need_user={Need_User}&offset={Offset}&count={Count}&uploaded_only={Uploaded_Only}&need_seed={Need_Seed}&shuffle_seed={Shuffle_Seed}&shuffle={Shuffle}&hash={Hash}")).response.ToObject(typeof(AudioModel));
        }
    }
}
