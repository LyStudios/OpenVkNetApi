<div class="vk-card">

# users.search

Выполняет поиск пользователей по текстовому запросу и различным фильтрам.

<div class="vk-info">
  <span>💡 Для вызова этого метода не требуется авторизация пользователя (токен необязателен).</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Users;

var parameters = new UsersSearchParams
{
    Query = "Иван",
    Count = 10
};

var searchResult = await api.Users.SearchAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `UsersSearchParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **Query** <br> `string` | Поисковый запрос (имя, фамилия, никнейм). <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **Offset** <br> `int` | Смещение относительно начала выборки. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество пользователей, которое необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20, максимум: 1000</span> |
| **Fields** <br> `string` | Дополнительные поля профилей через запятую. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<User>`, содержащую список найденных объектов пользователей [User](/reference/models/users/user).

</div>
