<div class="vk-card">

# account.saveProfileInfo

Редактирует информацию текущего профиля пользователя.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Account;

var parameters = new SaveProfileInfoParams
{
    FirstName = "Иван",
    LastName = "Иванов",
    Status = "Тестирую API"
};

var result = await api.Account.SaveProfileInfoAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `SaveProfileInfoParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **FirstName** <br> `string` | Имя пользователя. <br> <span style="color: var(--vp-c-text-3)">необязательный параметр</span> |
| **LastName** <br> `string` | Фамилия пользователя. <br> <span style="color: var(--vp-c-text-3)">необязательный параметр</span> |
| **Status** <br> `string` | Статус пользователя (подпись под именем). <br> <span style="color: var(--vp-c-text-3)">необязательный параметр</span> |
| **Bdate** <br> `string` | Дата рождения в формате `D.M.YYYY` или `D.M`. <br> <span style="color: var(--vp-c-text-3)">необязательный параметр</span> |
| **Gender** <br> `int?` | Пол (0 — не указан, 1 — женский, 2 — мужской). <br> <span style="color: var(--vp-c-text-3)">необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [AccountSaveProfile](/reference/models/account/account-save-profile), содержащий статус сохранения (`Changed` — логическое значение) и детальную информацию о полях.

</div>
