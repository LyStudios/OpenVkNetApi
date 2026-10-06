<div class="vk-card">

# search.getHints

Возвращает поисковые подсказки для быстрого автодополнения (пользователи, сообщества, приложения и др.).

# Вызов метода

```csharp
var hints = await api.Search.GetHintsAsync(
    query: "Павел",
    limit: 10,
    searchGlobal: true
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **query** <br> `string` | Поисковый запрос для поиска подсказок. |
| **offset** <br> `int` | Смещение относительно начала списка. |
| **limit** <br> `int` | Максимальное количество подсказок (по умолчанию 10). |
| **filters** <br> `string` | Фильтры по типам результатов (через запятую). |
| **fields** <br> `UserFields` | Дополнительные поля профилей пользователей. |
| **searchGlobal** <br> `bool` | Искать ли глобально по всему сервису. |

</div>

<div class="vk-card">

# Результат

Возвращает `List<SearchHint>`, где каждый объект [SearchHint](/reference/models/search/search-hint) представляет подсказку с типом, описанием и профилем.

</div>
