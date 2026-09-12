<div class="vk-card">

# messages.markAsRead

Помечает сообщения как прочитанные.

# Вызов метода

```csharp
int result = await api.Messages.MarkAsReadAsync(
    peerId: 2000000001,
    startMessageId: 1234
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **peerId** <br> `int?` | Идентификатор диалога/беседы. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **startMessageId** <br> `int?` | Идентификатор сообщения, начиная с которого сообщения помечаются прочитанными. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **messageIds** <br> `IEnumerable<int>` | Конкретный список ID сообщений. <br> <span style="color: var(--vp-c-text-3)">список целых чисел</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешной отметки о прочтении.

</div>
