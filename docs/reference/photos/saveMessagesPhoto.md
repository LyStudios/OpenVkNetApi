<div class="vk-card">

# photos.saveMessagesPhoto

Сохраняет фотографию после успешной отправки на upload-сервер сообщений.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var photos = await api.Photos.SaveMessagesPhotoAsync(
    photo: "...",
    server: 1,
    hash: "..."
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **photo** <br> `string` | Параметр `photo`, полученный в ответе upload-сервера. |
| **server** <br> `int` | Параметр `server`, полученный в ответе upload-сервера. |
| **hash** <br> `string` | Параметр `hash`, полученный в ответе upload-сервера. |

</div>

<div class="vk-card">

# Результат

Возвращает `List<Photo>` с сохраненными объектами фотографий.

</div>
