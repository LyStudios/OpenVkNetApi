<div class="vk-card">

# messages.getLongPollServer

Возвращает адрес сервера, ключ сессии и последний таймштамп для подключения к службе Long Poll сообщений.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя или сообщества.</span>
</div>

# Вызов метода

```csharp
var lpInfo = await api.Messages.GetLongPollServerAsync(needPts: 1, lpVersion: 3);
Console.WriteLine($"Адрес сервера: {lpInfo.Server}");
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **needPts** <br> `int` | Возвращать ли поле `pts`, необходимое для получения упущенной истории событий (`0` — не возвращать, `1` — возвращать). <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 1</span> |
| **lpVersion** <br> `int` | Версия протокола Long Poll. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 3</span> |
| **groupId** <br> `int?` | Идентификатор сообщества (для работы Long Poll от имени бота сообщества). <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [LongPollServerInfo](/reference/models/messages/long-poll-server-info), содержащий ключ сессии (`Key`), хост сервера (`Server`) и временную метку (`Ts`).

</div>
