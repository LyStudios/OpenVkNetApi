<div class="vk-card">

# photos.deleteComment

Удаляет комментарий под фотографией.

## Вызов метода

```csharp
int result = await api.Photos.DeleteCommentAsync(commentId: 456, ownerId: 123);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **commentId** <br> `int` | **Обязательный.** Идентификатор удаляемого комментария. |
| **ownerId** <br> `int` | Идентификатор владельца фотографии. |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного удаления.

</div>
