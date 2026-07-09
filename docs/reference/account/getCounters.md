<div class="vk-card">

# account.getCounters

Возвращает счетчики непрочитанных сообщений, новых заявок в друзья, уведомлений и др.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var counters = await api.Account.GetCountersAsync(filter: "friends,messages");
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **filter** <br> `string` | Список счетчиков, которые необходимо получить, разделенных запятыми (например, `friends,messages,notifications`). <br> <span style="color: var(--vp-c-text-3)">необязательный параметр, по умолчанию возвращаются все доступные счетчики</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [AccountCounters](/reference/models/account/account-counters) со значениями запрошенных счетчиков.

</div>
