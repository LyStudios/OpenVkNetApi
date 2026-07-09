<div class="vk-card">

# utils.resolveScreenName

Определяет тип и идентификатор объекта (пользователя, сообщества, приложения) по его короткому имени (screen_name).

<div class="vk-info">
  <span>💡 Для вызова этого метода не требуется авторизация пользователя (токен необязателен).</span>
</div>

## Вызов метода

```csharp
var resolvedObject = await api.Utils.ResolveScreenNameAsync("durov");
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **screenName** <br> `string` | Короткое буквенно-цифровое имя страницы. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [UtilsResolveScreenName](/reference/models/utils/utils-resolve-screen-name), содержащий тип объекта и его числовой идентификатор. Если имя не найдено, возвращает `null`.

</div>
