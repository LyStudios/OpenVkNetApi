<div class="vk-card">

# wall.getSubscriptions

Возвращает список сообществ и пользователей, на чьи записи на стене подписан пользователь.

# Вызов метода

```csharp
var subs = await api.Wall.GetSubscriptionsAsync(
    userId: 1,
    count: 20
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **userId** <br> `int` | Идентификатор пользователя. |
| **extended** <br> `bool` | Возвращать ли полные объекты сообществ/пользователей. |
| **count** <br> `int` | Количество подписок. |
| **offset** <br> `int` | Смещение для выборки. |

</div>

<div class="vk-card">

# Результат

Возвращает [ExtendedCollection&lt;Group&gt;](/reference/models/extended-collection) со списком подписок на стены.

</div>
