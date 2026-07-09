<div class="vk-card">

# notes.delete

Удаляет заметку, созданную текущим пользователем.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя с правами доступа к заметкам.</span>
</div>

## Вызов метода

```csharp
int result = await api.Notes.DeleteAsync(noteId: 12);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **noteId** <br> `int` | Идентификатор удаляемой заметки. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного удаления.

</div>
