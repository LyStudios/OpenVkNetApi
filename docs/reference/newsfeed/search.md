<div class="vk-card">

# newsfeed.search

Позволяет искать посты (записи на стенах) по ключевому слову или фразе по всему серверу OpenVK.

<div class="vk-warning">
  <span>💡 Этот метод является открытым и не требует авторизации пользователя.</span>
</div>


# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Newsfeed;

var parameters = new NewsfeedSearchParams
{
    Query = "bocchi",
    Count = 10
};

var searchResults = await api.Newsfeed.SearchAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `NewsfeedSearchParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **Query** <br> `string` | Поисковый запрос (ключевое слово или фраза). <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **Count** <br> `int` | Количество записей, которое необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 30, максимум: 100</span> |
| **StartFrom** <br> `string` | Идентификатор для получения следующей страницы результатов (возвращается в `NextFrom`). <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **StartTime** <br> `int` | Начальный UNIX-таймштамп для фильтрации результатов. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **EndTime** <br> `int` | Конечный UNIX-таймштамп для фильтрации результатов. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Extended** <br> `bool` | `true`, если необходимо получить расширенную информацию о пользователях и сообществах. <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: true</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [NewsfeedCollection](/reference/models/newsfeed/newsfeed-collection), содержащий список объектов [Post](/reference/models/wall/post) и строку `NextFrom` для пагинации.

</div>
