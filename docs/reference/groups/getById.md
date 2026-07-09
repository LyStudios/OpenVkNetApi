<div class="vk-card">

# groups.getById

Возвращает детальную информацию об одном или нескольких сообществах по их идентификаторам.

<div class="vk-info">
  <span>💡 Для вызова этого метода не требуется авторизация пользователя (токен необязателен).</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Groups;

var parameters = new GroupsGetByIdParams
{
    GroupIds = "1,2",
    Fields = "description,members_count"
};

var groupsList = await api.Groups.GetByIdAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `GroupsGetByIdParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **GroupIds** <br> `string` | Список идентификаторов сообществ, разделенных запятыми. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр (если указан `GroupId`)</span> |
| **GroupId** <br> `string` | Идентификатор одного сообщества (альтернатива списку `GroupIds`). <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Fields** <br> `string` | Список дополнительных полей, которые необходимо вернуть в объекте сообщества (например, `description,members_count,status`). <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает список `List<Group>`, содержащий объекты сообществ [Group](/reference/models/groups/group).

</div>
