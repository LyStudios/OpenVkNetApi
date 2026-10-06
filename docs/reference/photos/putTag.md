<div class="vk-card">

# photos.putTag

Добавляет отметку человека на фотографию.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
int tagId = await api.Photos.PutTagAsync(
    ownerId: 1,
    photoId: 10,
    userId: 2,
    x: 25.5,
    y: 30.0,
    x2: 45.0,
    y2: 50.0
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **ownerId** <br> `int` | ID владельца фотографии. |
| **photoId** <br> `int` | ID фотографии. |
| **userId** <br> `int` | ID отмечаемого пользователя. |
| **x**, **y**, **x2**, **y2** <br> `double` | Координаты прямоугольной области отметки в процентах (0-100). |

</div>

<div class="vk-card">

# Результат

Возвращает `int` — идентификатор созданной отметки.

</div>
