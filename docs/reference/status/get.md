<div class="vk-card">

# status.get

Возвращает статус пользователя или сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
var status = await api.Status.GetAsync(userId: 12, groupId: 0);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **userId** <br> `int` | Идентификатор пользователя, статус которого нужно получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0 (текущий пользователь)</span> |
| **groupId** <br> `int` | Идентификатор сообщества, статус которого нужно получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект статуса [UserStatus](/reference/models/status/user-status).

</div>
