<div class="vk-card">

# messages.getChat

Возвращает расширенную информацию о групповой беседе (чатe).

# Вызов метода

```csharp
Chat chat = await api.Messages.GetChatAsync(
    chatId: 1,
    fields: "nickname,photo_50"
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **chatId** <br> `int` | Идентификатор беседы (`chat_id`). <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **fields** <br> `string` | Дополнительные поля профилей участников через запятую. <br> <span style="color: var(--vp-c-text-3)">строка</span> |
| **nameCase** <br> `string` | Падеж для склонения имени и фамилии участников. <br> <span style="color: var(--vp-c-text-3)">строка</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект `Chat`, содержащий идентификатор беседы, название, создателя, список участников и настройки.

</div>
