using Newtonsoft.Json;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Messages;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Messages
    {
        OVkApi api = new OVkApi();
        public async Task<GetByIdModel> GetById(AuthorizedUser user, string message_ids, int preview_length = 0, int extended = 0)
        {
            return JsonConvert.DeserializeObject<GetByIdModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Messages.getById?access_token={user.access_token}&message_ids={message_ids}&preview_length={preview_length}&extended={extended}"));
        }
        public async Task<SendMessageModel> Send(AuthorizedUser user, int user_id = -1, int peer_id = -1, string domain = "", int chat_id = -1, string user_ids = "", string message = "", int sticker_id = -1)
        {
            return JsonConvert.DeserializeObject<SendMessageModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Messages.send?access_token={user.access_token}&user_id={user_id}&peer_id={peer_id}&domain={domain}&chat_id={chat_id}&user_ids={user_ids}&message={message}&sticker_id={sticker_id}"));
        }
        public async Task Delete(AuthorizedUser user, string message_ids)
        {
            await api.GetRequestAsync($"{user.instanceUrl}/method/Messages.delete?access_token={user.access_token}&message_ids={message_ids}");
        }
        public async Task Restore(AuthorizedUser user, int message_id)
        {
            await api.GetRequestAsync($"{user.instanceUrl}/method/Messages.restore?access_token={user.access_token}&message_id={message_id}");
        }
        public async Task<GetConversationsModel> GetConversations(AuthorizedUser user, int offset = 0, int count = 20, string filter = "all", int extended = 0)
        {
            return JsonConvert.DeserializeObject<GetConversationsModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Messages.getConversations?access_token={user.access_token}&offset={offset}&count={count}&extended={extended}&filter={filter}"));
        }
        public async Task<GetHistoryModel> GetHistory(AuthorizedUser user, int offset = 0, int user_id = -1, int count = 20, int peer_id = -1, int start_message_id = 0, int rev = 0, int extended = 0)
        {
            return JsonConvert.DeserializeObject<GetHistoryModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Messages.getHistory?access_token={user.access_token}&offset={offset}&count={count}&extended={extended}&user_id={user_id}&peer_id={peer_id}&start_message_id={start_message_id}&rev={rev}"));
        }
    }
}
