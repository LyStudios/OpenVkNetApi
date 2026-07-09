<div class="vk-card">

# polls.getById

Возвращает детальную информацию об опросе по его идентификатору.

<div class="vk-info">
  <span>💡 Для вызова этого метода не требуется авторизация пользователя (токен необязателен).</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.Enums;

var pollData = await api.Polls.GetByIdAsync(
    pollId: 45,
    extended: true,
    fields: UserFields.FirstName | UserFields.LastName
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **pollId** <br> `int` | Идентификатор опроса. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **extended** <br> `bool` | Возвращать ли дополнительную информацию о проголосовавших. <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |
| **fields** <br> `UserFields` | Дополнительные поля профилей пользователей, если `extended` установлен в `true`. <br> <span style="color: var(--vp-c-text-3)">перечисление флагов, по умолчанию: UserFields.None</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект `PollsGetById`, содержащий поле `Poll` с детальной информацией об опросе [Poll](/reference/models/polls/poll).

</div>
