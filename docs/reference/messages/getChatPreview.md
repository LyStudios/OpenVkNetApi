<div class="vk-card">

# messages.getChatPreview

Возвращает информацию о беседе перед вступлением по ссылке-приглашению.

# Вызов метода

```csharp
ChatPreviewResponse preview = await api.Messages.GetChatPreviewAsync(
    link: "https://openvk.su/messages?act=join_chat&chat=..."
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **link** <br> `string` | Ссылка-приглашение в беседу. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **fields** <br> `string` | Дополнительные поля профилей участников через запятую. <br> <span style="color: var(--vp-c-text-3)">строка</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `ChatPreviewResponse`, содержащий превью беседы `Preview` (`ChatPreview`), список профилей участников `Profiles` и сообществ `Groups`.

</div>
