<div class="vk-card">

# messages.getById

Возвращает сообщения по их уникальным идентификаторам.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя с правами доступа к сообщениям.</span>
</div>

# Вызов метода

```csharp
var messagesCollection = await api.Messages.GetByIdAsync(messageIds: "12,13", previewLength: 0, extended: true);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **messageIds** <br> `string` | Список идентификаторов сообщений, разделенных запятыми. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **previewLength** <br> `int` | Количество символов, которое необходимо вернуть из текста сообщения (0 — вернуть весь текст). <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **extended** <br> `bool` | Возвращать ли расширенную информацию (например, профили авторов). <br> <span style="color: var(--vp-c-text-3)">логический тип, по умолчанию: false</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<Message>`, содержащую список объектов [Message](/reference/models/messages/message).

</div>
