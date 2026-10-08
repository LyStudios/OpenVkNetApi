<div class="vk-card">

# messages.addChatUser

Добавляет пользователя в групповую беседу.

# Вызов метода

```csharp
int result = await api.Messages.AddChatUserAsync(
    chatId: 1,
    userId: 2
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **chatId** <br> `long` | Идентификатор беседы. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **userId** <br> `long` | Идентификатор добавляемого пользователя. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного добавления пользователя.

</div>
