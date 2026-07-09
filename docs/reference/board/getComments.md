<div class="vk-card">

# board.getComments

Возвращает список комментариев к теме обсуждения в сообществе.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Board;

var parameters = new BoardGetCommentsParams
{
    GroupId = 1,
    TopicId = 12,
    Count = 20,
    Offset = 0
};

var commentsList = await api.Board.GetCommentsAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `BoardGetCommentsParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **GroupId** <br> `int` | Идентификатор сообщества, в котором находится тема. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **TopicId** <br> `int` | Идентификатор темы обсуждения. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **Offset** <br> `int` | Смещение для выборки определенного подмножества комментариев. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество комментариев, которое необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20, максимум: 100</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [BoardCommentsList](/reference/models/board/board-comments-list), содержащий список объектов комментариев.

</div>
