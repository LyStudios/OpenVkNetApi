<div class="vk-card">

# groups.get

Возвращает список сообществ (групп, публичных страниц, мероприятий) указанного пользователя.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Groups;

var parameters = new GroupsGetParams
{
    UserId = 1,
    Count = 10,
    Offset = 0
};

var groupsCollection = await api.Groups.GetAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `GroupsGetParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **UserId** <br> `int?` | Идентификатор пользователя, список сообществ которого нужно получить. Если не указан, возвращает сообщества текущего пользователя. <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **Extended** <br> `bool?` | Возвращать ли полную информацию о сообществах. <br> <span style="color: var(--vp-c-text-3)">логический тип, необязательный параметр</span> |
| **Filter** <br> `string` | Список типов сообществ, которые необходимо вернуть, разделенных запятыми (например, `admin,editor,moder,groups,publics,events`). <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Fields** <br> `string` | Список дополнительных полей сообществ, которые необходимо вернуть. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Offset** <br> `int` | Смещение для выборки определенного подмножества сообществ. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество сообществ, которое необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 100, максимум: 1000</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<Group>`, содержащую список объектов [Group](/reference/models/groups/group).

</div>
