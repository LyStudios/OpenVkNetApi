<div class="vk-card">

# photos.getComments

Возвращает список комментариев к указанной фотографии.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Photos;

var parameters = new PhotosGetCommentsParams
{
    OwnerId = 1,
    PhotoId = 123,
    Count = 10
};

var commentsCollection = await api.Photos.GetCommentsAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `PhotosGetCommentsParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **OwnerId** <br> `int?` | Идентификатор владельца фотографии. Для сообщества используйте отрицательное значение. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: текущий пользователь</span> |
| **PhotoId** <br> `int` | Идентификатор фотографии. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **NeedLikes** <br> `bool` | Возвращать ли информацию об отметках "Мне нравится". <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |
| **StartCommentId** <br> `int?` | Идентификатор начального комментария. <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **Offset** <br> `int` | Смещение для выборки комментариев. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество комментариев, которое необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20, максимум: 100</span> |
| **Sort** <br> `string` | Сортировка комментариев (`asc` — по возрастанию даты, `desc` — по убыванию). <br> <span style="color: var(--vp-c-text-3)">строка, по умолчанию: "asc"</span> |

</div>

<div class="vk-card">

# Результат

Возвращает расширенную коллекцию `ExtendedCollection<PhotoComment>` с комментариями [PhotoComment](/reference/models/photos/photo-comments).

</div>
