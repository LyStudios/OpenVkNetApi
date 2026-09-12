<div class="vk-card">

# messages.removeChatUser

Исключает пользователя из групповой беседы или позволяет покинуть беседу текущему пользователю.

# Вызов метода

```csharp
int result = await api.Messages.RemoveChatUserAsync(
    chatId: 1,
    userId: 2
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **chatId** <br> `int` | Идентификатор беседы. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **userId** <br> `int` | Идентификатор исключаемого пользователя (если указан свой ID — пользователь покидает беседу). <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного исключения или выхода.

</div>
