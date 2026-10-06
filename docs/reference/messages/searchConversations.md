<div class="vk-card">

# messages.searchConversations

Ищет беседы и диалоги по названию или имени собеседника.

# Вызов метода

```csharp
ExtendedCollection<Conversation> conversations = await api.Messages.SearchConversationsAsync(
    q: "разработчики",
    count: 20
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **q** <br> `string` | Поисковая подстрока для поиска диалогов. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **count** <br> `int?` | Количество возвращаемых диалогов (по умолчанию 20). <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **extended** <br> `bool?` | Возвращать ли профили участников и сообществ. <br> <span style="color: var(--vp-c-text-3)">логическое значение</span> |
| **fields** <br> `string` | Дополнительные поля профилей. <br> <span style="color: var(--vp-c-text-3)">строка</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `ExtendedCollection<Conversation>`, содержащий список найденных диалогов, а также профили и сообщества при `extended = true`.

</div>
