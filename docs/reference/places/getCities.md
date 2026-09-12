<div class="vk-card">

# places.getCities

Возвращает список городов, отфильтрованных по идентификатору страны или поисковому запросу.

# Вызов метода

```csharp
Collection<City> cities = await api.Places.GetCitiesAsync(
    countryId: 1,
    q: "Санкт-Петербург"
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **countryId** <br> `int?` | Идентификатор страны, города которой нужно вернуть. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **q** <br> `string` | Поисковая строка для фильтрации названий городов. <br> <span style="color: var(--vp-c-text-3)">строка</span> |
| **offset** <br> `int?` | Смещение относительно начала списка. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **count** <br> `int?` | Количество возвращаемых городов. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `Collection<City>`, содержащий количество элементов и список городов `City`.

</div>
