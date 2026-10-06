<div class="vk-card">

# stats.track

Отправляет событие аналитики или статистики использования приложения на сервер.

# Вызов метода

```csharp
bool ok = await api.Stats.TrackAsync(
    key: "app_open",
    value: 1
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **key** <br> `string` | Ключ метрики или название события. |
| **value** <br> `int` | Числовое значение метрики (по умолчанию 1). |

</div>

<div class="vk-card">

# Результат

Возвращает `bool` (`true` в случае успешной отправки события).

</div>
