<div class="vk-card">

# likes.isLiked

Проверяет, поставил ли текущий или указанный пользователь отметку «Мне нравится» объекту.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Likes;

var parameters = new LikesIsLikedParams
{
    Type = "post",
    OwnerId = 1,
    ItemId = 12
};

var info = await api.Likes.IsLikedAsync(parameters);
Console.WriteLine($"Поставил лайк: {info.Liked}");
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `LikesIsLikedParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **Type** <br> `string` | Тип объекта (например, `post`, `comment`, `photo`). <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **OwnerId** <br> `int` | Идентификатор владельца объекта. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **ItemId** <br> `int` | Уникальный идентификатор объекта. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **UserId** <br> `int?` | Идентификатор пользователя, наличие лайка которого нужно проверить. Если не указан, проверяется текущий пользователь. <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [LikesIsLiked](/reference/models/likes/likes-is-liked), содержащий информацию о наличии лайка (`Liked` — логический флаг) и возможности поставить лайк (`Copied`).

</div>
