<div class="vk-card">

# groups.unban

Удаляет пользователя из черного списка сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуются права администратора или редактора в сообществе.</span>
</div>

# Вызов метода

```csharp
bool ok = await api.Groups.UnbanAsync(
    groupId: 1,
    ownerId: 10
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **groupId** <br> `int` | Идентификатор сообщества. |
| **ownerId** <br> `int` | Идентификатор разблокируемого пользователя. |

</div>

<div class="vk-card">

# Результат

Возвращает `bool` (`true` при успешном удалении из черного списка).

</div>
