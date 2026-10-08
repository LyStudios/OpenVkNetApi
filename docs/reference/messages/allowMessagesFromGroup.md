<div class="vk-card">

# messages.allowMessagesFromGroup

Разрешает отправку сообщений от сообщества текущему пользователю.

# Вызов метода

```csharp
int result = await api.Messages.AllowMessagesFromGroupAsync(
    groupId: 1
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **groupId** <br> `long` | Идентификатор сообщества. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **key** <br> `string` | Произвольная строка ключа доступа. <br> <span style="color: var(--vp-c-text-3)">строка</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного разрешения.

</div>
