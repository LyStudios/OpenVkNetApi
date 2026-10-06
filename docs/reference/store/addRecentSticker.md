<div class="vk-card">

# store.addRecentSticker

Добавляет указанный стикер в историю недавних стикеров.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
bool ok = await api.Store.AddRecentStickerAsync(
    stickerId: 105
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **stickerId** <br> `int` | Идентификатор использованного стикера. |

</div>

<div class="vk-card">

# Результат

Возвращает `bool` (`true` при успешной фиксации).

</div>
