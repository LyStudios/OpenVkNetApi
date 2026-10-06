<div class="vk-card">

# messages.editChat

Изменяет название групповой беседы.

# Вызов метода

```csharp
int result = await api.Messages.EditChatAsync(
    chatId: 1,
    title: "Новое название беседы"
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **chatId** <br> `int` | Идентификатор беседы. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **title** <br> `string` | Новое название беседы. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного изменения названия.

</div>
