<div class="vk-card">

# board.getTopics

Возвращает список тем в обсуждениях сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Board;

var parameters = new BoardGetTopicsParams
{
    GroupId = 1,
    Count = 10,
    Offset = 0
};

var topicsList = await api.Board.GetTopicsAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `BoardGetTopicsParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **GroupId** <br> `int` | Идентификатор сообщества, темы которого необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **Offset** <br> `int` | Смещение для выборки определенного подмножества тем. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество тем, которое необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20, максимум: 100</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [BoardTopics](/reference/models/board/board-topics), содержащий список тем обсуждений.

</div>
