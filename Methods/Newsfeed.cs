using Newtonsoft.Json;
using OpenVkNetApi.Models.NewsfeedModels;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Newsfeed
    {
        private string AccessToken;
        private string InstanceUrl;
        OvkApi api = new OvkApi();
        public Newsfeed(string token, string instance)
        {
            this.AccessToken = token;
            this.InstanceUrl = instance;
        }
        public async Task<NewsfeedList> Get(string Fields = "", int Start_From = 0, int Start_Time = 0, int End_Time = 0, int Offset = 0, int Count = 30, int Extended = 0, int ForGodSakePleaseDoNotReportAboutMyOnlineActivity = 0)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Newsfeed.get?access_token={AccessToken}&fields={Fields}&start_from={Start_From}&start_time={Start_Time}&end_time={End_Time}&offset={Offset}&count={Count}&extended={Extended}&forGodSakePleaseDoNotReportAboutMyOnlineActivity={ForGodSakePleaseDoNotReportAboutMyOnlineActivity}")).response.ToObject(typeof(NewsfeedList));
        }
        public async Task<NewsfeedList> GetGlobal(string Fields = "", int Start_From = 0, int Start_Time = 0, int End_Time = 0, int Offset = 0, int Count = 30, int Extended = 0, int ForGodSakePleaseDoNotReportAboutMyOnlineActivity = 0)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Newsfeed.getGlobal?access_token={AccessToken}&fields={Fields}&start_from={Start_From}&start_time={Start_Time}&end_time={End_Time}&offset={Offset}&count={Count}&extended={Extended}&forGodSakePleaseDoNotReportAboutMyOnlineActivity={ForGodSakePleaseDoNotReportAboutMyOnlineActivity}")).response.ToObject(typeof(NewsfeedList));
        }
    }
}
