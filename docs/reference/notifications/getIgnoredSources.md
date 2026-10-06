<div class="vk-card">

# notifications.getIgnoredSources

Возвращает список источников (пользователей или сообществ), уведомления от которых заглушены или скрыты.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var ignored = await api.Notifications.GetIgnoredSourcesAsync(
    count: 20
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **count** <br> `int` | Количество источников (по умолчанию 20). |
| **offset** <br> `int` | Смещение. |

</div>

<div class="vk-card">

# Результат

Возвращает [ExtendedCollection&lt;User&gt;](/reference/models/extended-collection) со списком игнорируемых источников.

</div>
