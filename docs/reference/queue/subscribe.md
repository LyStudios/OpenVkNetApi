<div class="vk-card">

# queue.subscribe

Подписывает клиента на очередь событий реального времени.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var subscription = await api.Queue.SubscribeAsync(
    queueNames: new[] { "messages", "notifications" }
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **queueNames** <br> `IEnumerable<string>` | Список названий очередей для подписки. |

</div>

<div class="vk-card">

# Результат

Возвращает [QueueSubscribeResult](/reference/models/queue/queue-subscribe-result), содержащий ключ доступа и параметры подключения к очереди.

</div>
