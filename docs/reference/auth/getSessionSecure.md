<div class="vk-card">

# auth.getSessionSecure

Выполняет безопасную аутентификацию по учетным данным пользователя и возвращает сессионный токен.

# Вызов метода

```csharp
AuthSecureSession session = await api.Auth.GetSessionSecureAsync(
    login: "my_login",
    password: "my_password"
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **login** <br> `string` | Логин пользователя. |
| **password** <br> `string` | Пароль пользователя. |
| **apiId** <br> `int?` | Идентификатор приложения. |
| **clientId** <br> `string` | Идентификатор клиента. |
| **code** <br> `string` | Код двухфакторной аутентификации (если требуется). |

</div>

<div class="vk-card">

# Результат

Возвращает [AuthSecureSession](/reference/models/auth/auth-secure-session), содержащий токен доступа и идентификатор пользователя.

</div>
