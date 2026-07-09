<div class="vk-card">

# account.sendVotes

Переводит голоса (внутреннюю валюту) со своего счета на счет другого пользователя.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя. Перевод голосов необратим.</span>
</div>

# Вызов метода

```csharp
var balance = await api.Account.SendVotesAsync(receiverId: 1, value: 10, message: "Спасибо за помощь!");
Console.WriteLine($"Остаток баланса: {balance.Balance}");
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **receiverId** <br> `int` | Идентификатор пользователя-получателя перевода. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **value** <br> `int` | Количество переводимых голосов. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **message** <br> `string` | Сопроводительное сообщение к переводу. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [AccountBalance](/reference/models/account/account-balance) с обновленным балансом текущего пользователя.

</div>
