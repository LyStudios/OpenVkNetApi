<div class="vk-card">

# places.getCountriesById

Возвращает информацию о странах по их идентификаторам.

# Вызов метода

```csharp
List<PlaceCountry> countries = await api.Places.GetCountriesByIdAsync(
    countryIds: new[] { 1, 2 }
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **countryIds** <br> `IEnumerable<int>` | Коллекция идентификаторов стран. |

</div>

<div class="vk-card">

# Результат

Возвращает `List<PlaceCountry>` с объектами найденных стран.

</div>
