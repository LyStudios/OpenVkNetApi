<div class="vk-card">

# utils.resolveGuid

Возвращает профиль пользователя по его уникальному идентификатору GUID.

<div class="vk-info">
  <span>💡 Для вызова этого метода не требуется авторизация пользователя (токен необязателен).</span>
</div>

## Вызов метода

```csharp
var user = await api.Utils.ResolveGuidAsync("550e8400-e29b-41d4-a716-446655440000");
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **guid** <br> `string` | Строковое представление GUID пользователя. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект профиля пользователя [User](/reference/models/users/user).

</div>
