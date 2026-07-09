<div class="vk-card">

# board.createComment

Добавляет новый комментарий в существующую тему обсуждения.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя. Тема должна быть открыта для комментирования.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Board;

var parameters = new BoardCreateCommentParams
{
    GroupId = 1,
    TopicId = 12,
    Message = "Полностью поддерживаю автора!"
};

int commentId = await api.Board.CreateCommentAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `BoardCreateCommentParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **GroupId** <br> `int` | Идентификатор сообщества, в котором находится тема. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **TopicId** <br> `int` | Идентификатор темы обсуждения. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **Message** <br> `string` | Текст комментария. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **FromGroup** <br> `bool?` | Публиковать ли комментарий от имени сообщества (доступно только администраторам). <br> <span style="color: var(--vp-c-text-3)">логический тип, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает уникальный идентификатор созданного комментария (`int`).

</div>
