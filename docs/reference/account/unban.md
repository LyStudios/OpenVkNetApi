<div class="vk-card">

# account.unban

Удаляет пользователя из черного списка текущего аккаунта (разблокирует).

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
int result = await api.Account.UnbanAsync(ownerId: 1);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **ownerId** <br> `int` | Идентификатор пользователя, которого необходимо разблокировать. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешной разблокировки.

</div>
