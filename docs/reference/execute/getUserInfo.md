<div class="vk-card">

# execute.getUserInfo

Возвращает агрегированную информацию о текущем пользователе (профиль, настройки аккаунта, счетчики, начальные данные ленты новостей) за один HTTP-запрос.

## Вызов метода

```csharp
ExecuteUserInfo userInfo = await api.Execute.GetUserInfoAsync();
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **fields** <br> `UserFields` | Список дополнительных полей профиля пользователя для возврата. |

</div>

<div class="vk-card">

# Результат

Возвращает объект [ExecuteUserInfo](/reference/models/execute/execute-user-info), содержащий скомпонованные данные пользователя.

</div>
