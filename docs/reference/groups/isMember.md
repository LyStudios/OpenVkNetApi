<div class="vk-card">

# groups.isMember

Проверяет, является ли указанный пользователь участником сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
// 1. Простой вызов (возвращает 0 или 1)
int isMember = await api.Groups.IsMemberAsync(groupId: "12", userId: 1);

// 2. Расширенный вызов (возвращает объект с подробной информацией)
var memberInfo = await api.Groups.IsMemberExtendedAsync(groupId: "12", userId: 1);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **groupId** <br> `string` | Идентификатор сообщества. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **userId** <br> `int` | Идентификатор проверяемого пользователя. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

В зависимости от вызванного метода:
* При обычном запросе (`IsMemberAsync`) возвращает `1`, если пользователь состоит в сообществе, и `0`, если не состоит.
* При расширенном запросе (`IsMemberExtendedAsync`) возвращает объект [GroupsIsMember](/reference/models/groups/groups-is-member), содержащий детальную информацию (состоит ли пользователь, подал ли заявку на вступление, приглашен ли).

</div>
