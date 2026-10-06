<div class="vk-card">

# photos.getMessagesUploadServer

Возвращает адрес сервера для загрузки фотографии в личное сообщение.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var server = await api.Photos.GetMessagesUploadServerAsync(
    peerId: 2000000001
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **peerId** <br> `int` | Идентификатор диалога или беседы. |

</div>

<div class="vk-card">

# Результат

Возвращает [PhotosUploadServer](/reference/models/photos/photos-upload-server) с адресом `UploadUrl`.

</div>
