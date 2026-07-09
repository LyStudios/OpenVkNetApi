<div class="vk-card">

# notifications.fetch

Получает новые уведомления (метод для периодического получения обновлений / лонгполлинга).

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя с правами доступа к уведомлениям.</span>
</div>

## Вызов метода

```csharp
using System.Threading;

CancellationTokenSource cts = new CancellationTokenSource();
var fetchResult = await api.Notifications.FetchAsync(lastId: "0", ct: cts.Token);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **lastId** <br> `string` | Идентификатор последнего обработанного уведомления. <br> <span style="color: var(--vp-c-text-3)">строка, по умолчанию: "0"</span> |
| **ct** <br> `CancellationToken` | Токен отмены для асинхронной операции. <br> <span style="color: var(--vp-c-text-3)">необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [NotificationsFetch](/reference/models/notifications/notifications-fetch), содержащий список новых уведомлений, профили упомянутых пользователей и сообществ, а также идентификаторы для последующих запросов (`NextLastId`, `NewLastId`).

</div>
