<div class="vk-card">

# video.edit

Редактирует данные видеозаписи (название, описание).

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
VideoEditResult result = await api.Video.EditAsync(
    videoId: 10,
    name: "Новое название видео",
    desc: "Обновленное описание"
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **videoId** <br> `int` | Идентификатор видеозаписи. |
| **ownerId** <br> `int` | Идентификатор владельца (по умолчанию текущий пользователь). |
| **name** <br> `string` | Новое название видеозаписи. |
| **desc** <br> `string` | Новое описание видеозаписи. |

</div>

<div class="vk-card">

# Результат

Возвращает [VideoEditResult](/reference/models/video/video-edit-result) с результатом редактирования.

</div>
