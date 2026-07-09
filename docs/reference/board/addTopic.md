<div class="vk-card">

# board.addTopic

Создает новую тему в обсуждениях группы/сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя. У пользователя должны быть права на создание тем в данном сообществе.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Board;

var parameters = new BoardAddTopicParams
{
    GroupId = 1,
    Title = "Обсуждение новой версии",
    Text = "Здесь вы можете оставлять свои отзывы и предложения."
};

int topicId = await api.Board.AddTopicAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `BoardAddTopicParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **GroupId** <br> `int` | Идентификатор сообщества, в котором создается тема. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **Title** <br> `string` | Заголовок темы обсуждения. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **Text** <br> `string` | Текст первого (стартового) сообщения в теме. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **FromGroup** <br> `bool?` | Публиковать ли тему от имени сообщества. <br> <span style="color: var(--vp-c-text-3)">логический тип, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает уникальный идентификатор созданной темы (`int`).

</div>
