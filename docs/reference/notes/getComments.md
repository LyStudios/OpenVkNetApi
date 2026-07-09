<div class="vk-card">

# notes.getComments

Возвращает список комментариев к заметке.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя с правами доступа к заметкам.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Notes;

var parameters = new NotesGetCommentsParams
{
    NoteId = 12,
    Count = 10,
    Offset = 0
};

var collection = await api.Notes.GetCommentsAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `NotesGetCommentsParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **NoteId** <br> `int` | Идентификатор заметки. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **OwnerId** <br> `int?` | Идентификатор владельца заметки. <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **Offset** <br> `int` | Смещение для выборки определенного подмножества комментариев. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество комментариев, которое необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20, максимум: 100</span> |
| **Sort** <br> `int` | Сортировка результатов. <br> <span style="color: var(--vp-c-text-3)">целое число (0 — по дате добавления в порядке возрастания, 1 — по убыванию), по умолчанию: 0</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<NoteComment>`, содержащую общее количество комментариев и список объектов [NoteComment](/reference/models/comments/note-comment).

</div>
