<div class="vk-card">

# store.getProducts

Возвращает список продуктов магазина (например, наборов стикеров) с поддержкой фильтрации по купленным или активным.

# Вызов метода

```csharp
var products = await api.Store.GetProductsAsync(
    type: "stickers",
    filters: "purchased",
    extended: true
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **type** <br> `string` | Тип продуктов (по умолчанию `"stickers"`). |
| **filters** <br> `string` | Фильтры (например `"purchased"`, `"active"`). |
| **extended** <br> `bool` | Возвращать ли полные данные о наборе. |
| **count** <br> `int` | Количество продуктов (по умолчанию 50). |
| **offset** <br> `int` | Смещение для пагинации. |
| **productIds** <br> `IEnumerable<int>` | Конкретный список идентификаторов продуктов. |
| **userId** <br> `int` | Идентификатор пользователя для фильтрации. |

</div>

<div class="vk-card">

# Результат

Возвращает [Collection&lt;StoreProduct&gt;](/reference/models/store/store-product), содержащую общее число продуктов и список товаров.

</div>
