<div class="vk-card">

# notes.get

Возвращает список заметок, созданных пользователем.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя с правами доступа к заметкам.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Notes;

var parameters = new NotesGetParams
{
    Count = 10,
    Offset = 0
};

var collection = await api.Notes.GetAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `NotesGetParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **NoteIds** <br> `string` | Список идентификаторов заметок пользователя через запятую. <br> <span style="color: var(--vp-c-text-3)">необязательный параметр</span> |
| **UserId** <br> `int?` | Идентификатор пользователя, заметки которого нужно получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: текущий пользователь</span> |
| **Offset** <br> `int` | Смещение для выборки определенного подмножества заметок. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество заметок, которое необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20, максимум: 100</span> |
| **Sort** <br> `int` | Сортировка результатов. <br> <span style="color: var(--vp-c-text-3)">целое число (0 — по дате добавления в порядке возрастания, 1 — по убыванию), по умолчанию: 0</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<Note>`, содержащую общее количество заметок и список объектов [Note](/reference/models/notes/note).

</div>
