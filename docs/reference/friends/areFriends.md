<div class="vk-card">

# friends.areFriends

Проверяет статус отношений (дружба, заявка) между текущим пользователем и списком других пользователей.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var friendshipStatuses = await api.Friends.AreFriendsAsync(userIds: "1,2,3");
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **userIds** <br> `string` | Список идентификаторов проверяемых пользователей, разделенных запятыми. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает список `List<FriendStatus>`, содержащий объекты отношений [FriendStatus](/reference/models/friends/friend-status).

</div>
