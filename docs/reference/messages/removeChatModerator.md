<div class="vk-card">

# messages.removeChatModerator

Снимает полномочия модератора с участника групповой беседы.

# Вызов метода

```csharp
int result = await api.Messages.RemoveChatModeratorAsync(
    chatId: 1,
    userId: 2
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **chatId** <br> `int` | Идентификатор беседы. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **userId** <br> `int` | Идентификатор пользователя, с которого снимаются права модератора. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного снятия полномочий.

</div>
