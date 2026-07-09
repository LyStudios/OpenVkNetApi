<div class="vk-card">

# pay.verifyOrder

Верифицирует платежный заказ.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
bool isValid = await api.Pay.VerifyOrderAsync(appId: 1, amount: 150.0f, signature: "sha256_hash_here");
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **appId** <br> `int` | Идентификатор приложения. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **amount** <br> `float` | Сумма платежа. <br> <span style="color: var(--vp-c-text-3)">вещественное число, обязательный параметр</span> |
| **signature** <br> `string` | Подпись платежного запроса для верификации. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `true`, если заказ успешно прошел проверку подлинности, иначе `false`.

</div>
