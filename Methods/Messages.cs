using Newtonsoft.Json;
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
        /// <summary>
        /// <c>Send</c> отправляет сообщение
        /// </summary>
        /// <param name="UserId">id пользователя, которому отправляется сообщение</param>
        /// <param name="PeerId">id получателя сообщения</param>
        /// <param name="Domain">короткий адрес пользователя</param>
        /// <param name="ChatId">id беседы, в которую отправляется сообщение</param>
        /// <param name="UserIds">id получателей сообщения, перечисленные через запятую</param>
        /// <param name="Message">текст личного сообщения</param>
        /// <param name="StickerId">id  стикера(???)</param>
        public async Task<int> Send(int UserId = -1, int PeerId = -1, string Domain = "", int ChatId = -1, string UserIds = "", string Message = "", int StickerId = -1)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Messages.send?access_token={AccessToken}&user_id={UserId}&peer_id={PeerId}&domain={Domain}&chat_id={ChatId}&user_ids={UserIds}&message={Message}&sticker_id={StickerId}")).response.ToObject(typeof(int));
        }
        /// <summary>
        /// <c>Delete</c> удаляет сообщения
        /// </summary>
        /// <param name="MessageIds">список id сообщений, разделённых через запятую</param>
        public async Task Delete(string MessageIds)
        {
            await api.GetRequest($"{InstanceUrl}/method/Messages.delete?access_token={AccessToken}&message_ids={MessageIds}");
        }
        /// <summary>
        /// <c>Restore</c> восстанавливает сообщение
        /// </summary>
        /// <param name="MessageId">id сообщения, которое нужно восстановить</param>
        public async Task Restore(string MessageId)
        {
            await api.GetRequest($"{InstanceUrl}/method/Messages.restore?access_token={AccessToken}&message_id={MessageId}");
        }
        /// <summary>
        /// <c>GetById</c> получает сообщения по id
        /// </summary>
        /// <param name="MessageIds">id сообщений</param>
        /// <param name="PreviewLength">количество символов, по которому нужно обрезать сообщение</param>
        /// <param name="Extended">1 — возвращать дополнительные поля</param>
        public async Task<MessageList> GetById(string MessageIds, int PreviewLength = 0, int Extended = 0)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Messages.getById?access_token={AccessToken}&message_ids={MessageIds}&preview_length={PreviewLength}&extended={Extended}")).response.ToObject(typeof(MessageList));
        }
        /// <summary>
        /// <c>GetConversations</c> возвращает список бесед пользователя
        /// </summary>
        /// <param name="Offset">смещение, необходимое для выборки определенного подмножества бесед</param>
        /// <param name="Count">количество бесед, которое необходимо получить</param>
        /// <param name="Filter">типы бесед, которые нужно вернуть, перечисленные через запятую</param>
        /// <param name="Extended">если указать в качестве этого параметра 1, то будет возвращена информация о пользователях и сообществах(из доков вк, как оно работает в овк - хз)</param>
        public async Task<ConversationsList> GetConversations(int Offset = 0, int Count = 20, string Filter = "all", int Extended = 0)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Messages.getConversations?access_token={AccessToken}&offset={Offset}&count={Count}&filter={Filter}&extended={Extended}")).response.ToObject(typeof(MessageList));
        }
        /// <summary>
        /// <c>GetConversationsById</c> позволяет получить беседу по её id
        /// </summary>
        /// <param name="PeerIds">id назначений, разделённые запятой</param>
        /// <param name="Extended">1 — возвращать дополнительные поля</param>
        /// <param name="Fields">дополнительные поля пользователей и сообществ, которые необходимо вернуть в ответе</param>
        public async Task<ConversationsByIdList> GetConversationsById(string PeerIds, int Extended = 0, string Fields = "")
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Messages.getConversationsById?access_token={AccessToken}&peer_ids={PeerIds}&fields={Fields}&extended={Extended}")).response.ToObject(typeof(MessageList));
        }
        /// <summary>
        /// <c>GetHistory</c> возвращает историю сообщений для указанного диалога
        /// </summary>
        /// <param name="Offset">смещение, необходимое для выборки определённого подмножества сообщений</param>
        /// <param name="Count">количество сообщений, которое необходимо получить</param>
        /// <param name="UserId">id пользователя, историю переписки с которым необходимо вернуть</param>
        /// <param name="PeerId">id назначения</param>
        /// <param name="StartMessageId">если значение > 0, то это идентификатор сообщения, начиная с которого нужно вернуть историю переписки, если передано передано значение -1, то к значению параметра offset прибавляется количество входящих непрочитанных сообщений в конце диалога</param>
        /// <param name="Rev">1 — возвращать сообщения в хронологическом порядке. 0 — возвращать сообщения в обратном хронологическом порядке (по умолчанию).</param>
        public async Task<MessageList> GetHistory(int Offset = 0, int Count = 20, int UserId = -1, int PeerId = -1, int StartMessageId = 0, int Rev = 0)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Messages.getHistory?access_token={AccessToken}&offset={Offset}&count={Count}&user_id={UserId}&peer_id={PeerId}&start_message_id={StartMessageId}&rev={Rev}")).response.ToObject(typeof(MessageList));
        }
        /// <summary>
        /// <c>GetLongpollServer</c> возвращает данные, необходимые для подключения к Long Poll серверу
        /// </summary>
        /// <param name="NeedPts">1 — возвращать поле pts, необходимое для работы метода messages.getLongPollHistory</param>
        /// <param name="LpVersion">id сообщества (для сообщений сообщества с ключом доступа пользователя)</param>
        /// <param name="GroupId">версия для подключения к Long Poll. Актуальная версия: 3</param>
        public async Task<LongpollServer> GetLongpollServer(int NeedPts = 1, int LpVersion = 3, string GroupId = null)
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Messages.getLongpollServer?access_token={AccessToken}&need_pts={NeedPts}&lp_version={LpVersion}&group_id={GroupId}")).response.ToObject(typeof(LongpollServer));
        }
    }
}
