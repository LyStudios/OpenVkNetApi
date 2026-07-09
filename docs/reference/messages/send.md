<div class="vk-card">

# messages.send

Отправляет сообщение пользователю, сообществу или в беседу.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя или сообщества с правами на отправку сообщений.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Messages;

var parameters = new MessagesSendParams
{
    PeerId = 1,
    Message = "Привет! Как дела?",
    RandomId = new Random().Next()
};

var sentIds = await api.Messages.SendAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `MessagesSendParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **PeerId** <br> `int` | Идентификатор назначения (ID пользователя, беседы или сообщества). <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **Message** <br> `string` | Текст сообщения. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр (если не переданы вложения)</span> |
| **RandomId** <br> `int` | Уникальный идентификатор, предназначенный для предотвращения повторной отправки одного и того же сообщения. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **UserId** <br> `int?` | Идентификатор пользователя, которому отправляется сообщение (устарело, рекомендуется использовать `PeerId`). <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **Attachment** <br> `string` | Медиавложения к сообщению, перечисленные через запятую (например, `photo100_500,doc200_600`). <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает список `List<int>`, содержащий уникальные идентификаторы отправленных сообщений.

</div>
