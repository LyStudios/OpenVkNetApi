<div class="vk-card">

# newsfeed.getBanned

Возвращает список пользователей и сообществ, которые были скрыты (забанены) из ленты новостей текущего пользователя.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Newsfeed;

var parameters = new NewsfeedGetBannedParams
{
    UserFields = "online,sex"
};

var bannedList = await api.Newsfeed.GetBannedAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `NewsfeedGetBannedParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **UserFields** <br> `string` | Дополнительные профильные поля для возвращаемых пользователей. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **GroupFields** <br> `string` | Дополнительные поля для возвращаемых сообществ. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [NewsfeedGetBanned](/reference/models/newsfeed/newsfeed-get-banned), содержащий списки забаненных пользователей и сообществ.

</div>
