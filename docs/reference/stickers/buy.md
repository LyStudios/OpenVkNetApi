<div class="vk-card">

# stickers.buy

Позволяет приобрести набор стикеров за голоса или бесплатно.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя. На балансе пользователя должно быть достаточно голосов, если набор платный.</span>
</div>

# Вызов метода

```csharp
StickerBuyResult result = await api.Stickers.BuyAsync(packId: 5);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **packId** <br> `int` | Идентификатор приобретаемого набора стикеров. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект `StickerBuyResult`, содержащий статус покупки `Success` и сообщение `Message`.

</div>
