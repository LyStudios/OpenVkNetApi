<div class="vk-card">

# friends.getSuggestions

Возвращает список рекомендуемых друзей для текущего пользователя.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var suggestions = await api.Friends.GetSuggestionsAsync(
    filter: "mutual",
    count: 20
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **filter** <br> `string` | Тип рекомендаций (например, `"mutual"`). |
| **count** <br> `int` | Количество пользователей (по умолчанию 20). |
| **offset** <br> `int` | Смещение для пагинации. |
| **extended** <br> `bool` | Возвращать ли расширенные профили. |
| **fields** <br> `UserFields` | Поля профилей пользователей. |

</div>

<div class="vk-card">

# Результат

Возвращает [ExtendedCollection&lt;User&gt;](/reference/models/extended-collection) со списком рекомендованных пользователей.

</div>
