<div class="vk-card">

# docs.edit

Редактирует название и теги документа.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя. Редактировать документ могут только его владельцы.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Docs;

var parameters = new DocsEditParams
{
    OwnerId = 1,
    DocId = 456239012,
    Title = "Новое название документа",
    Tags = "книга, программирование"
};

int result = await api.Docs.EditAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `DocsEditParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **OwnerId** <br> `int` | Идентификатор владельца документа. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **DocId** <br> `int` | Идентификатор документа. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **Title** <br> `string` | Новый заголовок (название) документа. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Tags** <br> `string` | Новые теги для документа, разделенные запятыми. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного выполнения.

</div>
