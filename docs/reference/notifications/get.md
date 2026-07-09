<div class="vk-card">

# notifications.get

Возвращает список уведомлений для текущего пользователя.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя с правами доступа к уведомлениям.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Notifications;

var parameters = new NotificationsGetParams
{
    Count = 10,
    Offset = 0
};

var collection = await api.Notifications.GetAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `NotificationsGetParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **Count** <br> `int` | Количество возвращаемых уведомлений. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 10</span> |
| **From** <br> `string` | Токен для получения следующей страницы уведомлений. <br> <span style="color: var(--vp-c-text-3)">строка, по умолчанию: пустая</span> |
| **Offset** <br> `int` | Смещение для выборки определенного подмножества уведомлений. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **StartFrom** <br> `string` | Значение `start_from`, полученное в предыдущем запросе для пагинации. <br> <span style="color: var(--vp-c-text-3)">строка, по умолчанию: пустая</span> |
| **Filters** <br> `string` | Список фильтров уведомлений через запятую (например, `"mentions,likes"`). <br> <span style="color: var(--vp-c-text-3)">строка, по умолчанию: пустая</span> |
| **StartTime** <br> `int` | Unix-время, начиная с которого необходимо вернуть уведомления. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **EndTime** <br> `int` | Unix-время, до которого необходимо вернуть уведомления. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Archived** <br> `bool` | Возвращать ли архивные уведомления. <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию [ExtendedNotificationsCollection](/reference/models/notifications/extended-notifications-collection) с объектами [Notification](/reference/models/notifications/notification).

</div>
