<div class="vk-card">

# messages.createChat

Создает новую групповую беседу (чат) с указанными пользователями.

# Вызов метода

```csharp
long chatId = await api.Messages.CreateChatAsync(
    userIds: new long[] { 1, 2, 3 },
    title: "Беседа разработчиков"
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **userIds** <br> `IEnumerable<long>` | Идентификаторы пользователей, которых необходимо включить в беседу. <br> <span style="color: var(--vp-c-text-3)">список целых чисел, обязательный параметр</span> |
| **title** <br> `string` | Название создаваемой беседы. <br> <span style="color: var(--vp-c-text-3)">строка</span> |

</div>

<div class="vk-card">

# Результат

Возвращает целочисленный идентификатор созданного чата (`chat_id`, от `1` до `1000000000`).

</div>
