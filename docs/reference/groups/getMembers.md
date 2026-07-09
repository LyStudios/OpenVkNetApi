<div class="vk-card">

# groups.getMembers

Возвращает список участников указанного сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя. Для закрытых сообществ пользователь должен быть их участником или администратором.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Groups;
using OpenVkNetApi.Models.Enums;

var parameters = new GroupsGetMembersParams
{
    GroupId = "12",
    Count = 20,
    Offset = 0,
    Fields = UserFields.Online
};

var membersCollection = await api.Groups.GetMembersAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `GroupsGetMembersParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **GroupId** <br> `string` | Идентификатор сообщества. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **Sort** <br> `string` | Сортировка участников (например, `id_asc`, `id_desc`). <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Offset** <br> `int` | Смещение для выборки определенного подмножества участников. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество участников, которое необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 100, максимум: 1000</span> |
| **Fields** <br> `UserFields` | Список дополнительных полей профилей пользователей, которые необходимо вернуть. <br> <span style="color: var(--vp-c-text-3)">перечисление UserFields, по умолчанию: UserFields.None</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<User>`, содержащую список объектов пользователей [User](/reference/models/users/user).

</div>
