<div class="vk-card">

# notes.createComment

Создает новый комментарий к заметке.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя с правами доступа к заметкам.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Notes;

var parameters = new NotesCreateCommentParams
{
    NoteId = 12,
    Message = "Отличная заметка!"
};

int commentId = await api.Notes.CreateCommentAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `NotesCreateCommentParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **NoteId** <br> `int` | Идентификатор заметки. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **OwnerId** <br> `int?` | Идентификатор владельца заметки. <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **ReplyTo** <br> `int?` | Идентификатор пользователя, в ответ на чей комментарий пишется текущий. <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **Message** <br> `string` | Текст комментария. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **Guid** <br> `string` | Уникальный идентификатор для предотвращения повторной отправки. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает уникальный идентификатор созданного комментария (`int`).

</div>
