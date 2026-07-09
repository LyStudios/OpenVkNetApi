<div class="vk-card">

# users.getFollowers

Возвращает список подписчиков указанного пользователя.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Users;

var parameters = new UsersGetFollowersParams
{
    UserId = 12,
    Count = 10
};

var followers = await api.Users.GetFollowersAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `UsersGetFollowersParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **UserId** <br> `int` | Идентификатор пользователя, подписчиков которого нужно получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: текущий авторизованный пользователь</span> |
| **Offset** <br> `int` | Смещение относительно начала выборки. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество подписчиков, которое необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20, максимум: 1000</span> |
| **Fields** <br> `string` | Дополнительные поля профилей подписчиков через запятую. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **NameCase** <br> `string` | Падеж для склонения имени и фамилии подписчиков. <br> <span style="color: var(--vp-c-text-3)">строка, по умолчанию: "nom"</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<User>`, содержащую список объектов пользователей [User](/reference/models/users/user).

</div>
