<div class="vk-card">

# apps.getCatalog

Возвращает каталог доступных мини-приложений OpenVK.

# Вызов метода

```csharp
var catalog = await api.Apps.GetCatalogAsync(
    count: 30,
    offset: 0,
    extended: true
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **count** <br> `int` | Количество возвращаемых приложений (по умолчанию 30). |
| **offset** <br> `int` | Смещение относительно начала списка. |
| **filter** <br> `string` | Фильтр каталога (например, `featured`). |
| **extended** <br> `bool` | Возвращать ли расширенную информацию о приложениях. |

</div>

<div class="vk-card">

# Результат

Возвращает объект [MiniAppsCatalog](/reference/models/apps/mini-apps-catalog), содержащий общее количество `Count` и список приложений `Items`.

</div>
