<div class="vk-card">

# places.getCountries

Возвращает список стран.

# Вызов метода

```csharp
Collection<Country> countries = await api.Places.GetCountriesAsync(
    needAll: true,
    count: 100
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **needAll** <br> `bool?` | Возвращать полный список стран (`true`) или только основные (`false`). <br> <span style="color: var(--vp-c-text-3)">логическое значение</span> |
| **code** <br> `string` | Двухбуквенный ISO-код страны для фильтрации (например, `"RU"`). <br> <span style="color: var(--vp-c-text-3)">строка</span> |
| **offset** <br> `int?` | Смещение относительно начала списка. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **count** <br> `int?` | Количество возвращаемых стран (по умолчанию 100). <br> <span style="color: var(--vp-c-text-3)">целое число</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `Collection<Country>`, содержащий количество элементов и список стран `Country`.

</div>
