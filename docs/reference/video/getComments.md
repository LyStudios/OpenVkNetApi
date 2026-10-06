<div class="vk-card">

# video.getComments

Возвращает список комментариев к видеозаписи.

# Вызов метода

```csharp
var comments = await api.Video.GetCommentsAsync(
    videoId: 10,
    count: 20
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **videoId** <br> `int` | Идентификатор видеозаписи. |
| **ownerId** <br> `int` | Идентификатор владельца видеозаписи. |
| **needLikes** <br> `bool` | Возвращать ли информацию о лайках к комментариям. |
| **startCommentId** <br> `int` | Идентификатор комментария для отсчета. |
| **offset** <br> `int` | Смещение. |
| **count** <br> `int` | Количество комментариев (по умолчанию 20). |
| **sort** <br> `string` | Порядок сортировки (`"asc"` или `"desc"`). |

</div>

<div class="vk-card">

# Результат

Возвращает [ExtendedCollection&lt;VideoComment&gt;](/reference/models/comments/video-comment) со списком комментариев.

</div>
