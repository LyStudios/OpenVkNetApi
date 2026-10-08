<div class="vk-card">

# messages.getInviteLink

Создает или возвращает действующую ссылку-приглашение в групповую беседу.

# Вызов метода

```csharp
string link = await api.Messages.GetInviteLinkAsync(
    peerId: 2000000001,
    reset: false
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **peerId** <br> `long` | Идентификатор назначения (`2000000000 + chat_id`). <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **reset** <br> `bool?` | Аннулировать старую ссылку и сгенерировать новую (`true`). <br> <span style="color: var(--vp-c-text-3)">логическое значение</span> |

</div>

<div class="vk-card">

# Результат

Возвращает строку с URL приглашения в беседу.

</div>
