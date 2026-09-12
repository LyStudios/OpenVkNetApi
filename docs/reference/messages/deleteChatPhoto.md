<div class="vk-card">

# messages.deleteChatPhoto

Удаляет аватар (фотографию) групповой беседы.

# Вызов метода

```csharp
ChatPhotoResponse result = await api.Messages.DeleteChatPhotoAsync(
    chatId: 1
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **chatId** <br> `int` | Идентификатор беседы. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `ChatPhotoResponse`, содержащий идентификатор служебного сообщения `MessageId` и объект беседы `Chat`.

</div>
