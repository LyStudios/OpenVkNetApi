<div class="vk-card">

# photos.uploadChatPhoto

Высокоуровневый вспомогательный метод для загрузки и установки фотографии (аватара) групповой беседы из локального потока (`Stream`).

<div class="vk-warning">
  <span>💡 Метод автоматически получает upload-сервер, отправляет multipart-запрос и сохраняет фото через `messages.setChatPhoto`.</span>
</div>

# Вызов метода

```csharp
using var stream = File.OpenRead("chat_avatar.jpg");
ChatPhotoUploadResult result = await api.Photos.UploadChatPhotoAsync(
    photoStream: stream,
    fileName: "chat_avatar.jpg",
    chatId: 1
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **photoStream** <br> `Stream` | Поток с бинарными данными изображения. |
| **fileName** <br> `string` | Имя файла изображения (например, `"image.png"`). |
| **chatId** <br> `int` | Идентификатор беседы. |
| **groupId** <br> `int` | Идентификатор сообщества (если чат принадлежит группе). |

</div>

<div class="vk-card">

# Результат

Возвращает [ChatPhotoUploadResult](/reference/models/photos/chat-photo-upload-result), содержащий результат вызова `messages.setChatPhoto`.

</div>
