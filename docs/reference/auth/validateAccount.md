<div class="vk-card">

# auth.validateAccount

Метод для проверки учетной записи и получения необходимого сценария авторизации (flow).

<div class="vk-info">
  <span>💡 Для вызова этого метода не требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
var result = await api.Auth.ValidateAccountAsync("user_login_or_phone");
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **login** <br> `string` | Необязательный. Логин или номер телефона пользователя для валидации. |

</div>

<div class="vk-card">

# Результат

Возвращает объект [AccountValidationResult](/reference/models/account-validation-result) с полями сценария авторизации (`flow_name`) и идентификатора сессии (`sid`).

</div>
