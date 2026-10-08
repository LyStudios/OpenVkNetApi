<div class="vk-card">

# messages.markAsImportantConversation

Помечает или снимает отметку важности со всего диалога/беседы.

# Вызов метода

```csharp
int result = await api.Messages.MarkAsImportantConversationAsync(
    peerId: 2000000001,
    important: true
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **peerId** <br> `long` | Идентификатор диалога или беседы. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **important** <br> `bool` | `true` — отметить как важный диалог, `false` — снять отметку (по умолчанию true). <br> <span style="color: var(--vp-c-text-3)">логическое значение</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного выполнения.

</div>
