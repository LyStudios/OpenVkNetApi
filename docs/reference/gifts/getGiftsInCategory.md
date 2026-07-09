<div class="vk-card">

# gifts.getGiftsInCategory

Возвращает список доступных подарков внутри конкретной категории.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var catalogGifts = await api.Gifts.GetGiftsInCategoryAsync(id: 3, page: 1);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **id** <br> `int` | Уникальный идентификатор категории подарков. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **page** <br> `int` | Номер страницы для пагинации списка подарков внутри категории. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 1</span> |

</div>

<div class="vk-card">

# Результат

Возвращает список `List<CatalogGift>`, содержащий объекты [CatalogGift](/reference/models/gifts/catalog-gift).

</div>
