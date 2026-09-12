<div class="vk-card">

# stickers.checkStock

Проверяет доступность набора стикеров на складе / в магазине инстанса.

# Вызов метода

```csharp
bool inStock = await api.Stickers.CheckStockAsync(packId: 5);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **packId** <br> `int` | Идентификатор проверяемого набора стикеров. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `true`, если набор доступен для приобретения/установки, иначе `false`.

</div>
