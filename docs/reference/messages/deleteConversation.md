<div class="vk-card">

# messages.deleteConversation

Удаляет всю переписку в диалоге или беседе.

# Вызов метода

```csharp
int lastDeletedId = await api.Messages.DeleteConversationAsync(
    peerId: 2000000001
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **peerId** <br> `long` | Идентификатор диалога/беседы, переписку в которой необходимо удалить. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **offset** <br> `int?` | Смещение относительно последнего сообщения. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **count** <br> `int?` | Количество удаляемых сообщений (максимум 10000). <br> <span style="color: var(--vp-c-text-3)">целое число</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `int` — идентификатор последнего удаленного сообщения (`last_deleted_id`).

</div>
