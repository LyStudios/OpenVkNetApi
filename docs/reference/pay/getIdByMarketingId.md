<div class="vk-card">

# pay.getIdByMarketingId

Возвращает идентификатор пользователя или сообщества на основе маркетингового идентификатора.

<div class="vk-info">
  <span>💡 Для вызова этого метода не требуется авторизация пользователя (токен необязателен).</span>
</div>

## Вызов метода

```csharp
int id = await api.Pay.GetIdByMarketingIdAsync(marketingId: "promo_partner_12");
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **marketingId** <br> `string` | Маркетинговый идентификатор. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает число `int` — идентификатор пользователя (положительное число) или сообщества (отрицательное число).

</div>
