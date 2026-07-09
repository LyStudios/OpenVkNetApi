<div class="vk-card">

# friends.getRequests

Возвращает список полученных (входящих) или отправленных (исходящих) заявок на добавление в друзья.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Friends;

var parameters = new FriendsGetRequestsParams
{
    Out = false, // Получить входящие заявки
    Count = 20,
    Offset = 0
};

var requests = await api.Friends.GetRequestsAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `FriendsGetRequestsParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **Out** <br> `bool` | Направление заявок: `false` — входящие заявки, `true` — исходящие заявки. <br> <span style="color: var(--vp-c-text-3)">логический тип, по умолчанию: false</span> |
| **Offset** <br> `int` | Смещение для выборки определенного подмножества заявок. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество возвращаемых заявок. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 100, максимум: 1000</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<User>`, содержащую список объектов пользователей [User](/reference/models/users/user), которые отправили или получили заявку.

</div>
