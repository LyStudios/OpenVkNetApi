<div class="vk-card">

# messages.markAsImportant

Помечает или снимает отметку «важное» с сообщений.

# Вызов метода

```csharp
List<int> processed = await api.Messages.MarkAsImportantAsync(
    messageIds: new[] { 101, 102 },
    important: 1
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **messageIds** <br> `IEnumerable<int>` | Список идентификаторов сообщений. <br> <span style="color: var(--vp-c-text-3)">список целых чисел, обязательный параметр</span> |
| **important** <br> `int` | `1` — пометить как важные, `0` — снять пометку (по умолчанию 1). <br> <span style="color: var(--vp-c-text-3)">целое число</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `List<int>` — список идентификаторов успешно обработанных сообщений.

</div>
