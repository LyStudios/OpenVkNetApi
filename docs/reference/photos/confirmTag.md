<div class="vk-card">

# photos.confirmTag

Подтверждает отметку текущего пользователя на фотографии.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
bool ok = await api.Photos.ConfirmTagAsync(
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
| **tagId** <br> `int` | ID подтверждаемой отметки. |

</div>

<div class="vk-card">

# Результат

Возвращает `bool` (`true` при успешном подтверждении).

</div>
