<div class="vk-card">

# photos.deleteTag

Удаляет отметку с фотографии.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
bool ok = await api.Photos.DeleteTagAsync(
    ownerId: 1,
    photoId: 10,
    tagId: 5
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **ownerId** <br> `int` | ID владельца фотографии. |
| **photoId** <br> `int` | ID фотографии. |
| **tagId** <br> `int` | ID удаляемой отметки. |

</div>

<div class="vk-card">

# Результат

Возвращает `bool` (`true` при успешном удалении).

</div>
