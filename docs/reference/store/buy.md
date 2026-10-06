<div class="vk-card">

# store.buy

Приобретает товар в магазине (например, набор стикеров) за голоса или бесплатно.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var result = await api.Store.BuyAsync(
    productId: 5
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **productId** <br> `int` | Идентификатор продукта или набора стикеров. |

</div>

<div class="vk-card">

# Результат

Возвращает [StickerBuyResult](/reference/models/store/sticker-buy-result) со статусом покупки `Success` и идентификатором купленного набора.

</div>
