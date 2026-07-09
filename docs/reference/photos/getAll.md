<div class="vk-card">

# photos.getAll

Возвращает все фотографии пользователя или сообщества в одном списке (включая системные альбомы).

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Photos;

var parameters = new PhotosGetAllParams
{
    OwnerId = 1,
    Count = 10
};

var allPhotos = await api.Photos.GetAllAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `PhotosGetAllParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **OwnerId** <br> `int?` | Идентификатор владельца фотографий. Для сообщества укажите отрицательное значение. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: текущий пользователь</span> |
| **Offset** <br> `int` | Смещение выборки. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Максимальное количество фотографий. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20, максимум: 200</span> |
| **Extended** <br> `bool` | Возвращать ли дополнительную информацию (лайки, комменты). <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |
| **NoServiceAlbums** <br> `bool` | Исключать ли сервисные альбомы (например, фото со стены). <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |
| **SkipHidden** <br> `bool` | Пропускать ли скрытые альбомы. <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<Photo>` с объектами фотографий [Photo](/reference/models/photos/photo).

</div>
