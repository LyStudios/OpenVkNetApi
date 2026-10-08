<div class="vk-card">

# messages.isMessagesFromGroupAllowed

Проверяет, разрешена ли отправка сообщений от сообщества текущему пользователю.

# Вызов метода

```csharp
bool isAllowed = await api.Messages.IsMessagesFromGroupAllowedAsync(
    groupId: 1,
    userId: 2
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **groupId** <br> `long` | Идентификатор сообщества. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **userId** <br> `long?` | Идентификатор проверяемого пользователя (по умолчанию текущий пользователь). <br> <span style="color: var(--vp-c-text-3)">целое число</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `true`, если сообщения от сообщества разрешены, иначе `false`.

</div>
