<div class="vk-card">

# gifts.getCategories

Возвращает список категорий подарков из каталога.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var categories = await api.Gifts.GetCategoriesAsync(extended: true, page: 1);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **extended** <br> `bool` | Возвращать ли расширенную информацию о категориях (например, предзагруженный список подарков). <br> <span style="color: var(--vp-c-text-3)">логический тип, по умолчанию: false</span> |
| **page** <br> `int` | Номер страницы для пагинации категорий. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 1</span> |

</div>

<div class="vk-card">

# Результат

Возвращает список `List<GiftCategory>`, содержащий объекты [GiftCategory](/reference/models/gifts/gift-category).

</div>
