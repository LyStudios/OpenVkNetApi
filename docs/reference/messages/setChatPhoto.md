<div class="vk-card">

# messages.setChatPhoto

Устанавливает фотографию групповой беседы, предварительно загруженную через upload-сервер.

# Вызов метода

```csharp
ChatPhotoResponse result = await api.Messages.SetChatPhotoAsync(
    file: "{\"response\":\"...\"}"
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **file** <br> `string` | Ответ сервера загрузки фотографий в формате JSON. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `ChatPhotoResponse`, содержащий идентификатор служебного сообщения `MessageId` и объект обновленного чата `Chat`.

</div>
