<div class="vk-card">

# friends.edit

Редактирует принадлежность друга к списку/спискам друзей.

## Вызов метода

```csharp
int result = await api.Friends.EditAsync(userId: 123, listIds: "1,2");
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **userId** <br> `long` | **Обязательный.** Идентификатор друга. |
| **listIds** <br> `string` | Перечень идентификаторов списков через запятую. |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успеха.

</div>
