<div class="vk-card">

# video.get

Возвращает список видеозаписей по заданным фильтрам.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Video;

var parameters = new VideoGetParams
{
    OwnerId = 1,
    Count = 10
};

var videoCollection = await api.Video.GetAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `VideoGetParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **OwnerId** <br> `int?` | Идентификатор владельца видеозаписей. Для сообщества укажите отрицательное значение. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: текущий пользователь</span> |
| **Videos** <br> `string` | Список видеозаписей через запятую в формате `owner_id_video_id`. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **AlbumId** <br> `int?` | Идентификатор альбома с видеозаписями. <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **Offset** <br> `int` | Смещение выборки. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество видеозаписей, которое необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20, максимум: 200</span> |
| **Extended** <br> `bool` | Возвращать ли дополнительную информацию (лайки, возможность комментировать). <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |

</div>

<div class="vk-card">

# Результат

Возвращает расширенную коллекцию `ExtendedCollection<Video>` с объектами видеозаписей [Video](/reference/models/video/video).

</div>
