<div class="vk-card">

# photos.getChatUploadServer

Возвращает адрес сервера для загрузки фотографии беседы.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var server = await api.Photos.GetChatUploadServerAsync(
    chatId: 1
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **chatId** <br> `int` | Идентификатор беседы. |
| **cropX** <br> `int` | Координата X обрезки. |
| **cropY** <br> `int` | Координата Y обрезки. |
| **cropWidth** <br> `int` | Ширина обрезки. |

</div>

<div class="vk-card">

# Результат

Возвращает [PhotosUploadServer](/reference/models/photos/photos-upload-server) с адресом `UploadUrl`.

</div>
