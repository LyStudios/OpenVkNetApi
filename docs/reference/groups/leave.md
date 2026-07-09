<div class="vk-card">

# groups.leave

Выходит из сообщества (группы, публичной страницы, мероприятия) или отменяет заявку на вступление.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
int result = await api.Groups.LeaveAsync(groupId: 12);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **groupId** <br> `int` | Идентификатор сообщества, из которого нужно выйти. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного выхода.

</div>
