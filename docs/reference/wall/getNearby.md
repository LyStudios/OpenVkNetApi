<div class="vk-card">

# wall.getNearby

Возвращает список постов с ближайшими гео-метками относительно выбранного поста.

## Вызов метода

```csharp
WallGet nearbyPosts = await api.Wall.GetNearbyAsync(ownerId: 10, postId: 42);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **ownerId** <br> `int` | **Обязательный.** Идентификатор владельца поста. |
| **postId** <br> `int` | **Обязательный.** Идентификатор базового поста, содержащего координаты. |

</div>

<div class="vk-card">

# Результат

Возвращает объект [WallGet](/reference/models/wall/wall-get), содержащий найденные посты.

</div>
