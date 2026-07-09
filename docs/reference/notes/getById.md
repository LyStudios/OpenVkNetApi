<div class="vk-card">

# notes.getById

Возвращает заметку по её идентификатору.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя с правами доступа к заметкам.</span>
</div>

## Вызов метода

```csharp
var note = await api.Notes.GetByIdAsync(noteId: 12, ownerId: 1);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **noteId** <br> `int` | Идентификатор заметки. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **ownerId** <br> `int` | Идентификатор владельца заметки. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **needWiki** <br> `bool` | Возвращать ли текст заметки в разметке wiki. <br> <span style="color: var(--vp-c-text-3)">логический тип, по умолчанию: false</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [Note](/reference/models/notes/note).

</div>
