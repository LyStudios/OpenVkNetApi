<div class="vk-card">

# groups.search

Выполняет поиск сообществ по текстовому запросу.

<div class="vk-info">
  <span>💡 Для вызова этого метода не требуется авторизация пользователя (токен необязателен).</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Groups;

var parameters = new GroupsSearchParams
{
    Query = "новости",
    Count = 10,
    Offset = 0
};

var groupsCollection = await api.Groups.SearchAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `GroupsSearchParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **Query** <br> `string` | Текст поискового запроса. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **Type** <br> `string` | Тип сообщества для фильтрации (`group`, `page` или `event`). <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Offset** <br> `int` | Смещение для выборки определенного подмножества сообществ. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество сообществ, которое необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20, максимум: 1000</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<Group>`, содержащую список найденных объектов сообществ [Group](/reference/models/groups/group).

</div>
