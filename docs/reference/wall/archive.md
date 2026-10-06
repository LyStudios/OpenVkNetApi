<div class="vk-card">

# wall.archive

Отправляет запись со стены в архив.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
bool ok = await api.Wall.ArchiveAsync(
    ownerId: 1,
    postId: 105
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **ownerId** <br> `int` | Идентификатор владельца стены. |
| **postId** <br> `int` | Идентификатор записи для архивации. |

</div>

<div class="vk-card">

# Результат

Возвращает `bool` (`true` при успешной архивации).

</div>
