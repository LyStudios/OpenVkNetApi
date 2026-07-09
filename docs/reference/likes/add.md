<div class="vk-card">

# likes.add

Добавляет отметку «Мне нравится» к указанному объекту (посту, комментарию, фотографии и т.д.).

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var result = await api.Likes.AddAsync(type: "post", ownerId: 1, itemId: 12);
Console.WriteLine($"Всего лайков: {result.Likes}");
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **type** <br> `string` | Тип объекта (например, `post` — запись на стене, `comment` — комментарий, `photo` — фотография, `video` — видеозапись). <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **ownerId** <br> `int` | Идентификатор владельца объекта. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **itemId** <br> `int` | Уникальный идентификатор объекта. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [LikesAdd](/reference/models/likes/likes-add), содержащий обновленное количество отметок «Мне нравится» у объекта.

</div>
