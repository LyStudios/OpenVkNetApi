<div class="vk-card">

# photos.getById

Возвращает информацию о фотографиях по их идентификаторам.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
var photosList = await api.Photos.GetByIdAsync(
    photos: "1_100,1_101",
    extended: true,
    photoSizes: false
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **photos** <br> `string` | Идентификаторы фотографий, разделенные запятыми, в формате `owner_id_photo_id`. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **extended** <br> `bool` | Возвращать ли дополнительную информацию (лайки, теги и др.). <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |
| **photoSizes** <br> `bool` | Возвращать ли доступные размеры для фотографий. <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |

</div>

<div class="vk-card">

# Результат

Возвращает список `List<Photo>`, содержащий объекты фотографий [Photo](/reference/models/photos/photo).

</div>
