<div class="vk-card">

# video.search

Выполняет поиск видеозаписей по текстовому запросу.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Video;

var parameters = new VideoSearchParams
{
    Query = "клип",
    Count = 10
};

var videoCollection = await api.Video.SearchAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `VideoSearchParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **Query** <br> `string` | Поисковый запрос. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **Sort** <br> `int` | Сортировка (например, 2 — по дате добавления). <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 2</span> |
| **Offset** <br> `int` | Смещение относительно начала выборки. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество видеозаписей. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20, максимум: 200</span> |

</div>

<div class="vk-card">

# Результат

Возвращает расширенную коллекцию `ExtendedCollection<Video>` с найденными объектами видеозаписей [Video](/reference/models/video/video).

</div>
