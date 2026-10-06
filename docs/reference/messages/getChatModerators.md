<div class="vk-card">

# messages.getChatModerators

Возвращает список идентификаторов модераторов групповой беседы.

# Вызов метода

```csharp
ChatModerators moderators = await api.Messages.GetChatModeratorsAsync(
    chatId: 1
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **chatId** <br> `int` | Идентификатор беседы. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект `ChatModerators`, содержащий идентификатор создателя `OwnerId` и список ID модераторов `Moderators`.

</div>
