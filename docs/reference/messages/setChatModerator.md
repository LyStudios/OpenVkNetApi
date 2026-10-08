<div class="vk-card">

# messages.setChatModerator

Назначает участника модератором групповой беседы.

<div class="vk-warning">
  <span>💡 Для выполнения операции текущий пользователь должен быть создателем или администратором беседы.</span>
</div>

# Вызов метода

```csharp
int result = await api.Messages.SetChatModeratorAsync(
    chatId: 1,
    userId: 2
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **chatId** <br> `long` | Идентификатор беседы. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **userId** <br> `long` | Идентификатор пользователя, назначаемого модератором. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного назначения.

</div>
