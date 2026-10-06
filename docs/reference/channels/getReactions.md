<div class="vk-card">

# channels.getReactions

Возвращает конфигурацию и карту реакций, доступных для канала или публикации.

# Вызов метода

```csharp
var reactions = await api.Channels.GetReactionsAsync(
    channelId: 1
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **channelId** <br> `int` | Идентификатор канала. |

</div>

<div class="vk-card">

# Результат

Возвращает объект [ChannelReactionsMapping](/reference/models/channels/channel-reactions-mapping) со списком доступных реакций и их свойствами.

</div>
