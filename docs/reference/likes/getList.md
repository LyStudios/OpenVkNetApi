<div class="vk-card">

# likes.getList

Возвращает список пользователей, оценивших указанный объект отметкой «Мне нравится».

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Likes;

var parameters = new LikesGetListParams
{
    Type = "post",
    OwnerId = 1,
    ItemId = 12,
    Count = 50
};

// 1. Получить только список ID пользователей (Collection<int>)
var userIds = await api.Likes.GetListAsync(parameters);

// 2. Получить список полных объектов пользователей (Collection<User>)
var users = await api.Likes.GetListExtendedAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `LikesGetListParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **Type** <br> `string` | Тип объекта (например, `post`, `comment`, `photo`). <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **OwnerId** <br> `int` | Идентификатор владельца объекта. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **ItemId** <br> `int` | Уникальный идентификатор объекта. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **Offset** <br> `int` | Смещение для выборки определенного подмножества пользователей. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество пользователей, которое необходимо вернуть. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 100, максимум: 1000</span> |

</div>

<div class="vk-card">

# Результат

В зависимости от вызываемого метода:
* При обычном вызове (`GetListAsync`) возвращает коллекцию `Collection<int>`, содержащую числовые идентификаторы пользователей.
* При расширенном вызове (`GetListExtendedAsync`) возвращает коллекцию `Collection<User>`, содержащую список объектов пользователей [User](/reference/models/users/user).

</div>
