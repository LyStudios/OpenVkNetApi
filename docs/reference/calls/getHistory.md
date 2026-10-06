<div class="vk-card">

# calls.getHistory

Возвращает историю совершенных и принятых аудио/видео вызовов текущего пользователя.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var history = await api.Calls.GetHistoryAsync(
    count: 20,
    offset: 0
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **count** <br> `int` | Количество записей в истории (по умолчанию 20). |
| **offset** <br> `int` | Смещение относительно начала списка. |

</div>

<div class="vk-card">

# Результат

Возвращает объект [CallsHistory](/reference/models/calls/calls-history), содержащий общее количество звонков `Count` и список объектов звонков `Items`.

</div>
