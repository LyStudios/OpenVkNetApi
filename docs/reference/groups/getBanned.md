<div class="vk-card">

# groups.getBanned

Возвращает список заблокированных пользователей в сообществе.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуются права администратора или редактора в сообществе.</span>
</div>

# Вызов метода

```csharp
var banned = await api.Groups.GetBannedAsync(
    groupId: 1,
    count: 20
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **groupId** <br> `int` | Идентификатор сообщества. |
| **offset** <br> `int` | Смещение. |
| **count** <br> `int` | Количество записей (по умолчанию 20). |
| **fields** <br> `UserFields` | Поля профилей пользователей. |
| **ownerId** <br> `int` | Идентификатор конкретного пользователя для проверки бана. |

</div>

<div class="vk-card">

# Результат

Возвращает [ExtendedCollection&lt;User&gt;](/reference/models/extended-collection) со списком заблокированных пользователей.

</div>
