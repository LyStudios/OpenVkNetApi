<div class="vk-card">

# store.getStockItems

Возвращает товары витрины магазина по категориям каталога.

# Вызов метода

```csharp
var items = await api.Store.GetStockItemsAsync(
    type: "stickers",
    section: "free"
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **type** <br> `string` | Тип товаров (`"stickers"`). |
| **section** <br> `string` | Секция каталога (`"free"`, `"all"`, `"popular"`). |
| **extended** <br> `bool` | Расширенная информация о товарах. |
| **count** <br> `int` | Количество записей на странице. |
| **offset** <br> `int` | Смещение для пагинации. |

</div>

<div class="vk-card">

# Результат

Возвращает [Collection&lt;StoreProduct&gt;](/reference/models/store/store-product) с товарами витрины.

</div>
