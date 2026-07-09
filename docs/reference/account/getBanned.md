<div class="vk-card">

# account.getBanned

Возвращает список пользователей, добавленных в черный список текущего аккаунта.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.Enums;

var bannedUsers = await api.Account.GetBannedAsync(offset: 0, count: 50, fields: UserFields.Sex);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **offset** <br> `int` | Смещение, необходимое для выборки определенного подмножества пользователей. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **count** <br> `int` | Количество пользователей, которое необходимо вернуть. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 100, максимум: 200</span> |
| **fields** <br> `UserFields` | Список дополнительных полей профилей пользователей, которые необходимо вернуть. <br> <span style="color: var(--vp-c-text-3)">перечисление UserFields, по умолчанию: UserFields.None</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<User>`, содержащую список объектов [User](/reference/models/users/user).

</div>
