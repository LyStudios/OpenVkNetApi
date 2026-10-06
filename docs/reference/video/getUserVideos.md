<div class="vk-card">

# video.getUserVideos

Возвращает список видеозаписей указанного пользователя или сообщества.

# Вызов метода

```csharp
var videos = await api.Video.GetUserVideosAsync(
    ownerId: 1,
    count: 20
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **ownerId** <br> `int` | Идентификатор владельца видеозаписей (пользователя или группы с минусом). |
| **count** <br> `int` | Количество видеозаписей (по умолчанию 20). |
| **offset** <br> `int` | Смещение для выборки. |
| **extended** <br> `bool` | Расширенная информация о видео. |

</div>

<div class="vk-card">

# Результат

Возвращает [Collection&lt;Video&gt;](/reference/models/video/video) со списком видеозаписей.

</div>
