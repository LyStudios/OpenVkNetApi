<div class="vk-card">

# messages.getHistory

Возвращает историю сообщений для указанного диалога или беседы.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя с правами доступа к сообщениям.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Messages;

var parameters = new MessagesGetHistoryParams
{
    PeerId = 1,
    Count = 20,
    Offset = 0
};

var messagesHistory = await api.Messages.GetHistoryAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `MessagesGetHistoryParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **PeerId** <br> `int` | Идентификатор диалога/собеседника. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр (если не передан `UserId`)</span> |
| **UserId** <br> `int?` | Идентификатор пользователя, историю переписки с которым нужно получить (рекомендуется использовать `PeerId`). <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **Offset** <br> `int` | Смещение для выборки определенного подмножества сообщений. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество сообщений, которое необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20, максимум: 200</span> |
| **Rev** <br> `int?` | Порядок сортировки: `1` — в хронологическом порядке (сначала старые); `0` — в обратном порядке (сначала новые). <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `ExtendedCollection<Message>`, содержащую список объектов [Message](/reference/models/messages/message).

</div>
