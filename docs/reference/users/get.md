<div class="vk-card">

# users.get

Возвращает расширенную информацию об одном или нескольких пользователях по их идентификаторам.

<div class="vk-info">
  <span>💡 Для вызова этого метода не требуется авторизация пользователя (токен необязателен).</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Users;
using OpenVkNetApi.Models.Enums;

var parameters = new UsersGetParams
{
    UserIds = "1,2",
    Fields = UserFields.Sex | UserFields.Bdate | UserFields.Status
};

var usersList = await api.Users.GetAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `UsersGetParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **UserIds** <br> `string` | Идентификаторы пользователей, разделенные запятыми. <br> <span style="color: var(--vp-c-text-3)">строка, по умолчанию: текущий авторизованный пользователь</span> |
| **Fields** <br> `UserFields` | Битовые флаги запрашиваемых дополнительных полей профиля. <br> <span style="color: var(--vp-c-text-3)">перечисление флагов, по умолчанию: UserFields.None</span> |
| **NameCase** <br> `string` | Падеж для склонения имени и фамилии пользователя (например, `nom`, `gen`, `dat`). <br> <span style="color: var(--vp-c-text-3)">строка, по умолчанию: "nom"</span> |

</div>

<div class="vk-card">

# Результат

Возвращает список `List<User>`, содержащий объекты профилей пользователей [User](/reference/models/users/user).

</div>
