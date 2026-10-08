<div class="vk-card">

# messages.pin

Закрепляет сообщение в беседе или диалоге.

# Вызов метода

```csharp
Message pinned = await api.Messages.PinAsync(
    peerId: 2000000001,
    messageId: 1234
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **peerId** <br> `long` | Идентификатор назначения (диалога или чата). <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **messageId** <br> `long?` | Глобальный идентификатор закрепляемого сообщения. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **cmid** <br> `long?` | Идентификатор сообщения в рамках беседы (`conversation_message_id`). <br> <span style="color: var(--vp-c-text-3)">целое число</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект закрепленного сообщения `Message`.

</div>
