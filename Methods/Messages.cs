using Newtonsoft.Json;
using OpenVkNetApi.Models.GroupsModels;
using OpenVkNetApi.Models.MessagesModels;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Messages
    {
        private string AccessToken;
        private string InstanceUrl;
        OvkApi api = new OvkApi();
        //для использования методов не требующих авторизации
        public Messages() { }
        //для использования методов требующих авторизации
        public Messages(string token, string instance)
        {
            this.AccessToken = token;
            this.InstanceUrl = instance;
        }
        public async Task<int> Send(int UserId = -1, int PeerId = -1, string Domain = "", int ChatId = -1, string UserIds = "", string Message = "", int StickerId = -1)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Messages.send?access_token={AccessToken}&user_id={UserId}&peer_id={PeerId}&domain={Domain}&chat_id={ChatId}&user_ids={UserIds}&message={Message}&sticker_id={StickerId}")).response.ToObject(typeof(int));
        }
        public async Task Delete(string MessageIds)
        {
            await api.GetRequest($"{InstanceUrl}/method/Messages.delete?access_token={AccessToken}&message_ids={MessageIds}");
        }
        public async Task Restore(string MessageId)
        {
            await api.GetRequest($"{InstanceUrl}/method/Messages.restore?access_token={AccessToken}&message_id={MessageId}");
        }
        public async Task<MessageList> GetById(string MessageIds, int PreviewLength = 0, int Extended = 0)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Messages.getById?access_token={AccessToken}&message_ids={MessageIds}&preview_length={PreviewLength}&extended={Extended}")).response.ToObject(typeof(MessageList));
        }
        public async Task<ConversationsList> GetConversations(int Offset = 0, int Count = 20, string Filter = "all", int Extended = 0)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Messages.getConversations?access_token={AccessToken}&offset={Offset}&count={Count}&filter={Filter}&extended={Extended}")).response.ToObject(typeof(MessageList));
        }
    }
}
