<div class="vk-card">

# messages.getConversationMembers

Возвращает полный список участников беседы вместе с их ролями (владелец, администратор, модератор).

# Вызов метода

```csharp
ExtendedCollection<ConversationMember> members = await api.Messages.GetConversationMembersAsync(
    peerId: 2000000001,
    fields: "photo_50,online,sex"
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **peerId** <br> `long` | Идентификатор беседы (`2000000000 + chat_id`). <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **offset** <br> `int?` | Смещение относительно начала списка участников. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **count** <br> `int?` | Количество возвращаемых участников (по умолчанию 20). <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **extended** <br> `bool?` | Возвращать ли профили участников. <br> <span style="color: var(--vp-c-text-3)">логическое значение</span> |
| **fields** <br> `string` | Дополнительные поля профилей участников. <br> <span style="color: var(--vp-c-text-3)">строка</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `ExtendedCollection<ConversationMember>`, содержащий список участников с их ролями `MemberId`, `IsAdmin`, `IsOwner`, `JoinDate`, а также коллекцию профилей `Profiles`.

</div>
