<div class="vk-card">

# polls.create

Создает новый опрос, который затем можно прикрепить к записи или сообщению.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Polls;

var parameters = new PollsCreateParams
{
    Question = "Какой язык программирования ваш любимый?",
    Answers = new[] { "C#", "PHP", "JavaScript" },
    IsAnonymous = true
};

var poll = await api.Polls.CreateAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `PollsCreateParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **Question** <br> `string` | Текст вопроса опроса. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **IsAnonymous** <br> `bool` | Анонимный ли опрос. <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |
| **Multiple** <br> `bool` | Можно ли выбрать несколько вариантов ответа. <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |
| **EndDate** <br> `long?` | Дата окончания опроса в формате Unix-time. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: нет ограничения</span> |
| **OwnerId** <br> `int?` | Идентификатор владельца (например, сообщества), в котором создается опрос. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: текущий пользователь</span> |
| **Answers** <br> `IEnumerable<string>` | Коллекция вариантов ответов опроса. Автоматически сериализуется в JSON перед отправкой. <br> <span style="color: var(--vp-c-text-3)">коллекция строк, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект созданного опроса [Poll](/reference/models/polls/poll).

</div>
