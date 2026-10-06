<div class="vk-card">

# auth.getExchangeToken

Создает новый токен обмена для быстрого перехода в другой сервис без повторного ввода пароля.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
ExchangeTokenResult result = await api.Auth.GetExchangeTokenAsync();
```

</div>

<div class="vk-card">

# Параметры

Метод не принимает параметров.

</div>

<div class="vk-card">

# Результат

Возвращает [ExchangeTokenResult](/reference/models/auth/exchange-token-result) со сгенерированным токеном `Token`.

</div>
