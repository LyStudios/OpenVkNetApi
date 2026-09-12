<div class="vk-card">

# stickers.get

Возвращает список доступных наборов стикеров или информацию о конкретных наборах.

# Вызов метода

```csharp
Collection<StickerPack> packs = await api.Stickers.GetAsync(
    filter: "available",
    count: 50
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **stickerPackIds** <br> `IEnumerable<int>` | Идентификаторы интересующих наборов стикеров. <br> <span style="color: var(--vp-c-text-3)">список целых чисел</span> |
| **filter** <br> `string` | Фильтр возвращаемых наборов (`"available"`, `"purchased"`, `"promoted"`). <br> <span style="color: var(--vp-c-text-3)">строка</span> |
| **offset** <br> `int?` | Смещение относительно начала списка. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **count** <br> `int?` | Количество возвращаемых наборов (по умолчанию 30). <br> <span style="color: var(--vp-c-text-3)">целое число</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `Collection<StickerPack>`, содержащий количество элементов и список наборов стикеров `StickerPack`.

</div>
