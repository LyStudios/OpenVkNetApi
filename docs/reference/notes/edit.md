<div class="vk-card">

# notes.edit

Редактирует существующую заметку.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя с правами доступа к заметкам.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Notes;

var parameters = new NotesEditParams
{
    NoteId = 12,
    Title = "Новый заголовок",
    Text = "Обновленный текст заметки"
};

int result = await api.Notes.EditAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `NotesEditParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **NoteId** <br> `int` | Идентификатор заметки. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **Title** <br> `string` | Новый заголовок заметки. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **Text** <br> `string` | Новый текст заметки. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного выполнения.

</div>
