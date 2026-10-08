<div class="vk-card">

# messages.getByConversationMessageId

Возвращает сообщения по их идентификаторам внутри беседы (`conversation_message_id`).

# Вызов метода

```csharp
ExtendedCollection<Message> messages = await api.Messages.GetByConversationMessageIdAsync(
    peerId: 2000000001,
    conversationMessageIds: new long[] { 1, 2, 3 }
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **peerId** <br> `long` | Идентификатор диалога/беседы. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **conversationMessageIds** <br> `IEnumerable<long>` | Список локальных идентификаторов сообщений в беседе. <br> <span style="color: var(--vp-c-text-3)">список целых чисел, обязательный параметр</span> |
| **extended** <br> `bool?` | Возвращать ли дополнительную информацию о пользователях/сообществах. <br> <span style="color: var(--vp-c-text-3)">логическое значение</span> |
| **fields** <br> `string` | Дополнительные поля профилей. <br> <span style="color: var(--vp-c-text-3)">строка</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `Collection<Message>`, содержащий количество найденных элементов и список сообщений.

</div>
