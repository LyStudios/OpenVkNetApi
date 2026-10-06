<div class="vk-card">

# store.addFavoriteSticker

Добавляет указанный стикер в избранные стикеры пользователя.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
bool ok = await api.Store.AddFavoriteStickerAsync(
    stickerId: 105
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **stickerId** <br> `int` | Идентификатор добавляемого стикера. |

</div>

<div class="vk-card">

# Результат

Возвращает `bool` (`true` при успешном добавлении).

</div>
