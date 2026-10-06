<div class="vk-card">

# photos.getUserPhotos

Возвращает список фотографий, на которых отмечен указанный пользователь.

# Вызов метода

```csharp
var photos = await api.Photos.GetUserPhotosAsync(
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
| **offset** <br> `int` | Смещение для пагинации. |
| **count** <br> `int` | Количество фотографий. |
| **extended** <br> `bool` | Расширенная информация (лайки, комментарии). |
| **sort** <br> `string` | Порядок сортировки. |

</div>

<div class="vk-card">

# Результат

Возвращает [ExtendedCollection&lt;Photo&gt;](/reference/models/extended-collection) со списком фотографий с отметками пользователя.

</div>
