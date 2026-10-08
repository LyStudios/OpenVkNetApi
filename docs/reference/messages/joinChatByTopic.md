<div class="vk-card">

# messages.joinChatByTopic

Позволяет вступить в беседу, привязанную к топику / теме обсуждения.

# Вызов метода

```csharp
long chatId = await api.Messages.JoinChatByTopicAsync(
    topicId: 42
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **topicId** <br> `long` | Идентификатор темы обсуждения. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает идентификатор беседы `chatId`.

</div>
