<div class="vk-card">

# notes.add

Создает новую заметку.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя с правами доступа к заметкам.</span>
</div>

## Вызов метода

```csharp
int noteId = await api.Notes.AddAsync(title, text);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **title** <br> `string` | Заголовок заметки. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **text** <br> `string` | Текст заметки. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает уникальный идентификатор созданной заметки (`int`).

</div>
