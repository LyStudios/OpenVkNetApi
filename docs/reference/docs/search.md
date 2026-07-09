<div class="vk-card">

# docs.search

Выполняет глобальный поиск по публичным документам системы OpenVK.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Docs;

var parameters = new DocsSearchParams
{
    Query = "дипломная работа",
    Count = 10,
    Offset = 0
};

var docsCollection = await api.Docs.SearchAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `DocsSearchParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **Query** <br> `string` | Поисковый запрос (ключевые слова для поиска). <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **Count** <br> `int` | Количество документов, которое необходимо вернуть. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20, максимум: 1000</span> |
| **Offset** <br> `int` | Смещение для выборки определенного подмножества документов. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<Doc>`, содержащую список найденных объектов [Doc](/reference/models/docs/doc).

</div>
