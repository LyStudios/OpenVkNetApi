<div class="vk-card">

# photos.get

Возвращает список фотографий из указанного альбома.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Photos;

var parameters = new PhotosGetParams
{
    OwnerId = 1,
    AlbumId = 12,
    Count = 10
};

var photosCollection = await api.Photos.GetAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `PhotosGetParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **OwnerId** <br> `int?` | Идентификатор владельца альбома (пользователя или сообщества). Для сообщества используйте отрицательное значение. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: текущий пользователь</span> |
| **AlbumId** <br> `string` | Идентификатор альбома. Принимает числовой ID или системные имена: `"profile"`, `"wall"`, `"saved"`. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **PhotoIds** <br> `string` | Список идентификаторов фотографий через запятую. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Rev** <br> `bool` | Порядок сортировки (true — обратный, false — прямой). <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |
| **Extended** <br> `bool` | Возвращать ли дополнительную информацию (лайки, теги и др.). <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |
| **FeedType** <br> `string` | Тип фида. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Feed** <br> `int?` | Фид. <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **Offset** <br> `int` | Смещение для выборки определенного подмножества фотографий. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество возвращаемых фотографий. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 50, максимум: 1000</span> |
| **Limit** <br> `int?` | Лимит возвращаемых фотографий (альтернативное имя для Count в OpenVK). <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<Photo>` с объектами фотографий [Photo](/reference/models/photos/photo).

</div>
