<div class="vk-card">

# photos.getTags

Возвращает список отметок людей на фотографии.

# Вызов метода

```csharp
List<PhotoTag> tags = await api.Photos.GetTagsAsync(
    ownerId: 1,
    photoId: 10
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **ownerId** <br> `int` | Идентификатор владельца фотографии. |
| **photoId** <br> `int` | Идентификатор фотографии. |
| **accessKey** <br> `string` | Ключ доступа для приватных фото. |

</div>

<div class="vk-card">

# Результат

Возвращает `List<PhotoTag>` со списком объектов отметок [PhotoTag](/reference/models/photos/photo-tag).

</div>
