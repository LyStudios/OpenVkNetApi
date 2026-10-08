<div class="vk-card">

# messages.joinChatByInviteLink

Позволяет текущему пользователю вступить в беседу по ссылке-приглашению.

# Вызов метода

```csharp
long chatId = await api.Messages.JoinChatByInviteLinkAsync(
    link: "https://openvk.su/messages?act=join_chat&chat=..."
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **link** <br> `string` | Действующая ссылка-приглашение в беседу. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает идентификатор беседы `chatId`, к которой присоединился пользователь.

</div>
