<div class="vk-card">

# docs.get

Возвращает список документов пользователя или сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Docs;

var parameters = new DocsGetParams
{
    Count = 10,
    Offset = 0,
    Type = 1 // Текстовые документы
};

var docsCollection = await api.Docs.GetAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `DocsGetParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **Count** <br> `int` | Количество документов, которое необходимо вернуть. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20, максимум: 2000</span> |
| **Offset** <br> `int` | Смещение для выборки определенного подмножества документов. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Type** <br> `int?` | Тип документов для фильтрации (например, 1 — книги, 2 — гифки и др.). <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **OwnerId** <br> `int?` | Идентификатор владельца документов (если не передан, возвращаются документы текущего пользователя). <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<Doc>`, содержащую список объектов [Doc](/reference/models/docs/doc).

</div>
