<div class="vk-card">

# account.getBalance

Возвращает баланс голосов (внутренней валюты) на счете аккаунта текущего пользователя.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var balance = await api.Account.GetBalanceAsync();
Console.WriteLine($"Баланс: {balance.Balance} голосов");
```

</div>

<div class="vk-card">

# Параметры

Метод не принимает параметров запроса.

</div>

<div class="vk-card">

# Результат

Возвращает объект [AccountBalance](/reference/models/account/account-balance), содержащий информацию о балансе пользователя (`Balance` — дробное/целое число).

</div>
