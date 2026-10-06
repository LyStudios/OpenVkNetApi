<div class="vk-card">

# photos.uploadMessagesPhoto

Высокоуровневый вспомогательный метод для загрузки фотографии в личные сообщения из потока данных (`Stream`).

<div class="vk-warning">
  <span>💡 Метод автоматически получает upload-сервер сообщений, отправляет multipart-запрос и вызывает `photos.saveMessagesPhoto`.</span>
</div>

# Вызов метода

```csharp
using var stream = File.OpenRead("picture.jpg");
List<Photo> photos = await api.Photos.UploadMessagesPhotoAsync(
    photoStream: stream,
    fileName: "picture.jpg"
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **photoStream** <br> `Stream` | Поток с бинарными данными фотографии. |
| **fileName** <br> `string` | Имя файла фотографии. |

</div>

<div class="vk-card">

# Результат

Возвращает `List<Photo>` с сохраненным объектом фотографии, готовым к прикреплению в сообщение в формате `photo{owner_id}_{id}`.

</div>
