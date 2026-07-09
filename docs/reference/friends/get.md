<div class="vk-card">

# friends.get

Возвращает список друзей пользователя.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Friends;
using OpenVkNetApi.Models.Enums;

var parameters = new FriendsGetParams
{
    UserId = 1,
    Count = 10,
    Offset = 0,
    Fields = UserFields.Sex | UserFields.Online
};

var friendsCollection = await api.Friends.GetAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `FriendsGetParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **UserId** <br> `int?` | Идентификатор пользователя, список друзей которого нужно получить. Если не указан, возвращает друзей текущего пользователя. <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **Count** <br> `int` | Количество возвращаемых друзей. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 100, максимум: 5000</span> |
| **Offset** <br> `int` | Смещение, необходимое для выборки определенного подмножества друзей. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Fields** <br> `UserFields` | Список дополнительных полей профилей пользователей, которые необходимо вернуть. <br> <span style="color: var(--vp-c-text-3)">перечисление UserFields, по умолчанию: UserFields.None</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<User>`, содержащую список объектов [User](/reference/models/users/user).

</div>
