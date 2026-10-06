<div class="vk-card">

# video.deleteComment

Удаляет комментарий к видеозаписи.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
bool ok = await api.Video.DeleteCommentAsync(
    commentId: 100
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **commentId** <br> `int` | Идентификатор удаляемого комментария. |
| **ownerId** <br> `int` | Идентификатор владельца видеозаписи. |

</div>

<div class="vk-card">

# Результат

Возвращает `bool` (`true` при успешном удалении).

</div>
