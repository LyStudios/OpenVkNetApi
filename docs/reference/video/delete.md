<div class="vk-card">

# video.delete

Удаляет видеозапись.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
bool ok = await api.Video.DeleteAsync(
    videoId: 10
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **videoId** <br> `int` | Идентификатор видеозаписи. |
| **ownerId** <br> `int` | Идентификатор владельца видеозаписи. |

</div>

<div class="vk-card">

# Результат

Возвращает `bool` (`true` при успешном удалении).

</div>
