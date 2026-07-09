<div class="vk-card">

# messages.getLongPollHistory

Возвращает историю событий и обновлений в диалогах пользователя, пропущенных с момента последнего запроса к Long Poll.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя. Метод используется для возобновления работы клиента после сетевых сбоев.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Messages;

var parameters = new MessagesGetLongPollHistoryParams
{
    Ts = 12345678,
    Pts = 4567
};

var updates = await api.Messages.GetLongPollHistoryAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `MessagesGetLongPollHistoryParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **Ts** <br> `long` | Последнее известное значение таймштампа событий Long Poll. <br> <span style="color: var(--vp-c-text-3)">длинное целое число, обязательный параметр</span> |
| **Pts** <br> `int` | Идентификатор последнего полученного события в истории диалогов. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **MsgsLimit** <br> `int` | Максимальное количество сообщений, которое необходимо вернуть. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 200</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [LongPollHistory](/reference/models/messages/long-poll-history), содержащий списки новых сообщений, измененных статусов и профилей участников.

</div>
