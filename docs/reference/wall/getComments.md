<div class="vk-card">

# wall.getComments

Возвращает список комментариев к записи на стене.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Wall;

var parameters = new WallGetCommentsParams
{
    OwnerId = 1,
    PostId = 123,
    Count = 10
};

var commentsData = await api.Wall.GetCommentsAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `WallGetCommentsParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **OwnerId** <br> `int?` | Идентификатор владельца записи на стене. Для сообщества укажите отрицательное значение. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: текущий пользователь</span> |
| **PostId** <br> `int` | Идентификатор записи на стене. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **NeedLikes** <br> `bool` | Возвращать ли лайки к комментариям. <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |
| **StartCommentId** <br> `int?` | Начальный идентификатор комментария для выборки. <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **Offset** <br> `int` | Смещение относительно начала выборки комментариев. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество комментариев, которое необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20, максимум: 100</span> |
| **Sort** <br> `string` | Порядок сортировки комментариев (`asc` — по возрастанию даты, `desc` — по убыванию). <br> <span style="color: var(--vp-c-text-3)">строка, по умолчанию: "asc"</span> |
| **PreviewLength** <br> `int` | Максимальная длина превью текста. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Extended** <br> `bool` | Возвращать ли дополнительную информацию о профилях и сообществах авторов комментариев. <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект `WallGetComments`, содержащий общее количество комментариев (`Count`) и список комментариев в поле `Items` (объекты `WallComment`).

</div>
