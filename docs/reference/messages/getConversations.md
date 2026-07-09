<div class="vk-card">

# messages.getConversations

Возвращает список диалогов и бесед (активных бесед) текущего пользователя.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя с правами доступа к сообщениям.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Messages;

var parameters = new MessagesGetConversationsParams
{
    Count = 10,
    Offset = 0,
    Filter = "all"
};

var conversations = await api.Messages.GetConversationsAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `MessagesGetConversationsParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **Count** <br> `int` | Количество возвращаемых бесед/диалогов. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20, максимум: 200</span> |
| **Offset** <br> `int` | Смещение для выборки определенного подмножества бесед. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Filter** <br> `string` | Фильтр диалогов (например, `all` — все, `unread` — только непрочитанные, `important` — отмеченные важными). <br> <span style="color: var(--vp-c-text-3)">строка, по умолчанию: "all"</span> |
| **Extended** <br> `bool?` | Возвращать ли дополнительную информацию о пользователях/группах. <br> <span style="color: var(--vp-c-text-3)">логический тип, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `ExtendedCollection<ConversationAndMessage>`, содержащую список объектов [ConversationAndMessage](/reference/models/messages/conversation-and-message).

</div>
