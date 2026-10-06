<div class="vk-card">

# auth.getTokenSecure

Безопасно генерирует временный токен авторизации.

# Вызов метода

```csharp
AuthSecureToken token = await api.Auth.GetTokenSecureAsync(
    nonce: "random_nonce_123"
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **nonce** <br> `string` | Случайная уникальная строка (nonce). |
| **apiId** <br> `int?` | Идентификатор приложения. |
| **clientId** <br> `string` | Идентификатор клиента. |

</div>

<div class="vk-card">

# Результат

Возвращает [AuthSecureToken](/reference/models/auth/auth-secure-token), содержащий безопасный токен и секрет.

</div>
