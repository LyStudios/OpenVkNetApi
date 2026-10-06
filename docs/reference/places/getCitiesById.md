<div class="vk-card">

# places.getCitiesById

Возвращает информацию о городах по их идентификаторам.

# Вызов метода

```csharp
List<PlaceCity> cities = await api.Places.GetCitiesByIdAsync(
    cityIds: new[] { 1, 2 }
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **cityIds** <br> `IEnumerable<int>` | Коллекция идентификаторов городов. |

</div>

<div class="vk-card">

# Результат

Возвращает `List<PlaceCity>` с объектами найденных городов.

</div>
