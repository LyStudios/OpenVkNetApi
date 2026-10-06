<div class="vk-card">

# auth.getExchangeTokensInfo

Возвращает информацию о токенах обмена сессиями для межсервисной аутентификации.

# Вызов метода

```csharp
ExchangeTokenInfo info = await api.Auth.GetExchangeTokensInfoAsync(
    token: "exchange_token_abc"
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **token** <br> `string` | Временный токен обмена. |

</div>

<div class="vk-card">

# Результат

Возвращает [ExchangeTokenInfo](/reference/models/auth/exchange-token-info) со сроком жизни и привязанными данными.

</div>
