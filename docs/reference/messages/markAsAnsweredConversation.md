<div class="vk-card">

# messages.markAsAnsweredConversation

Помечает диалог как отвеченный или требующий ответа (неотвеченный).

# Вызов метода

```csharp
int result = await api.Messages.MarkAsAnsweredConversationAsync(
    peerId: 2000000001,
    answered: true
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **peerId** <br> `long` | Идентификатор диалога. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **answered** <br> `bool` | `true` — пометить отвеченным, `false` — пометить неотвеченным (по умолчанию true). <br> <span style="color: var(--vp-c-text-3)">логическое значение</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного выполнения.

</div>
