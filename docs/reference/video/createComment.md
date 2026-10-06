<div class="vk-card">

# video.createComment

Создает новый комментарий к видеозаписи.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
VideoCreateCommentResult result = await api.Video.CreateCommentAsync(
    videoId: 10,
    message: "Отличное видео!"
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **videoId** <br> `int` | Идентификатор видеозаписи. |
| **ownerId** <br> `int` | Идентификатор владельца видеозаписи. |
| **message** <br> `string` | Текст комментария. |
| **replyToComment** <br> `int` | ID комментария, на который пишется ответ. |
| **stickerId** <br> `int` | ID прикрепляемого стикера. |
| **attachments** <br> `string` | Прикрепляемые медиавложения через запятую. |

</div>

<div class="vk-card">

# Результат

Возвращает [VideoCreateCommentResult](/reference/models/video/video-create-comment-result) с идентификатором созданного комментария `CommentId`.

</div>
