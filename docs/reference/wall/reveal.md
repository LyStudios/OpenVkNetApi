<div class="vk-card">

# wall.reveal

Восстанавливает ранее архивированную запись на стене.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
bool ok = await api.Wall.RevealAsync(
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
| **postId** <br> `int` | Идентификатор восстанавливаемой записи. |

</div>

<div class="vk-card">

# Результат

Возвращает `bool` (`true` при успешном разархивировании).

</div>
