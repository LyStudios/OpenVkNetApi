<div class="vk-card">

# groups.ban

Добавляет пользователя в черный список сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуются права администратора или редактора в сообществе.</span>
</div>

# Вызов метода

```csharp
bool ok = await api.Groups.BanAsync(
    groupId: 1,
    ownerId: 10,
    endDate: 0,
    reason: 0,
    comment: "Спам",
    commentVisible: true
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **groupId** <br> `int` | Идентификатор сообщества. |
| **ownerId** <br> `int` | Идентификатор блокируемого пользователя. |
| **endDate** <br> `int` | Срок окончания блокировки в формате unixtime (0 — навсегда). |
| **reason** <br> `int` | Причина блокировки (0 — другое, 1 — спам, 2 — оскорбление и т.д.). |
| **comment** <br> `string` | Текст комментария к блокировке. |
| **commentVisible** <br> `bool` | Отображать ли комментарий пользователю. |

</div>

<div class="vk-card">

# Результат

Возвращает `bool` (`true` при успешном добавлении в бан-лист).

</div>
