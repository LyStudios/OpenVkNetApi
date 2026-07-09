<div class="vk-card">

# wall.createComment

Создает новый комментарий к записи на стене.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Wall;

var parameters = new WallCreateCommentParams
{
    OwnerId = 1,
    PostId = 123,
    Message = "Отличная запись!"
};

var commentResult = await api.Wall.CreateCommentAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `WallCreateCommentParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **OwnerId** <br> `int?` | Идентификатор владельца стены. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: текущий пользователь</span> |
| **PostId** <br> `int` | Идентификатор записи на стене. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **FromGroup** <br> `int?` | Идентификатор сообщества, от имени которого публикуется комментарий. <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **Message** <br> `string` | Текст комментария. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр (если нет вложений)</span> |
| **ReplyToComment** <br> `int?` | Идентификатор комментария, на который создается ответ. <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **Attachments** <br> `string` | Список вложений в формате `typeowner_id_media_id`. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **StickerId** <br> `int?` | Идентификатор стикера. <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **Guid** <br> `string` | Уникальный GUID для предотвращения дублирования комментариев. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект `WallCreateComment`, содержащий идентификатор созданного комментария в поле `CommentId`.

</div>
