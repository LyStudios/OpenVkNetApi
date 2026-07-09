<div class="vk-card">

# photos.getAlbums

Возвращает список фотоальбомов пользователя или сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Photos;

var parameters = new PhotosGetAlbumsParams
{
    OwnerId = 1,
    Count = 5
};

var albumsCollection = await api.Photos.GetAlbumsAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `PhotosGetAlbumsParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **OwnerId** <br> `int?` | Идентификатор владельца альбомов. Для сообщества укажите отрицательное значение. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: текущий пользователь</span> |
| **AlbumIds** <br> `string` | Идентификаторы конкретных альбомов через запятую. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **NeedCovers** <br> `bool` | Возвращать ли обложки для альбомов. <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |
| **PhotoSizes** <br> `bool` | Возвращать ли доступные размеры обложки. <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |
| **Offset** <br> `int` | Смещение выборки. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Максимальное количество альбомов. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<Album>`, содержащую список объектов альбомов [Album](/reference/models/photos/album).

</div>
