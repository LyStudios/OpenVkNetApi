<div class="vk-card">

# messages.getNearestMessageForDate

Возвращает идентификатор сообщения, ближайшего к указанной дате.

# Вызов метода

```csharp
int messageId = await api.Messages.GetNearestMessageForDateAsync(
    peerId: 2000000001,
    date: 1700000000
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **peerId** <br> `int` | Идентификатор диалога/беседы. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **date** <br> `long` | Unix timestamp целевой даты. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает целочисленный идентификатор найденного сообщения `int`.

</div>
