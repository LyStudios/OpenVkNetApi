<div class="vk-card">

# messages.getMessageViewers

Возвращает список пользователей, прочитавших конкретное сообщение в беседе.

# Вызов метода

```csharp
Collection<MessageViewer> viewers = await api.Messages.GetMessageViewersAsync(
    peerId: 2000000001,
    cmid: 15
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **peerId** <br> `long` | Идентификатор беседы. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **cmid** <br> `int?` | Номер сообщения в беседе (`conversation_message_id`). <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **messageId** <br> `int?` | Глобальный идентификатор сообщения. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **count** <br> `int?` | Количество возвращаемых читателей (по умолчанию 20). <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **offset** <br> `int?` | Смещение относительно начала списка. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `Collection<MessageViewer>`, содержащий количество читателей и список `MessageViewer` с `UserId` и временем прочтения `ReadDate`.

</div>
