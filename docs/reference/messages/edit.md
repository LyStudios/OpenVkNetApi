<div class="vk-card">

# messages.edit

Редактирует текст или вложения отправленного сообщения.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя. Редактировать сообщения можно только в течение 24 часов с момента их отправки.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Messages;

var parameters = new MessagesEditParams
{
    PeerId = 1,
    MessageId = 4567,
    Message = "Исправленный текст сообщения"
};

int result = await api.Messages.EditAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `MessagesEditParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **PeerId** <br> `int` | Идентификатор диалога/собеседника. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **MessageId** <br> `int` | Идентификатор редактируемого сообщения. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **Message** <br> `string` | Новый текст сообщения. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр (если не переданы новые вложения)</span> |
| **Attachment** <br> `string` | Новый список медиавложений, разделенных запятыми. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного редактирования.

</div>
