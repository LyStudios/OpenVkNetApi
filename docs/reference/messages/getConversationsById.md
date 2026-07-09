<div class="vk-card">

# messages.getConversationsById

Возвращает информацию о диалогах или беседах по их идентификаторам назначения (`peer_ids`).

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя с правами доступа к сообщениям.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.Enums;

var conversations = await api.Messages.GetConversationsByIdAsync(peerIds: "1,2", extended: true, fields: UserFields.Sex);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **peerIds** <br> `string` | Список идентификаторов диалогов, разделенных запятыми. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **extended** <br> `bool` | Возвращать ли дополнительную информацию о собеседниках (в поле profiles/groups). <br> <span style="color: var(--vp-c-text-3)">логический тип, по умолчанию: false</span> |
| **fields** <br> `UserFields` | Список дополнительных полей профилей пользователей для расширенного ответа. <br> <span style="color: var(--vp-c-text-3)">перечисление UserFields, по умолчанию: UserFields.None</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `ExtendedCollection<Conversation>`, содержащую список объектов [Conversation](/reference/models/messages/conversation).

</div>
