<div class="vk-card">

# store.removeFavoriteSticker

Удаляет стикер из списка избранных.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
bool ok = await api.Store.RemoveFavoriteStickerAsync(
    stickerId: 105
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **stickerId** <br> `int` | Идентификатор удаляемого стикера. |

</div>

<div class="vk-card">

# Результат

Возвращает `bool` (`true` при успешном удалении).

</div>
