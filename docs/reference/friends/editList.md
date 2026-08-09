<div class="vk-card">

# friends.editList

Создает или редактирует существующий список друзей.

## Вызов метода

```csharp
int result = await api.Friends.EditListAsync(listId: 1, name: "Лучшие друзья", userIds: "10,20");
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **listId** <br> `int` | **Обязательный.** Идентификатор списка друзей. |
| **name** <br> `string` | Название списка друзей. |
| **userIds** <br> `string` | Полный список ID пользователей через запятую. |
| **addUserIds** <br> `string` | Список ID пользователей для добавления через запятую. |
| **deleteUserIds** <br> `string` | Список ID пользователей для удаления через запятую. |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного сохранения.

</div>
