<div class="vk-card">

# messages.denyMessagesFromGroup

Запрещает отправку сообщений от сообщества текущему пользователю.

# Вызов метода

```csharp
int result = await api.Messages.DenyMessagesFromGroupAsync(
    groupId: 1
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **groupId** <br> `int` | Идентификатор сообщества. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного запрета.

</div>
